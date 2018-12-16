using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.Diagnostics;
using CW.BO.DataModel;
using CW.BO.Business;
using CW.COMMON;
using CW.Common;

namespace CW.MAIN
{
    public partial class FrmUserGroupRoles : Form
    {
        #region Property

        private List<FormButtonDTO> formbuttonlist = new List<FormButtonDTO>();
        private FormButtonDTO formbutton = new FormButtonDTO();
        private CWUserGroupRolesDTO usergrouproles = new CWUserGroupRolesDTO();
        private List<CWUserGroupRolesDTO> listusergrouproles = new List<CWUserGroupRolesDTO>();
        private List<CWUserGroupDTO> listusergroup = new List<CWUserGroupDTO>();
        private List<CWUserDTO> listuser = new List<CWUserDTO>();
        private List<string> listbutton = new List<string>();
        int intColActNo = 0;

        #endregion

        public FrmUserGroupRoles()
        {
            InitializeComponent();
        }

        public FrmUserGroupRoles(MenuStrip _mainform)
        {
            InitializeComponent();

            listbutton = CWUser._UserGroupRoles.Where(x => x.Parent == this.Text && x.Tag == "button" && x.Permission == true).Select(y => y.elementName).ToList();
            ButtonMapperHelper.GetButtons(this, listbutton);

            formbuttonlist = CWUserGroup.RetrieveAllFormButton();
            PopulateToolstripMenuItem(_mainform);
            listusergroup = CWUserGroup.RetrieveAllUserGroup();
            lboUserGroup.DataSource = listusergroup.Select(x => x.Id).ToList();
            listusergrouproles = CWUserGroup.RetrieveAllUserGroupRoles();
            GetAllForm();
            listuser = CWUser.GetAllUser();
            lboUser.DataSource = listuser.Where(y => y.UsergroupId == "ADM").Select(x => x.UserId).ToList();

        }

        #region GetAllForm

        private void GetAllForm()
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetEntryAssembly();
            Type[] Types = myAssembly.GetTypes();
            foreach (Type myType in Types)
            {
                if (myType.BaseType == null) continue;

                if (myType.BaseType.Name.ToUpper() == "FORM")
                {
                    if (myType.Name.ToUpper().Contains("MAIN")) continue;

                    GetAllButtonForm(myType.Name.ToString());
                }

            }
            CWUserGroup.UpdateFormButton(formbuttonlist);
        }

        private void GetAllButtonForm(string FormName)
        {
            var form = (Form)Activator.CreateInstance(Type.GetType(this.GetType().Namespace + "." + FormName));

            if (form.Name == "Shipment Plan")
            {
                MessageBox.Show("ok");
            }

            if (form.Tag != null && form.Tag != string.Empty)
            {
                foreach (var det in form.Tag.ToString().Split(','))
                {
                    form = (Form)Activator.CreateInstance(Type.GetType(this.GetType().Namespace + "." + FormName));

                    formbutton = new FormButtonDTO();
                    formbutton.FormName = det;
                    formbutton.ObjectState = EntityState.New;

                    foreach (Control c in form.Controls)
                    {
                        RecursiveButton(c, det);
                    }
                    intColActNo = 0;

                    form.Dispose();
                    if (formbutton.ObjectState == EntityState.New)
                    {
                        formbuttonlist.Add(formbutton);
                    }
                }
            }
            else
            {

                formbutton = formbuttonlist.FirstOrDefault(x => x.FormName == form.Text);
                if (formbutton == null)
                {
                    formbutton = new FormButtonDTO();
                    formbutton.FormName = form.Text.ToString();
                    formbutton.ObjectState = EntityState.New;

                }
                else
                { formbutton.ObjectState = EntityState.None; }


                foreach (Control c in form.Controls)
                {
                    RecursiveButton(c, form.Text.ToString());
                }
                intColActNo = 0;

                form.Dispose();
                if (formbutton.ObjectState == EntityState.New)
                {
                    formbuttonlist.Add(formbutton);

                }
            }
        }

        private void RecursiveButton(Control mycontrol, string formtag)
        {
            if (mycontrol.HasChildren)
            {
                foreach (Control ac in mycontrol.Controls)
                {
                    RecursiveButton(ac, formtag);
                }
            }


            else if (mycontrol.GetType() == typeof(Button) || mycontrol.GetType() == typeof(DevComponents.DotNetBar.ButtonX))
            {
                intColActNo += 1;
                //   string strColActNo = 
                AddToFormButton("btn" + intColActNo.ToString(), mycontrol.Text);
            }
        }

        private void AddToFormButton(string propertyName, object propertyValue)
        {

            PropertyInfo propertyInfo = formbutton.GetType().GetProperty(propertyName);

            if (propertyInfo != null && propertyInfo.GetValue(formbutton) != propertyValue)
            {
                propertyInfo.SetValue(formbutton, propertyValue, null);
                formbutton.ObjectState = formbutton.ObjectState == EntityState.Delete ? EntityState.Update : formbutton.ObjectState;
            }

        }

        #endregion GetAllForm

        #region method

        private void PopulateUser(string _UserGroupId)
        {
            List<string> userList = listuser.Where(y => y.UsergroupId == _UserGroupId).Select(x => x.Username).ToList();
            lboUser.DataSource = userList;
            if (userList.Count < 1) { PopulateItemCheckedToRoles(null, _UserGroupId); }
        }

        private void PopulateUserGroupRoles(string _UserId, string _UserGroupId)
        {
            PopulateItemCheckedToRoles(_UserId, _UserGroupId);
        }

        private void AddRecursiveNode(TreeNode noderef, bool Checked, string _UserId)
        {
            foreach (TreeNode anode in noderef.Nodes)
            {
                usergrouproles = listusergrouproles.FirstOrDefault(x => x.MenuPath == anode.FullPath && x.UserId == _UserId);

                usergrouproles.ObjectState = usergrouproles.ObjectState == EntityState.None ? EntityState.Update : usergrouproles.ObjectState;
                usergrouproles.Permission = anode.Checked = Checked;
                AddRecursiveNode(anode, Checked, _UserId);

            }
        }

        private TreeNode SetImageButtonNote(string buttonstring)
        {
            TreeNode _actnode = new TreeNode(buttonstring);
            int imageIndex = imageList1.Images.IndexOfKey(buttonstring.Replace("&", ""));
            _actnode.Tag = "button";
            _actnode.ImageIndex = imageIndex == -1 ? 0 : imageIndex;
            _actnode.SelectedImageIndex = imageIndex == -1 ? 0 : imageIndex;
            return _actnode;

        }

        private void PopulateItemCheckedToRoles(string _UserId, string _UserGroupId)
        {
            IEnumerator ienum = tvUserGroupRoles.Nodes.GetEnumerator();
            while (ienum.MoveNext())
            {
                TreeNode anode = (TreeNode)ienum.Current;
                usergrouproles = listusergrouproles.SingleOrDefault(x => x.UserId == _UserId && x.MenuPath == anode.FullPath);
                if (usergrouproles == null)
                {
                    anode.Checked = _UserGroupId == "ADM";
                    usergrouproles = new CWUserGroupRolesDTO();
                    usergrouproles.ObjectState = EntityState.New;
                    usergrouproles.UserId = _UserId;
                    usergrouproles.MenuName = anode.Text;
                    usergrouproles.MenuPath = anode.FullPath;
                    usergrouproles.Permission = anode.Checked;
                    usergrouproles.Tag = anode.Tag != null ? anode.Tag.ToString() : "";
                    usergrouproles.Parent = anode.Parent != null ? anode.Parent.Text : "";
                    if (anode.Parent != null)
                    {
                        TreeNode _parent = (TreeNode)anode.Parent;
                        if (_parent.Tag.ToString() == "menudetail")
                        {
                            usergrouproles.GrandParent = _parent.Parent.Text;
                        }
                    }
                    listusergrouproles.Add(usergrouproles);
                }
                else
                {
                    anode.Checked = usergrouproles.Permission;
                }
                PopulateItemCheckedToRolesRecursive(_UserGroupId, _UserId, anode);
            }
        }

        private void PopulateItemCheckedToRolesRecursive(string _UserGroupId, string _UserId, TreeNode _noderef)
        {

            foreach (TreeNode t in _noderef.Nodes)
            {
                // usergrouproles = new CWUserGroupRolesDTO();
                usergrouproles = listusergrouproles.SingleOrDefault(x => x.MenuPath == t.FullPath && x.UserId == _UserId);
                //  if (usergrouproles)
                if (usergrouproles == null)
                {
                    t.Checked = _UserGroupId == "ADM";
                    usergrouproles = new CWUserGroupRolesDTO();
                    usergrouproles.ObjectState = EntityState.New;
                    usergrouproles.UserId = _UserId;
                    usergrouproles.MenuName = t.Tag != null ? t.Tag.ToString() : t.Text.ToString();
                    usergrouproles.MenuPath = t.FullPath;
                    usergrouproles.Permission = t.Checked;
                    usergrouproles.Tag = t.Tag != null ? t.Tag.ToString() : "";
                    usergrouproles.Parent = t.Parent != null ? t.Parent.Text : "";
                    if (t.Parent != null)
                    {
                        TreeNode _parent = (TreeNode)t.Parent;
                        if (_parent.Tag != null)
                        {
                            if (_parent.Tag.ToString() == "menudetail")
                            {
                                usergrouproles.GrandParent = _parent.Parent.Text;
                            }
                        }
                    }
                    listusergrouproles.Add(usergrouproles);

                }
                else
                {
                    t.Checked = usergrouproles.Permission;
                }

                PopulateItemCheckedToRolesRecursive(_UserGroupId, _UserId, t);

            }

        }

        private void AddMenuToTree(TreeNode _tnode, ToolStripMenuItem _t)
        {
            if (_t.DropDownItems.Count > 0)
            {
                for (int i = 0; i < _t.DropDownItems.Count; i++)
                {
                    if (_t.DropDownItems[i].GetType() != typeof(ToolStripMenuItem)) continue;
                    ToolStripMenuItem citem = (ToolStripMenuItem)_t.DropDownItems[i];

                    TreeNode tnode = new TreeNode(citem.Tag != null ? citem.Tag.ToString() : citem.Text.ToString());
                    tnode.Tag = "menu";
                    _tnode.Nodes.Add(tnode);
                    AddMenuToTree(tnode, citem);
                    if (citem.DropDown.Items.Count == 0)
                    {

                        FormButtonDTO formbutton = formbuttonlist.FirstOrDefault(x => x.FormName == tnode.Text);
                        if (formbutton != null)
                        {
                            foreach (var property in formbutton.GetType().GetProperties())
                            {
                                if (property.ToString().Contains("btn"))
                                {
                                    if (!string.IsNullOrEmpty((string)property.GetValue(formbutton) ?? ""))
                                    {
                                        //   TreeNode actnode = new TreeNode(property.GetValue(formbutton).ToString());
                                        TreeNode actnode = SetImageButtonNote((string)property.GetValue(formbutton));

                                        tnode.Tag = "menuform";
                                        tnode.Nodes.Add(actnode);
                                    }
                                }

                            }

                        }

                        if (citem.AccessibleName != null)
                        {
                            if (citem.AccessibleName.ToLower() == "menudetail")
                            {
                                TreeNode detailnode = SetImageButtonNote(citem.AccessibleDescription);

                                tnode.Nodes.Add(detailnode);
                                formbutton = formbuttonlist.FirstOrDefault(x => x.FormName == detailnode.Text);
                                if (formbutton != null)
                                {
                                    foreach (var property in formbutton.GetType().GetProperties())
                                    {
                                        if (property.ToString().Contains("btn"))
                                        {
                                            if (!string.IsNullOrEmpty((string)property.GetValue(formbutton) ?? ""))
                                            {
                                                //   TreeNode actnode = new TreeNode(property.GetValue(formbutton).ToString());
                                                TreeNode detailactnode = SetImageButtonNote((string)property.GetValue(formbutton));

                                                detailnode.Tag = "menudetail";
                                                // detailnode.
                                                detailnode.Nodes.Add(detailactnode);
                                            }
                                        }

                                    }

                                }
                            }
                        }
                    }

                }
            }
        }

        private void PopulateToolstripMenuItem(MenuStrip mainformMenustrip)
        {
            foreach (ToolStripMenuItem t in mainformMenustrip.Items)
            {
                TreeNode tnode = new TreeNode(t.Text.ToString());
                t.Tag = "menu";
                t.ImageIndex = 0;
                tvUserGroupRoles.Nodes.Add(tnode);
                AddMenuToTree(tnode, t);

            }
            tvUserGroupRoles.SelectedNode = tvUserGroupRoles.Nodes[0];
        }

        #region InsertDefaultRoles
        private void InsertDefaultUsergroupToRoles(string _UserGroupId)
        {

            IEnumerator ienum = tvUserGroupRoles.Nodes.GetEnumerator();
            while (ienum.MoveNext())
            {
                TreeNode anode = (TreeNode)ienum.Current;

                usergrouproles = listusergrouproles.SingleOrDefault(x => x.MenuPath == anode.FullPath && x.UserId == _UserGroupId);
                //  if (usergrouproles)
                if (usergrouproles == null)
                {
                    usergrouproles = new CWUserGroupRolesDTO();
                    usergrouproles.ObjectState = EntityState.New;
                }
                //jika admin true sisa false  
                anode.Checked = _UserGroupId == "ADM";

                usergrouproles.UserId = _UserGroupId;
                usergrouproles.MenuName = anode.Text;
                usergrouproles.MenuPath = anode.FullPath;
                usergrouproles.Permission = anode.Checked;
                usergrouproles.Tag = anode.Tag != null ? anode.Tag.ToString() : "";
                usergrouproles.Parent = anode.Parent != null ? anode.Parent.Text : "";

                TreeNode _parent = (TreeNode)anode.Parent;
                if (_parent.Tag.ToString() == "menudetail")
                {
                    usergrouproles.GrandParent = _parent.Parent.Text;
                }
                if (usergrouproles.ObjectState == EntityState.New)
                {
                    listusergrouproles.Add(usergrouproles);
                }
                if (usergrouproles.ObjectState == EntityState.None)
                {
                    usergrouproles.ObjectState = EntityState.Update;
                }
                InsertDefaultUserGrouptoRolesRecursive(_UserGroupId, anode);

            }

        }
        private void InsertDefaultUserGrouptoRolesRecursive(string _UserGroupId, TreeNode _noderef)
        {

            foreach (TreeNode t in _noderef.Nodes)
            {
                // usergrouproles = new CWUserGroupRolesDTO();
                usergrouproles = listusergrouproles.SingleOrDefault(x => x.MenuPath == t.FullPath && x.UserId == _UserGroupId);
                //  if (usergrouproles)
                if (usergrouproles == null)
                {
                    usergrouproles = new CWUserGroupRolesDTO();
                    usergrouproles.ObjectState = EntityState.New;
                }

                t.Checked = _UserGroupId == "ADM";
                usergrouproles.UserId = _UserGroupId;
                usergrouproles.MenuName = t.Text;
                usergrouproles.Permission = t.Checked;
                usergrouproles.MenuPath = t.FullPath;
                usergrouproles.Tag = t.Tag != null ? t.Tag.ToString() : "";
                usergrouproles.Parent = t.Parent != null ? t.Parent.Text : "";

                TreeNode _parent = (TreeNode)t.Parent;
                if (_parent.Tag.ToString() == "menudetail")
                {
                    usergrouproles.GrandParent = _parent.Parent.Text;
                }
                listusergrouproles.Add(usergrouproles);


                InsertDefaultUserGrouptoRolesRecursive(_UserGroupId, t);

            }

        }


        #endregion InsertDefaultRoles

        #endregion method

        #region event

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void lboUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateUser(lboUserGroup.SelectedItem.ToString());
            //PopulateUserGroupRoles(lboUserGroup.SelectedItem.ToString());
        }

        private void lboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            listusergrouproles = CWUserGroup.RetrieveAllUserGroupRoles(lboUser.SelectedItem.ToString());
            PopulateUserGroupRoles(lboUser.SelectedItem.ToString(), lboUserGroup.SelectedItem.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to save user group roles?", "system info", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                CWUserGroup.UpdateSFISUserGroupRoles(listusergrouproles);
                listusergrouproles = new List<CWUserGroupRolesDTO>();
                listusergrouproles = CWUserGroup.RetrieveAllUserGroupRoles(lboUser.SelectedItem.ToString());
            }
        }

        private void tvUserGroupRoles_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Action != TreeViewAction.Unknown)
                {

                    if (e.Node.Checked)
                    {
                        if (lboUser.Items.Count > 0)
                        {
                            usergrouproles = listusergrouproles.FirstOrDefault(x => x.MenuPath == e.Node.FullPath && x.UserId == lboUser.SelectedItem.ToString());
                            usergrouproles.ObjectState = usergrouproles.ObjectState == EntityState.None ? EntityState.Update : usergrouproles.ObjectState;
                            usergrouproles.Permission = e.Node.Checked;
                            if (e.Node.Parent != null)
                            {
                                usergrouproles = listusergrouproles.FirstOrDefault(x => x.MenuPath == e.Node.Parent.FullPath && x.UserId == lboUser.SelectedItem.ToString());
                                usergrouproles.ObjectState = usergrouproles.ObjectState == EntityState.None ? EntityState.Update : usergrouproles.ObjectState;
                                usergrouproles.Permission = e.Node.Parent.Checked = e.Node.Checked;
                            }
                        }
                        else
                        {
                            e.Node.Checked = false;
                            MessageBox.Show("Please register a user for your selected user group !");
                        }
                    }
                    else
                    {
                            usergrouproles = listusergrouproles.FirstOrDefault(x => x.MenuPath == e.Node.FullPath && x.UserId == lboUser.SelectedItem.ToString());
                            usergrouproles.ObjectState = usergrouproles.ObjectState == EntityState.None ? EntityState.Update : usergrouproles.ObjectState;
                            usergrouproles.Permission = false;
                            AddRecursiveNode(e.Node, false, lboUser.SelectedItem.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                AddFunc.MsgError(ex.Message);
            }
        }

        #endregion event

    }
}

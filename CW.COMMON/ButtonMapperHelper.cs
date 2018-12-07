using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CW.COMMON
{
 public class ButtonMapperHelper

    {

     public static void EnableButtons(Control ctrl, List<string> listOfbutton)
        {
            if (listOfbutton.Count > 0)
            {
                foreach (Control aControl in ctrl.Controls)
                {
                    GetEnableButton(aControl, listOfbutton);
                }

            }
        }

     public static void GetButtons(Form frm, List<string> listOfbutton)
     {
         foreach (Control aControl in frm.Controls)
         {
             GetVisibleButton(aControl, listOfbutton);
         }
     }
     private static void GetVisibleButton(Control ctrl, List<string> listOfbutton)
     {
         //if (ctrl.HasChildren)
         //{
         //    foreach (Control AchildCtrl in ctrl.Controls)
         //    { 
         //     GetVisibleButton(AchildCtrl ,listOfbutton);
         //    }
         //}
         //else if (ctrl.GetType() == typeof(Button) || ctrl.GetType() == typeof(Infragistics.Win.Misc.UltraButton))
         //{
         //    if (listOfbutton.Contains(ctrl.Text))
         //    { ctrl.Visible = true; }
         //    else
         //    { ctrl.Visible = false; }
         //}

     }
 
        private static  void GetEnableButton(Control ctrl, List<string> listOfbutton)
        {
            
            if (ctrl.HasChildren)
                foreach (Control actrl in ctrl.Controls)
                {

                    GetEnableButton(actrl, listOfbutton);
                }

            else if (ctrl.GetType() == typeof(Button) || ctrl.GetType() == typeof(DevComponents.DotNetBar.ButtonX))
            {       
                if (listOfbutton.Contains(ctrl.Text.Replace("&","") ))
                { ctrl.Enabled = true; }

                else
                { ctrl.Enabled = false;}
            }
        }

        public static void populateItemAwal(MenuStrip ms)
        {
            IEnumerator ienum = ms.Items.GetEnumerator();
            while (ienum.MoveNext())
            {
                ToolStripMenuItem ts = (ToolStripMenuItem)ienum.Current;
                ts.Enabled = false;
            }

        }
        public static void PopulateMenuItem(MenuStrip ms,List<string> listmenuitem)
        {
            IEnumerator ienum = ms.Items.GetEnumerator();
            while (ienum.MoveNext())
            {
                ToolStripMenuItem ts = (ToolStripMenuItem)ienum.Current;

                if (listmenuitem.Contains(ts.Text))
                { 
                  ts.Visible = true; 
                }
                else
                { 
                  ts.Visible = false; 
                }
                PopulateMenuItemrecursive(ts, listmenuitem);
            }

        }
        private static void PopulateMenuItemrecursive(ToolStripMenuItem ts, List<string> listmenuitem)
        {
            for (int i = 0; i < ts.DropDownItems.Count; i++)
            {
                if (ts.GetType() != typeof(ToolStripMenuItem))
                {
                    continue;
                }

                if (listmenuitem.Contains(ts.DropDownItems[i].Tag != null ? ts.DropDownItems[i].Tag : ts.DropDownItems[i].Text))
                {
                    ts.DropDownItems[i].Visible = true;
                }
                else
                {
                    ts.DropDownItems[i].Visible = false;
                }
                PopulateMenuItemrecursive((ToolStripMenuItem)ts.DropDownItems[i], listmenuitem);
            }
        
        }    
    }
}

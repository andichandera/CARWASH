using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CW.COMMON
{
    public class AddFunc
    {
        public static Boolean isNotNullAndNotEmpty(String TextValue)
        {
            Boolean result = true;
            try
            {
                if (TextValue != string.Empty && TextValue != null)
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static Boolean CompareBetweenInt(Int32 Value, Int32 FromValue, Int32 ToValue)
        {
            Boolean result = true;
            try
            {
                if (FromValue > Value && Value < ToValue)
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static Boolean CheckStringExistsList(string value, params string[] args)
        {
            Boolean result = true;
            try
            {
                List<String> Strings = new List<String>();
                foreach (var det in args)
                {
                    Strings.Add(det);
                }
                if (!Strings.Any(x => x == value))
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static void MsgError(String Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MsgInfo(String Message)
        {
            MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MsgWarning(String Message)
        {
            MessageBox.Show(Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static Boolean MsgQuesYESNO(String Message)
        {
            bool result = false;

            if (MessageBox.Show(Message, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                result = true;
            }

            return result;
        }

        public static string CheckControlTextBoxStringEmpty(params TextBox[] TextValue)
        {
            String ReturnMessage = string.Empty;
            try
            {
                foreach (TextBox det in TextValue)
                {
                    if (det.Text == string.Empty)
                    {
                        ReturnMessage = "Please fill in the " + det.AccessibleName;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ReturnMessage;
        }

        public static string CheckComboBoxValue(params ComboBox[] ComboValue)
        {
            String ReturnMessage = string.Empty;
            try
            {
                foreach (ComboBox det in ComboValue)
                {
                    if (det.SelectedIndex == -1)
                    {
                        ReturnMessage = "Please select value in the " + det.AccessibleName;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ReturnMessage;
        }

        public static string CheckNumericZero(params NumericUpDown[] NumericValue)
        {
            String ReturnMessage = string.Empty;
            try
            {
                foreach (NumericUpDown det in NumericValue)
                {
                    if (det.Value == 0)
                    {
                        ReturnMessage = "Please fill in the " + det.AccessibleName;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ReturnMessage;
        }

        public static DataGridView HideSpecificColoum(DataGridView dg, params String[] NumericValue)
        {
            DataGridView dgDet = dg;

            foreach (DataGridViewColumn dgCol in dgDet.Columns)
            {
                if (NumericValue.Any(x => x.Contains(dgCol.Name.ToUpper())))
                {
                    dgCol.Visible = false;
                }
            }

            return dgDet;
        }

        public static DataGridView ShowSpecificColoum(DataGridView dg, params String[] NumericValue)
        {
            DataGridView dgDet = dg;


            foreach (DataGridViewColumn dgCol in dgDet.Columns)
            {
                if (!NumericValue.Any(x => x.Contains(dgCol.Name.ToUpper())))
                {
                    dgCol.Visible = false;
                }
            }

            return dgDet;
        }

        public static bool ParseWeightScale(string input, out double value)
        {
            const string Numbers = "0123456789.";
            var numberBuilder = new StringBuilder();
            foreach (char c in input)
            {
                if (Numbers.IndexOf(c) > -1)
                    numberBuilder.Append(c);
            }
            return double.TryParse(numberBuilder.ToString(), out value);
        }

        public static Screen GetSecondaryScreen()
        {
            if (Screen.AllScreens.Length == 1)
            {
                return null;
            }

            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Primary == false)
                {
                    return screen;
                }
            }

            return null;
        }

        public static void SetColorTextBox(TextBox controlTextbox, Color ColorType, String ResultText)
        {
            controlTextbox.BackColor = ColorType;
            controlTextbox.Text = ResultText;
        }

        public static void SetColorTextBox(TextBox controlTextbox, Color ColorType, String ResultText, Boolean isFocus, TextBox controlFocusText)
        {
            controlTextbox.BackColor = ColorType;
            controlTextbox.Text = ResultText;

            if (isFocus)
            {
                controlFocusText.Focus();
                controlFocusText.SelectAll();
            }
        }

        public static void SetColorLabel(Label controlTextbox, Color ColorType, String ResultText)
        {
            controlTextbox.BackColor = ColorType;
            controlTextbox.Text = ResultText;
        }

        public static void SetColorLabel(Label controlTextbox, Color ColorType, String ResultText, Boolean isFocus, TextBox controlFocusText)
        {
            controlTextbox.BackColor = ColorType;
            controlTextbox.Text = ResultText;

            if (isFocus)
            {
                controlFocusText.Focus();
                controlFocusText.SelectAll();
            }
        }
    }
}

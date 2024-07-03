using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_7_2024
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label9.Text = $"Name: { TextBox1.Text}";
            Label10.Text =$"Email: { TextBox2.Text}";
            Label11.Text = $"Id: {TextBox3.Text}";

            if (CheckBox1.Checked)
            {
                Label12.Text = CheckBox1.Text;
            }
            else
            {
                Label12.Text ="";
            }
            if (CheckBox2.Checked)
            {
                Label13.Text = CheckBox2.Text;
            }
            else
            {
                Label13.Text = "";
            }
            if (CheckBox3.Checked)
            {
                Label14.Text = CheckBox3.Text;
            }
            else
            {
                Label14.Text = "";
            }

            if (RadioButtonList1.SelectedItem.Selected)
            {
                Label15.Text = RadioButtonList1.SelectedItem.Text;
            }
            Label16.Text = $"description: {TextArea1.Value}";
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
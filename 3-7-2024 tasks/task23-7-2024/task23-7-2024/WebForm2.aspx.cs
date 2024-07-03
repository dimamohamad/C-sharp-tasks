using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task23_7_2024
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int add = x + y;
            Label3.Text = $"the sum is {add}";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int substract = x - y;
            Label3.Text = $"the substract is {substract}";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int multiply = x * y;
            Label3.Text = $"the mulitply is {multiply}";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int division = x / y;
            Label3.Text = $"the division is {division}";
        }


    }
}
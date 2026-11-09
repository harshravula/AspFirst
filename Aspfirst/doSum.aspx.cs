using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aspfirst
{
    public partial class doSum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = (int.Parse(TextBox1.Text) + int.Parse(TextBox2.Text)).ToString();
        }
        protected void btnSum_Click(object sender, EventArgs e)
        {
            if (int.TryParse(t1.Value, out int a) && int.TryParse(t2.Value, out int b))
            {
                t3.Value = (a + b).ToString();
            }
            else
            {
                t3.Value = "";
            }
        }
    }
}
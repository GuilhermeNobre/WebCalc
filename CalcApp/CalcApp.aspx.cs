using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalcApp
{
    public partial class CalcApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            if(this.TextBox1 == null && this.TextBox2 == null)
            {
                LabelResult.Text = "Não existem valores";
                return;
            }
            var num1 = Convert.ToDecimal(this.TextBox1.Text);
            var num2 = Convert.ToDecimal(this.TextBox2.Text);
            var result = num1 + num2;

            LabelResult.Visible = true;
            LabelResult.Text = result.ToString();
        }

        protected void ButtonSub_Click(object sender, EventArgs e)
        {
            var result = Convert.ToDecimal(this.TextBox1.Text) - Convert.ToDecimal(this.TextBox2.Text);

            LabelResult.Visible = true;
            LabelResult.Text = result.ToString();
        }

        protected void ButtonMulti_Click(object sender, EventArgs e)
        {
            var result = Convert.ToDecimal(this.TextBox1.Text) * Convert.ToDecimal(this.TextBox2.Text);

            LabelResult.Visible = true;
            LabelResult.Text = result.ToString();
        }

        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(this.TextBox1.Text);
            var num2 = Convert.ToDecimal(this.TextBox2.Text);
            
            if(num1 == 0)
            {
                var zero_result = 0;
                LabelResult.Visible = true;
                LabelResult.Text = zero_result.ToString();
            }
            else if(num2 == 0)
            {
                LabelResult.Visible = true;
                LabelResult.Text = "NÃO É POSSIVEL DIVIDIR POR ZERO";
            }
            else
            {
                var result = num1 / num2;
                LabelResult.Visible = true;
                LabelResult.Text = result.ToString("0.00");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4Task2B
{
    public partial class WebForm1L4T2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int result = 0; int opt = 1;
            int number1 = Convert.ToInt32(TextBox1.Text);
            int number2 = Convert.ToInt32(TextBox2.Text);
            // int opt = Convert.ToInt32(TextBox3.Text);



            if (CheckBox1.Checked)
            {
                opt = 1;
                CheckBox2.Checked = false;
            }
            else if (CheckBox2.Checked)
            {
                opt = 2;
                CheckBox1.Checked = false;
            }
            //if (opt == 1) result=MathClass.Add(number1, number2);
            // else if (opt == 2) result= MathClass.Sub(number1, number2);

           result = MathClass.getPointer(opt).Invoke(number1, number2); //changing to Mathclass will not need to change this class

            //result = MathClass.getPointer(opt, number1, number2);
            // Console.WriteLine(MathClass.getPointer(opt, number1, number2));

            TextBox4.Text = result.ToString();

        }
    }
}
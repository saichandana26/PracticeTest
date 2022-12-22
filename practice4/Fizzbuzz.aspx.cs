using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace practice4
{
    public partial class Fizzbuzz : System.Web.UI.Page
    {
        Day d=new Day();
        Display Displayobject = new Display();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TextBox1.Text);
            Label2.Text= "Entered number is "+TextBox1.Text;
            string s1=Convert.ToString(DateTime.Today.DayOfWeek);
            if (s1 == "wednesday")
            {
                Displayobject.show(n, "wizz", "wuzz");
            }
            else {
                Displayobject.show(n,"fizz", "buzz");
            }
            foreach(string i in Displayobject.l1){

                Label3.Text = Label3.Text + Environment.NewLine + i;

            }

            
        }
    }
}
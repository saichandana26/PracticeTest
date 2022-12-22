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
            int numrows = Displayobject.l1.Count;
            int numcells = 1;
            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell();
                    c.Controls.Add(new LiteralControl(Displayobject.l1[j]));
                    r.Cells.Add(c);
                }
                Table1.Rows.Add(r);
            }
        }
    }
}
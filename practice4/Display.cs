using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practice4
{
    public class Display 
    {
        public int Number { get; set; }
        public List<string> l1=new List<string>();
        public List<string> show(int n,string a,string b) {

            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 & i % 5 == 0) { l1.Add(a + b); continue; }
                if (i % 3 == 0) { l1.Add(a); continue; }
                if (i % 5 == 0) {l1.Add(b); continue; }
                l1.Add(Convert.ToString(i));
            }

            return l1;

        
           }


    }
}
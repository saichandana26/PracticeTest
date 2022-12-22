using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace practice4
{
    public class Day
    {
        public string s = Convert.ToString(DateTime.Today.DayOfWeek);
    }
}
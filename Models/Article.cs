using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_Prac7.Models
{
    public class Article : Publication
    {
        public override string ToString()
        {
            string res = "";
            //res += $"The date of publication is {PublicationDate.DayOfWeek}";
            //res += $", {PublicationDate.Day} {PublicationDate.Month} {PublicationDate.Day}";
            res = $"The date of publication is {PublicationDate:dddd, dd MMMM yyyy}";
            return res;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u23717662_Prac7.Models
{
    public class Book:Publication
    {
        public String Editions { get; set; }
        public override string ToString()
        {
            string sure = "";
            sure = $"The date of publication is {PublicationDate:dddd, dd MMMM yyyy}";
            sure += $" and the number of editions is {Editions}";
            return sure;
        }
    }
}
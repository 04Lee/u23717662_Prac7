﻿using System.Web;
using System.Web.Mvc;

namespace u23717662_Prac7
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

﻿using System.Web;
using System.Web.Mvc;

namespace _22_SessionLoginMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

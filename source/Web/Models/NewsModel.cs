using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace CompanySite.Models
{

    public class NewsModel
    {

        public News News { get; set; }
        public IEnumerable<News> NewsList { get; set; }
        public IEnumerable<SelectListItem> NewsClassList { get; set; }
        public Pagination Page { get; set; }
    }
}
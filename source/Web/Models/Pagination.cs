using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace CompanySite.Models
{
    /// <summary>
    /// pagecount = (totalRecord+pageSize-1)/pageSize
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// total number of records
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// number of per page
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// control/action
        /// </summary>
        public string BaseUrl { get; set; }
        public int CurrentPage { get; set; }
        public bool HasNext { get; set; }
        public bool HasPrevious { get; set; }
        /// <summary>
        /// how many does the pagination group the page number.
        /// </summary>
        public int PageGroup { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace CompanySite.Models
{
    public partial class User
    {
        public User()
        {
            this.LoginLogs = new HashSet<LoginLog>();
            this.News = new HashSet<News>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<LoginLog> LoginLogs { get; set; }
        public virtual ICollection<News> News { get; set; }
    }
    
}

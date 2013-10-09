//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NkjSoft.Models.T4
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public Users()
        {
            this.Roles = new HashSet<Roles>();
            this.LoginLogs = new HashSet<LoginLogs>();
        }
    
        public System.Guid ApplicationId { get; set; }
        public System.Guid UserId { get; set; }
        public string UserName { get; set; }
        public bool IsAnonymous { get; set; }
        public System.DateTime LastActivityDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
    
        public virtual Applications Applications { get; set; }
        public virtual Memberships Memberships { get; set; }
        public virtual Profiles Profiles { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<LoginLogs> LoginLogs { get; set; }
    }
}

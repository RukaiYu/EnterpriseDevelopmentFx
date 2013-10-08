//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NkjSoft.Core.Models.Security
{
    using NkjSoft.Core.Models.Account;
    using NkjSoft.Framework.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Roles : EntityBase<Guid>
    {
        public Roles()
        {
            this.Users = new HashSet<Users>();
            RoleId = GuidGenerator.NewComb();
        }

        public System.Guid ApplicationId { get; set; }

        [Key]
        public System.Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public virtual Applications Applications { get; set; }

        public virtual ICollection<Users> Users { get; set; }

        public override Guid __KeyId
        {
            get { return this.RoleId; }
        }
    }
}

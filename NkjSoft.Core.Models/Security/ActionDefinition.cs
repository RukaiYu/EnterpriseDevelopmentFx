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
    using NkjSoft.Framework.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ActionDefinition : IdBasedEntityBase<Guid>
    {
        public ActionDefinition()
        {
            Id = Guid.NewGuid();
            ShowAsMenu = false;
            this.Roles = new HashSet<Roles>();
        }

        public string Text { get; set; }

        public string Code { get; set; }

        public string Area { get; set; }
        public string ActionName { get; set; }
        public string Controller { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public bool ShowAsMenu { get; set; }
        public string Style { get; set; }

        public Nullable<int> Order { get; set; }

        [ForeignKey("ParentNode")]
        public Nullable<Guid> ParentNode_Id { get; set; }

        [ForeignKey("ParentNode_Id")]
        public ActionDefinition ParentNode { get; set; }

        public ICollection<Roles> Roles { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NkjSoft.Model.Common
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profiles
    {
        public System.Guid UserId { get; set; }
        public string PropertyNames { get; set; }
        public string PropertyValueStrings { get; set; }
        public byte[] PropertyValueBinary { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual Users Users { get; set; }
    }
}

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
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class Profiles_Mapping : EntityTypeConfiguration<Profiles>
    {
        public Profiles_Mapping()
        {                        
              this.HasKey(t => t.UserId);        
              this.ToTable("Profiles");
              this.Property(t => t.UserId).HasColumnName("UserId");
              this.Property(t => t.PropertyNames).HasColumnName("PropertyNames").IsRequired().HasMaxLength(4000);
              this.Property(t => t.PropertyValueStrings).HasColumnName("PropertyValueStrings").IsRequired().HasMaxLength(4000);
              this.Property(t => t.PropertyValueBinary).HasColumnName("PropertyValueBinary").IsRequired();
              this.Property(t => t.LastUpdatedDate).HasColumnName("LastUpdatedDate");
              this.HasRequired(t => t.Users).WithOptional(t => t.Profiles);
         }
    }
}

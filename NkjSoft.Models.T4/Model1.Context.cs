﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1573
namespace NkjSoft.Models.T4
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        static Entities()
    	{ 
    		Database.SetInitializer<Entities>(null);
    	}
    	
    	public Entities() : base("name=Entities")
        {
        }
    	
    	public Entities(string nameOrConnectionString) : base(nameOrConnectionString)
    	{	
    	}
    
    	public Entities(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
    	{
    	}
    
    	public Entities(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
    	{
    	}
    
    	public Entities(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
    	{
    	}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {		
    		modelBuilder.Configurations.Add(new ActionDefinition_Mapping());
    		modelBuilder.Configurations.Add(new Applications_Mapping());
    		modelBuilder.Configurations.Add(new LoginLogs_Mapping());
    		modelBuilder.Configurations.Add(new Memberships_Mapping());
    		modelBuilder.Configurations.Add(new Menu_Mapping());
    		modelBuilder.Configurations.Add(new MenusInRoles_Mapping());
    		modelBuilder.Configurations.Add(new Profiles_Mapping());
    		modelBuilder.Configurations.Add(new Roles_Mapping());
    		modelBuilder.Configurations.Add(new Users_Mapping());
        }
    	
        public DbSet<Applications> Applications { get; set; }
        public DbSet<Memberships> Memberships { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenusInRoles> MenusInRoles { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<LoginLogs> LoginLogs { get; set; }
        public DbSet<ActionDefinition> ActionDefinition { get; set; }
    }
}

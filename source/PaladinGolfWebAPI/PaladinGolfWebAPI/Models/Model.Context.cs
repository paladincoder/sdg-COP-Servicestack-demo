﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaladinGolfWebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class paladingolfEntities : DbContext
    {
        public paladingolfEntities()
            : base("name=paladingolfEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Attendee> Attendees { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GameEvent> GameEvents { get; set; }
        public virtual DbSet<Hole> Holes { get; set; }
        public virtual DbSet<Player> Players { get; set; }
    }
}

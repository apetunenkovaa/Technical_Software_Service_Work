﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Technical_Software_Service
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HelpdeskEntities : DbContext
    {
        private static HelpdeskEntities _context;
        public HelpdeskEntities()
            : base("name=HelpdeskEntities")
        {
        }

        public static HelpdeskEntities GetContext()
        {
             if (_context == null)
                _context = new HelpdeskEntities();
             return _context;
        }   
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Achievements> Achievements { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<DailyTasks> DailyTasks { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Executors> Executors { get; set; }
        public virtual DbSet<HistoryEntries> HistoryEntries { get; set; }
        public virtual DbSet<ImportanceTypes> ImportanceTypes { get; set; }
        public virtual DbSet<Levels> Levels { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Solutions> Solutions { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TicketDocuments> TicketDocuments { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<TicketStates> TicketStates { get; set; }
        public virtual DbSet<UserAchievements> UserAchievements { get; set; }
        public virtual DbSet<UserDailyTasks> UserDailyTasks { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserStates> UserStates { get; set; }
    }
}

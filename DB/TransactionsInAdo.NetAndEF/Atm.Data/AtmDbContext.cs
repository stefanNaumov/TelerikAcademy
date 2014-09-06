using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Atm.Data.Migrations;
using Atm.Models;

namespace Atm.Data
{
    public class AtmDbContext : DbContext
    {
        public AtmDbContext()
            : base("AtmMachine")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AtmDbContext, Configuration>());
        }

        public DbSet<CardAccount> CardAccounts { get; set; }

        public DbSet<TransactionHistory> TransactionHistories { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Context
{
    public class Context:DbContext

    {
       

        public Context() : base("VOLLEYTEAMEsbjerg")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            var newsConfig = modelbuilder.Entity<DomainModelNews>();
            newsConfig.ToTable("News");

            base.OnModelCreating(modelbuilder);
            var aboutConfig = modelbuilder.Entity<DomainModelAbout>();
            aboutConfig.ToTable("About");

            base.OnModelCreating(modelbuilder);
            var boardConfig = modelbuilder.Entity<DomainModelBoard>();
            boardConfig.ToTable("Board");

            base.OnModelCreating(modelbuilder);
            var contactsConfig = modelbuilder.Entity<DomainModelContacts>();
            contactsConfig.ToTable("Contacts");

            base.OnModelCreating(modelbuilder);
            var sponserConfig = modelbuilder.Entity<DomainModelSponser>();
            sponserConfig.ToTable("Sponser");

            base.OnModelCreating(modelbuilder);
            var turnamentConfig = modelbuilder.Entity<DomainModelTurnament>();
            turnamentConfig.ToTable("Turnament");

            base.OnModelCreating(modelbuilder);
            var teamConfig = modelbuilder.Entity<DomainModelTeam>();
            teamConfig.ToTable("Team");
        }

        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTeam> Team { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTurnament> Turnament { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelAbout> About { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelBoard> Board { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelContacts> Contacts { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelNews> News { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelSponser> Sponser { get; set; }
    }
}

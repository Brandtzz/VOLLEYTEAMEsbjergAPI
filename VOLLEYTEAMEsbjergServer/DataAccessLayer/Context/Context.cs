using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Context
{
    public class Context : DbContext
    {
        public Context() : base("VOLLEYTEAMEsbjerg")
        {
            Database.SetInitializer(new VOLLEYTEAMDbInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            var newsConfig = modelbuilder.Entity<DomainModelNews>();
            newsConfig.Property(domainModelNews => domainModelNews.News).HasColumnType("NVARCHAR").HasMaxLength(2100);
            newsConfig.ToTable("News");

            var aboutConfig = modelbuilder.Entity<DomainModelAbout>();
            aboutConfig.Property(domainModelAbout => domainModelAbout.About).HasColumnType("NVARCHAR").HasMaxLength(2100);
            aboutConfig.ToTable("About");

            var boardConfig = modelbuilder.Entity<DomainModelBoard>();
            boardConfig.Property(domainModelBoard => domainModelBoard.Board).HasColumnType("NVARCHAR").HasMaxLength(2100);
            boardConfig.ToTable("Board");

            var contactsConfig = modelbuilder.Entity<DomainModelContacts>();
            contactsConfig.Property(domainModelContacts => domainModelContacts.Contacts).HasColumnType("NVARCHAR").HasMaxLength(2100);
            contactsConfig.ToTable("Contacts");

            var sponsorConfig = modelbuilder.Entity<DomainModelSponsor>();
            sponsorConfig.Property(domainModelSponsor => domainModelSponsor.Sponsor).HasColumnType("NVARCHAR").HasMaxLength(2100);
            sponsorConfig.ToTable("Sponsor");

            var tournamentConfig = modelbuilder.Entity<DomainModelTournament>();
            tournamentConfig.Property(domainModelTournament => domainModelTournament.Tournament)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(2100);
            tournamentConfig.ToTable("Tournament");

            var teamConfig = modelbuilder.Entity<DomainModelTeam>();
            teamConfig.Property(domainModelTeam => domainModelTeam.Team)
                .HasColumnType("NVARCHAR").HasMaxLength(2100);
            teamConfig.ToTable("Team");

            /* var pictureConfig = modelbuilder.Entity<DomainModelPicture>();
            pictureConfig.Property(domainModelPicture => domainModelPicture.Picture)
                .HasColumnType("varbinary").HasMaxLength(8000).HasColumnType("NVARCHAR").HasMaxLength(200);
            teamConfig.ToTable("Picture");*/
            base.OnModelCreating(modelbuilder);
<<<<<<< HEAD
=======
            var englishConfig = modelbuilder.Entity<DomainModelEnglish>();
            englishConfig.Property(DomainModelEnglish => DomainModelEnglish.English).HasColumnType("NVARCHAR").HasMaxLength(2100);
            englishConfig.ToTable("English");

            //base.OnModelCreating(modelbuilder);
            //var pictureConfig = modelbuilder.Entity<DomainModelPicture>();
            //pictureConfig.Property(domainModelPicture => domainModelPicture.PictureName).HasColumnType("NVARCHAR").HasMaxLength(200).HasColumnType("image").IsRequired();
            //teamConfig.ToTable("Picture");
>>>>>>> 824385cd0c3b87466afba8a2b8951c6f92d38b90

        }

        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTeam> Team { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTournament> Tournament { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelAbout> About { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelBoard> Board { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelContacts> Contacts { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelNews> News { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelSponsor> Sponsor { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelEnglish> English { get; set; }
        //public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelPicture> Picture { get; set; }
    }
}

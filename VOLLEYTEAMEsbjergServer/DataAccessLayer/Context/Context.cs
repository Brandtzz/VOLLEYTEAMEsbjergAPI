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
            newsConfig.Property(domainModelNews => domainModelNews.News)
                .HasColumnType("NVARCHAR").HasMaxLength(2100);
            newsConfig.ToTable("News");

            var aboutConfig = modelbuilder.Entity<DomainModelAbout>();
            aboutConfig.Property(domainModelAbout => domainModelAbout.About)
                .HasColumnType("NVARCHAR").HasMaxLength(2100);
            aboutConfig.ToTable("About");

<<<<<<< HEAD
      
=======
            var boardConfig = modelbuilder.Entity<DomainModelBoard>();
            boardConfig.Property(domainModelBoard => domainModelBoard.Board)
                .HasColumnType("NVARCHAR").HasMaxLength(2100);
            boardConfig.ToTable("Board");

            var contactsConfig = modelbuilder.Entity<DomainModelContacts>();
            contactsConfig.Property(domainModelContacts => domainModelContacts.Contacts)
                .HasColumnType("NVARCHAR").HasMaxLength(2100);
            contactsConfig.ToTable("Contacts");
>>>>>>> b4acc99319debd48c756b6765e14ed2e0a4dd30f

            var sponsorConfig = modelbuilder.Entity<DomainModelSponsor>();
<<<<<<< HEAD
            sponsorConfig.Property(domainModelSponsor => domainModelSponsor.Url).IsOptional();
            sponsorConfig.HasMany(domainModelSponsor => domainModelSponsor.Team).WithMany(domainModelTeam => domainModelTeam.Sponsor)
                .Map(teamSponsor => { teamSponsor.MapLeftKey("SponsorID"); teamSponsor.MapRightKey("TeamID"); teamSponsor.ToTable("TeamSponsor"); });
=======
            sponsorConfig.Property(domainModelSponsor => domainModelSponsor.Sponsor)
                .HasColumnType("NVARCHAR").HasMaxLength(2100);
>>>>>>> b4acc99319debd48c756b6765e14ed2e0a4dd30f
            sponsorConfig.ToTable("Sponsor");

            var tournamentConfig = modelbuilder.Entity<DomainModelTournament>();
            tournamentConfig.Property(domainModelTournament => domainModelTournament.Tournament)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(2100);
            tournamentConfig.ToTable("Tournament");

            var teamConfig = modelbuilder.Entity<DomainModelTeam>();
<<<<<<< HEAD
            teamConfig.HasMany(domainModelTeam => domainModelTeam.Player)
                .WithRequired(domainModelPlayer => domainModelPlayer.Team).HasForeignKey(domainModelPlayer => domainModelPlayer.TeamId);
            teamConfig.ToTable("Team");

            base.OnModelCreating(modelbuilder);
            var contactsConfig = modelbuilder.Entity<DomainModelContacts>();
            contactsConfig.Property(domainModelContacts => domainModelContacts.Phone).IsOptional();
            contactsConfig.HasMany(domainModelContacts => domainModelContacts.Team).WithMany(domainModelTeam => domainModelTeam.Contacts)
                .Map(teamContacts => { teamContacts.MapLeftKey("ContactsId"); teamContacts.MapRightKey("TeamId"); teamContacts.ToTable("TeamContacts"); });
            contactsConfig.HasMany(domainModelContacts => domainModelContacts.Role).WithMany(domainModelPosition => domainModelPosition.Contacts)
                .Map(contactsPosition => { contactsPosition.MapLeftKey("ContactsId"); contactsPosition.MapRightKey("PositionId"); contactsPosition.ToTable("ContactsPosition"); });
            contactsConfig.ToTable("Contacts");

            base.OnModelCreating(modelbuilder);
=======
            teamConfig.Property(domainModelTeam => domainModelTeam.Team)
                .HasColumnType("NVARCHAR").HasMaxLength(2100);
            teamConfig.ToTable("Team");

            var pictureConfig = modelbuilder.Entity<DomainModelPicture>();
            pictureConfig.Property(domainModelPicture => domainModelPicture.Picture)
                .HasColumnType("NVARCHAR")
                .HasColumnType("image").IsRequired();
            pictureConfig.ToTable("Picture");

>>>>>>> b4acc99319debd48c756b6765e14ed2e0a4dd30f
            var englishConfig = modelbuilder.Entity<DomainModelEnglish>();
            englishConfig.Property(domainModelEnglish => domainModelEnglish.English)
                .HasColumnType("NVARCHAR").HasMaxLength(2100);
            englishConfig.ToTable("English");
<<<<<<< HEAD

            base.OnModelCreating(modelbuilder);
            var playerConfig = modelbuilder.Entity<DomainModelPlayer>();
            playerConfig.Property(domainModelPlayer => domainModelPlayer.Phone).IsOptional();
            playerConfig.Property(domainModelPlayer => domainModelPlayer.Email).IsOptional();
            playerConfig.Property(domainModelPlayer => domainModelPlayer.Training).IsOptional();
            playerConfig.Property(domainModelPlayer => domainModelPlayer.Games).IsOptional();
            playerConfig.Property(domainModelPlayer => domainModelPlayer.PlayerOfTheMatch).IsOptional();
            playerConfig.ToTable("Players");

            //base.OnModelCreating(modelbuilder);
            //var pictureConfig = modelbuilder.Entity<DomainModelPicture>();
            //pictureConfig.Property(domainModelPicture => domainModelPicture.PictureName).HasColumnType("NVARCHAR").HasMaxLength(200).HasColumnType("image").IsRequired();
            //teamConfig.ToTable("Picture");

            base.OnModelCreating(modelbuilder);
            var roleConfig = modelbuilder.Entity<DomainModelRole>();
            roleConfig.ToTable("Role");

=======
            base.OnModelCreating(modelbuilder);
>>>>>>> b4acc99319debd48c756b6765e14ed2e0a4dd30f
        }

        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTeam> Team { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTournament> Tournament { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelAbout> About { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelContacts> Contacts { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelNews> News { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelSponsor> Sponsor { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelEnglish> English { get; set; }
<<<<<<< HEAD
        //public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelPicture> Picture { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelPlayer> Player { get; set; }

        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelRole> Role { get; set; }
=======
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelPicture> Picture { get; set; }
>>>>>>> b4acc99319debd48c756b6765e14ed2e0a4dd30f
    }
}

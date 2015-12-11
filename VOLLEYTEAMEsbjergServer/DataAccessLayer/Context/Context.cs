using System;
using System.Collections.Generic;
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
            base.OnModelCreating(modelbuilder);
            var newsConfig = modelbuilder.Entity<DomainModelNews>();
            newsConfig.Property(domainModelNews => domainModelNews.News).HasColumnType("NVARCHAR").HasMaxLength(2100);
            newsConfig.ToTable("News");

            base.OnModelCreating(modelbuilder);
            var aboutConfig = modelbuilder.Entity<DomainModelAbout>();
            aboutConfig.Property(domainModelAbout => domainModelAbout.About).HasColumnType("NVARCHAR").HasMaxLength(2100);
            aboutConfig.ToTable("About");

      

            base.OnModelCreating(modelbuilder);
            var sponsorConfig = modelbuilder.Entity<DomainModelSponsor>();
            sponsorConfig.Property(domainModelSponsor => domainModelSponsor.Url).IsOptional();
            sponsorConfig.HasMany(domainModelSponsor => domainModelSponsor.Team).WithMany(domainModelTeam => domainModelTeam.Sponsor)
                .Map(teamSponsor => { teamSponsor.MapLeftKey("SponsorID"); teamSponsor.MapRightKey("TeamID"); teamSponsor.ToTable("TeamSponsor"); });
            sponsorConfig.ToTable("Sponsor");

            base.OnModelCreating(modelbuilder);
            var tournamentConfig = modelbuilder.Entity<DomainModelTournament>();
            tournamentConfig.Property(domainModelTournament => domainModelTournament.Tournament)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(2100);
            tournamentConfig.ToTable("Tournament");

            base.OnModelCreating(modelbuilder);
            var teamConfig = modelbuilder.Entity<DomainModelTeam>();
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
            var englishConfig = modelbuilder.Entity<DomainModelEnglish>();
            englishConfig.Property(DomainModelEnglish => DomainModelEnglish.English).HasColumnType("NVARCHAR").HasMaxLength(2100);
            englishConfig.ToTable("English");

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

        }

        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTeam> Team { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelTournament> Tournament { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelAbout> About { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelContacts> Contacts { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelNews> News { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelSponsor> Sponsor { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelEnglish> English { get; set; }
        //public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelPicture> Picture { get; set; }
        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelPlayer> Player { get; set; }

        public System.Data.Entity.DbSet<DataAccessLayer.DomainModel.DomainModelRole> Role { get; set; }
    }
}

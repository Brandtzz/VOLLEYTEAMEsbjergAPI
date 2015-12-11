﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;
using DataAccessLayer.Properties;
using System.ComponentModel;
using DataAccessLayer.Helpers;

namespace DataAccessLayer.Context
{
    public class VOLLEYTEAMDbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            var about = new DomainModelAbout
            {
                About = "I dette felt kan du fortælle lidt om klubben, og om volleyball teamet."
            };

            var contacts = new DomainModelContacts
            {
                FirstName = "Judith ",
                LastName = " Pølsemand",
                Email = "volleyteamesbjerg@gmail.com",
                Phone = "34657678",
                PictureId = 1
            };

            var news = new DomainModelNews
            {
<<<<<<< HEAD
                News = "1 div dameholdet - Senior Mixhold stadig ubesejret!"
=======
                News = "Senior Mixhold stadig ubesejret!"
>>>>>>> b4acc99319debd48c756b6765e14ed2e0a4dd30f
            };

            var sponsor = new DomainModelSponsor
            {
                Url = "www.google.dk",
                PictureId = 2,
                Name = "Google"
            };

            var team = new DomainModelTeam
            {
                Name = "1. division",
                Description = "beskrivelse af 1. divsions",
                Intro = "beskrivelse af 1. divsions tøser"
            };

            var tournament = new DomainModelTournament
            {
                Tournament = "Turneringsplan for 1 div:  " +
                             "Turneringsplan for C-rækken senior mixhold:  " +
                             "Turneringsplan for DGI turneringen senior mixhold:  " +
                             "Turneringsplan for Kids/teen volley: "
            };

            var picture = new DomainModelPicture
            {
                PictureName = "VOLLEYTEAM Esbjerg Logo",
                Picture = HelpPictureConverter.CopyImageToByteArray(Resources.logo)
            };

            var english = new DomainModelEnglish
            {
                English = "Welcome to VOLLEYTEAMESBJERG........GOOGLE TRANSLATE FTW!!!!!!!"
            };

<<<<<<< HEAD
            var role = new DomainModelRole
            {
                Role = "Formand"
            };

            var player = new DomainModelPlayer
            {
                FirstName = "Lars",
                LastName = "Frede",
                Address = " Jyllandsgade 55",
                Phone = "",
                TeamId = 0

            };

            //Bitmap bitmapLogo = new Bitmap(Resources.logo);

            //var picture = new DomainModelPicture
            //{
            //    PictureName = "VOLLEYTEAM Esbjerg Logo",
            //    Picture = bitmapLogo
            //};

=======
>>>>>>> b4acc99319debd48c756b6765e14ed2e0a4dd30f
            context.About.Add(about);
            context.Contacts.Add(contacts);
            context.News.Add(news);
            context.Sponsor.Add(sponsor);
            context.Team.Add(team);
            context.Tournament.Add(tournament);
            context.English.Add(english);
<<<<<<< HEAD
            //context.Picture.Add(picture);
            context.Role.Add(role);
            context.Player.Add(player);
=======
            context.Picture.Add(picture);
>>>>>>> b4acc99319debd48c756b6765e14ed2e0a4dd30f
            base.Seed(context);
        }
    }
}

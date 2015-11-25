using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace DataAccessLayer.Context
{
    class VolleyteamDbInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            DomainModelAbout about = new DomainModelAbout
            {
                About = "I dette felt kan du fortælle lidt om klubben, og om volleyball teamet."
            };

            DomainModelBoard board = new DomainModelBoard
            {
                Board = "Bestyrelsen består af: Judith, Kenneth and Per"
            };

            DomainModelContacts contacts = new DomainModelContacts
            {
                Contacts = "Kontakt Judith for nærmere information på 99999999"
            };

            DomainModelNews news = new DomainModelNews
            {
                News = "Splid på 1 div dameholdet - STOP Mobning kampange igangsat - Senior Mixhold stadig ubesejret!"
            };

            DomainModelSponsor sponsor = new DomainModelSponsor
            {
                Sponsor =
                    "Sponsorerne i år er: Skræddergården, Jyske Bank, Skjern Bank, Valse Møllen, Aarsland, Slagter Kaj Madsen"
            };

            DomainModelTeam team = new DomainModelTeam
            {
                Team = "1 division senior damer, C-Række senior mixhold + DGI-rækken senior mixhold, Kids/teen volley"
            };

            DomainModelTournament tournament = new DomainModelTournament
            {
                Tournament = "Turneringsplan for 1 div:  " +
                             "Turneringsplan for C-rækken senior mixhold:  " +
                             "Turneringsplan for DGI turneringen senior mixhold:  " +
                             "Turneringsplan for Kids/teen volley: "
            };

            context.About.Add(about);
            context.Board.Add(board);
            context.Contacts.Add(contacts);
            context.News.Add(news);
            context.Sponsor.Add(sponsor);
            context.Team.Add(team);
            context.Tournament.Add(tournament);
            base.Seed(context);
        }
    }
}

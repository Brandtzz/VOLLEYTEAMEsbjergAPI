using System;
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
                About = "VOLLEYTEAM Esbjerg har eksisteret i 18 sæsoner, klubben er en sammenlægning af BSGI og SGI Volleyball." +
                        "Klubben har ca. 50 medlemmer fordelt på Damehold," +
                "Herrehold,Mix - hold, Ungdomshold og Kidshold," +
                 "det højest rangerende hold er Dameholdet i 1.Division. – Oven i købet det højest rangerende damehold i Esbjerg Kommune." +
                 "Driften af klubben glider stille og roligt af sted med flere yderst kompetente og meget erfarne ledere i spidsen." +
                "Disse personer vil fortsat arbejde med at forbedre klubbens organisation og struktur således," +
               "at klubben også her er gearet til at følge med den sportslige udvikling." +
               "I takt med denne udvikling vil klubben også arbejde meget på at gøre medieeksponeringen af såvel klubben som vores sponsorer endnu bedre."
            };

            var contacts = new DomainModelContacts
            {
                FirstName = "Judith ",
                LastName = " Parus",
                Email = "volleyteamesbjerg@gmail.com",
                Phone = "34657678",

            };

            var news = new DomainModelNews
            {

                News = "1. Division:" +
                " Alt om 1.Division Damer..." +
" Vi spiller i den landsdækkende 1.Division og sæsonen er i fuld gang.du  kan se resultater, stillingen og holdinformationer samt følg kampene via livescore " +
" har du divisionerfaring, eller er du et ungt talent med lyst til af prøve dig på 1.Division niveau, er du velkommen til at kontakte holdets træner Per Vind Petersen på 40 52 82 57 eller vindper@gmail.com" +
" Senior Mix Hold:" +
" I år kan vi byde holdets nye træner velkommen: Micheal Tobiasen" +
" Så er vores første kampe på senior holdet overstået, vi havde 2 meget tætte kampe, den første kamp måtte vi desværre give til det andet hold, men den anden tog vi i 3 set." +
" Alle som har lyst til at afprøve Volleyball som er 18 + er altid velkommende på dette hold." +
" for mere information kontakt Kenneth Fallesen Jørgensen på kenneth_fallesen@hotmail.com" +
" Kids / Teen:" +
" Nyhed: kidsvolley for børn i 1. - 3.klasse." +
" Vi har i år oprettet et hold for børn(drenge og piger) som har lyst til at spille volleyball for børn.Det er sjovt og udfordrende og spilles med enkle regler.Vi spiller med kaste - gribe bevægelser, serv m.m." +
" Alle kan være med." +
" Vi træner på Ådalsskolen tirsdage fra kl. 18.00 - 19. 15."
            };

            var sponsor = new DomainModelSponsor
            {
                Url = "www.google.dk",

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
                English = "In Volleyteam Esbjerg we got a ladies team," +
                " for those who has some experience, a senior team (mens,ladies and mixed) and a kids/youth team." +
                "In Volleyteam Esbjerg everyone is welcome." +
                "The teams train Tuesday or Thursday and the ladies team train both days." +
                "Please contact us for further information either on volleyteamesbjerg@gmail.com or phone the chairman Judith Parus," +
                " 2966 5557 - she is fluent in English."

            };

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


            context.About.Add(about);
            context.Contacts.Add(contacts);
            context.News.Add(news);
            context.Sponsor.Add(sponsor);
            context.Team.Add(team);
            context.Tournament.Add(tournament);
            context.English.Add(english);
            context.Role.Add(role);
            context.Player.Add(player);
            context.Picture.Add(picture);
            base.Seed(context);
        }
    }
}

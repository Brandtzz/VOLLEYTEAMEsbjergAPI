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
                LastName = "Parus",
                Email = "volleyteamesbjerg@gmail.com",
                Phone = "34657678"

            };
            var contacts1 = new DomainModelContacts
            {
               
                FirstName = "Per ",
                LastName = "Vind",
                Email = "volleyteamesbjerg@gmail.com",
                Phone = "34657678"

            };
            var contacts2 = new DomainModelContacts
            {
              
                FirstName = "Kenneth Fallesen ",
                LastName = "Jørgensen",
                Email = "volleyteamesbjerg@gmail.com",
                Phone = "34657678"

            };
            var contacts3 = new DomainModelContacts
            {
              
                FirstName = "Tina ",
                LastName = "Tobiasen",
                Email = "volleyteamesbjerg@gmail.com",
                Phone = "34657678"

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
                Url = "www.jyskebank.dk/",

                Name = "JyskeBank"
            };
            var sponsor1 = new DomainModelSponsor
            {
               
                Url = "www.skjernbank.dk/",

                Name = "SkjernBank"
            };
            var sponsor2 = new DomainModelSponsor
            {
                
                Url = "www.valsemollen.dk/",

                Name = "Valsemøllen"
            };
            var sponsor3 = new DomainModelSponsor
            {
               
                Url = "www.aarsland.dk/",

                Name = "Aarsland"
            };

            var team = new DomainModelTeam
            {
               
                Name = "1. division",
                Description = "1. Division Damer består af spillere, der lægger vægt på engagement og seriøsitet omkring træning og kampe. Holdet har en fin blanding af spillere med divisionserfarng samt unge talenter.-"+
                "Evt.spørgsmål angående deltagelse på holdet skal rettes til Træner Per Vind Petersen på 40 52 82 57 eller vindper@gmail.com" +
                "Træningstider for sæsonen 2015 / 2016:" +
                "Tirsdage kl. 19.30 - 21.30 og torsdage kl. 18.00 - 20.",
                Intro = "beskrivelse af 1. divsions Damer"
            };
            var team1 = new DomainModelTeam
            {
               
                Name = "Senior-Mix",
                Description = "VOLLEYTEAM Esbjergs Senior-hold omfatter herre, dame samt mix/motion, og er for alle med interesse for volleyball. Vi spiller motionsvolley med glæde og gejst i en hyggelig og sjov atmosfære."+
                "Vi har plads til alle uanset niveau og erfaring."+
                "VOLLEYTEAM Esbjerg byder alle velkommen,"+
                "høj som lav," +
                "ung som gammel - Bare du er *voksen*  og glad for at spille volley, så kom og vær med!"+
                "Vi spiller med i DGI´s turnering samt andre, hvis holdet ønsker det."+
                "Holdet byder Micheal Tobiasen velkommen som træner."+  
                "Træningstider for sæsonen 2015 - 2016: Torsdag kl. 20.00 - 22.00"+
                "ved Yderlige spørgsmål kontakt Kenneth fallesen Jørgensen på:"+
                "kenneth_fallesen@hotmail.com",
                Intro = "beskrivelse af Senior-Mix"
            };
            var team2 = new DomainModelTeam
            {
               
                Name = "Kids/Teen",
                Description = "Vi har kids: level 2 for 1. – 3.klasse Level 3 og 4 for 4." +
                              " – 6.klasse Dame ungdom – årgang 1999 - 2002 Kom og stift bekendtskab med et sjovt og energisk spil," +
                              " som er tilpasset børn og unges motoriske evner.Spillet udvikler sig fra kastebevægelser" +
                              " over mere og mere rene volleyball - slag. Vi deltager i forskellige stævner fordelt henover sæsonen" +
                              ", som strækker sig frem til ca. 1.4. Holdene trænes af erfarne og voksne spillere," +
                              " der har stor erfaring med kids - og ungdomstræning." +
                              " Spillet er fleksibelt og der er altid plads til interesserede spillere også udenfor" +
                              " de nævnte aldersklasser. Træningstider for sæsonen 2015 - 2016: Tirsdag kl. 18.00 - 19.30," +
                              " Ved yderlige spørgsmål kontatk Judith parus på: Tlf: 29 66 55 57",
                Intro = "beskrivelse af Kids/Teen"
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
            var role1 = new DomainModelRole
            {
               
                Role = "Kassere"
            };
            var role2 = new DomainModelRole
            {
               
                Role = "Bestyrelse Medlem"
            };
            var role3 = new DomainModelRole
            {
              
                Role = "Træner"
            };

            var player = new DomainModelPlayer
            {
               
                FirstName = "Lars",
                LastName = "Bilde",
                Address = "Matrosvænget 1",
                Phone = "",
                Team =team, 

            };
            var player1 = new DomainModelPlayer
            {
               
                FirstName = "Frederik",
                LastName = "Sørensen",
                Address = "Jyllandsgade 55",
                Phone = "",
                Team=team1

            };
            var player2 = new DomainModelPlayer
            {
               
                FirstName = "Rune",
                LastName = "Brandt",
                Address = "ved Skoven 12",
                Phone = "",
                Team =team2

            };
            var player3 = new DomainModelPlayer
            {
                Id = 4,
                FirstName = "Kenneth Fallesen",
                LastName = "Jørgensen",
                Address = "Stormgade 23 3 th",
                Phone = "",
                Team = team2

            };

            sponsor.Picture = picture;

            context.About.Add(about);
            context.Contacts.Add(contacts);
           
            context.News.Add(news);
            context.Sponsor.Add(sponsor);
           
            context.Team.Add(team);
            context.Team.Add(team1);
            context.Team.Add(team2);
            context.Tournament.Add(tournament);
            context.English.Add(english);
            context.Role.Add(role);
          
            context.Player.Add(player);
         
            context.Picture.Add(picture);
            base.Seed(context);
        }
    }
}

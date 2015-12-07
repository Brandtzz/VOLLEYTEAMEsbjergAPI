using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace DataAccessLayer
{
    public class Facade
    {
        private AboutRepository aboutRepository;
        private BoardRepository boardRepository;
        private ContactsRepository contactsRepository;
        private NewsRepository newsRepository;
        private SponserRepository sponsorRepository;
        private TeamRepository teamRepository;
        private TournamentRepository tournamentRepository;
        private EnglishRepository englishRepository; 


        public AboutRepository GetAboutRepository()
        {
            if (aboutRepository == null)
            {
                aboutRepository = new AboutRepository();
            }
            return aboutRepository;
        }

        public BoardRepository GetBoardRepository()
        {
            if (boardRepository == null)
            {
                boardRepository = new BoardRepository();
            }
            return boardRepository;
        }

        public ContactsRepository GetContactRepository()
        {
            if (contactsRepository == null)
            {
                contactsRepository = new ContactsRepository();
            }
            return contactsRepository;
        }

        public NewsRepository GetNewsRepository()
        {
            if(newsRepository == null)
            {
                newsRepository = new NewsRepository();
            }
            return newsRepository;
        }

        public SponserRepository GetSponsorRepository()
        {
            if(sponsorRepository == null)
            {
                sponsorRepository = new SponserRepository();
            }
            return sponsorRepository;
        }

        public TeamRepository GetTeamRepository()
        {
            if(teamRepository == null)
            {
                teamRepository = new TeamRepository();
            }
            return teamRepository;
        }

        public TournamentRepository GetTournamentRepository()
        {
            if(tournamentRepository == null)
            {
                tournamentRepository = new TournamentRepository();
            }
            return tournamentRepository;
        }

        public EnglishRepository GetEnglishRepository()
        {
            if (englishRepository == null)
            {
                englishRepository = new EnglishRepository();
            }
            return englishRepository; 
           
        }
    }
}

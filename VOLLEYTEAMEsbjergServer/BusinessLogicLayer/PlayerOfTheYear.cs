using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DomainModel;

namespace BusinessLogicLayer
{
    public class PlayerOfTheYear
    {
        public DomainModelPlayer PlayerOfTheYearCalculator(List<DomainModelPlayer> playerList)
        {
            DomainModelPlayer playerOfTheYear = null;
            int playerOfTheYearScore = Int32.MinValue;

            foreach (var player in playerList)
            {
                int currentScore = player.Games + player.Training + player.PlayerOfTheMatch;
                if (currentScore > playerOfTheYearScore)
                {
                    playerOfTheYearScore = currentScore;
                    playerOfTheYear = player;
                }
            }

            return playerOfTheYear;
        }
    }
}

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
                else if (currentScore == playerOfTheYearScore)
                {
                    if (playerOfTheYear.PlayerOfTheMatch < player.PlayerOfTheMatch)
                    {
                        playerOfTheYear = player;
                    }
                    else if (playerOfTheYear.PlayerOfTheMatch == player.PlayerOfTheMatch)
                    {
                        if (playerOfTheYear.Training < player.Training)
                        {
                            playerOfTheYear = player;
                        }
                        else if (playerOfTheYear.Training == player.Training)
                        {
                           
                            if (GetRandomNumber() == 1)
                            {
                                playerOfTheYear = player;
                            }
                        }

                    }

                }
            }

            return playerOfTheYear;
        }

        public virtual int GetRandomNumber()
        {
            return new Random().Next(0, 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BusinessLogicLayer;
using DataAccessLayer;
using DataAccessLayer.DomainModel;

namespace BuisnessLogicLayer_Test
{
    [TestFixture]
    class PlayerOfTheYear_Test
    {

        [Test]
        public void CheckPlayerOfTheYearOneWinner()
        {
            PlayerOfTheYear playerOfTheYear = new PlayerOfTheYear();
            List<DomainModelPlayer> players = new List<DomainModelPlayer>();
            DomainModelPlayer player1 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Rune",
                LastName = "Brandt",
                Phone = "12345678",
                Games = 2,
                PlayerOfTheMatch = 2,
                Training = 5,
                TeamId = 1
            };
            DomainModelPlayer player2 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Kenneth",
                LastName = "Fallesen",
                Phone = "12345678",
                Games = 7,
                PlayerOfTheMatch = 2,
                Training = 1,
                TeamId = 1
            };
            DomainModelPlayer player3 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Frederik",
                LastName = "Sørensen",
                Phone = "12345678",
                Games = 1,
                PlayerOfTheMatch = 0,
                Training = 5,
                TeamId = 1
                
            };
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            var winner = playerOfTheYear.PlayerOfTheYearCalculator(players);
            Assert.AreEqual(player2,winner);



         
        }
        [Test]
        public void CheckPlayerOfTheYearMoreWinners()
        {
            PlayerOfTheYear playerOfTheYear = new PlayerOfTheYear();
            List<DomainModelPlayer> players = new List<DomainModelPlayer>();
            DomainModelPlayer player1 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Rune",
                LastName = "Brandt",
                Phone = "12345678",
                Games = 2,
                PlayerOfTheMatch = 3,
                Training = 5,
                TeamId = 1
            };
            DomainModelPlayer player2 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Kenneth",
                LastName = "Fallesen",
                Phone = "12345678",
                Games = 8,
                PlayerOfTheMatch = 2,
                Training = 1,
                TeamId = 1
            };
            DomainModelPlayer player3 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Frederik",
                LastName = "Sørensen",
                Phone = "12345678",
                Games = 1,
                PlayerOfTheMatch = 5,
                Training = 5,
                TeamId = 1

            };
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            var winner = playerOfTheYear.PlayerOfTheYearCalculator(players);
            Assert.AreEqual(player3, winner);
        }
        [Test]
        public void CheckPlayerOfTheYearMoreWinnersSameAmountOfPlayerOfTheMatch()
        {
            PlayerOfTheYear playerOfTheYear = new PlayerOfTheYear();
            List<DomainModelPlayer> players = new List<DomainModelPlayer>();
            DomainModelPlayer player1 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Rune",
                LastName = "Brandt",
                Phone = "12345678",
                Games = 2,
                PlayerOfTheMatch = 5,
                Training = 8,
                TeamId = 1
            };
            DomainModelPlayer player2 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Kenneth",
                LastName = "Fallesen",
                Phone = "12345678",
                Games = 1,
                PlayerOfTheMatch = 5,
                Training = 9,
                TeamId = 1
            };
            DomainModelPlayer player3 = new DomainModelPlayer()
            {
                Id = 1,
                Address = "stedet",
                Email = "hest@hest.dk",
                FirstName = "Frederik",
                LastName = "Sørensen",
                Phone = "12345678",
                Games = 5,
                PlayerOfTheMatch = 5,
                Training = 5,
                TeamId = 1

            };
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            var winner = playerOfTheYear.PlayerOfTheYearCalculator(players);
            Assert.AreEqual(player2, winner);
        }
    }
}


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProjectFDM;
using System.Collections.Generic;
using Moq;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetOneTenReturnsAnIntFromBetweenOneAndTen()
        {
            //Arrange
            DecathonGame decgame = new DecathonGame();

            //Act
            int thenumber = decgame.GetOneTen();

            //Assert
            Assert.IsTrue(thenumber > 0 && thenumber <= 10);
        }

        [TestMethod]
        public void TestMethodLotteryReturnsAListOfLengthSix()
        {
            //Arrange
            DecathonGame decgame = new DecathonGame();

            //Act
            List<int> thenumbers = decgame.Lottery();

            //Assert
            Assert.IsTrue(thenumbers.Count == 6);
        }

        [TestMethod]
        public void TestMethodUserLotteryReturnsAListOfLengthSix()
        {
            //Arrange
            DecathonGame decgame = new DecathonGame();

            //Act
            List<int> thenumbers = decgame.Userlottery(1, 2, 3, 4, 5, 6);

            //Assert
            Assert.IsTrue(thenumbers.Count == 6);
        }

        [TestMethod]
        public void TestMethodLotteryresultReturnsAListOfLengthSix()
        {
            //Arrange
            DecathonGame decgame = new DecathonGame();
            //<Mock>

            ////Act
            //List<int> thenumbers = decgame.Userlottery(1, 2, 3, 4, 5, 6);

            ////Assert
            //Assert.IsTrue(thenumbers.Count == 6);

            //mock the lists within the lottery method
        }

    }
}

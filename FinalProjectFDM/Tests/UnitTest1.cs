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
        public void TestMethod()
        {
            //Arrange
            //test initialize instance of decathongame
            DecathonGame decgame = new DecathonGame();

            //Act
            //int thenumber = decgame.GetOneTen();

            //Assert
            //would need to mock the value of getoneten to see this

        }
        //dec win won't add if getoneresultisodd
        //decwin will add to context when result is even
        //decwin will add value from context to another in context

        //lottery returns a unique list
        //lottery returns a sorted list

            //userlottery returns a sorted list

            //lotteryresult returns true for matching lists and false otherwise
            //will need to mock set up these lists

            //matcher checks the occurence of a value in a list
            //that matcher's matchcount is the same as the above occurence

            //lottowin adds or calls on context when matchcount is greater than or equal to four
            //lotto win adds a quarter of payout to account for match of 4
            //lottowin adds a third of payout to account for match of 5
            //lottowin adds full payout to account for match of 6

            //luckynumber adds the same random number thrice to a list
            //luckynumber adds unique numbers to list
            //luckynumbers returns a list of length 9

            //luckynwin adds payout to account if user number occurs 3 or more times

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
        
        //----------------Joe's tests:
        [TestMethod]
        public void Test_Bet_ReturnsNotNull_WhenCalled()
        {
            //Arrange
            BetClass BetObj = new BetClass();
            //Act
            string result = BetObj.Bet(0.5, 5);
            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Test_Bet_ReturnsInvalidInputMessage_IfNumberBidIsOutOfRange0And100()
        {
            //Arrange
            BetClass BetObj = new BetClass();
            string expected = "invalid input";
            //Act
            string result1 = BetObj.Bet(101, 5);
            string result2 = BetObj.Bet(-1, 5);
            //Assert
            Assert.AreEqual(expected, result1);
            Assert.AreEqual(expected, result2);

        }
        //---------------
        
    }
}

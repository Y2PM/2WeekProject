﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProjectFDM;

namespace FinalProjectTests
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
            
        }
    }
}

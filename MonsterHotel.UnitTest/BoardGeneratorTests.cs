﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterHotel.Generation;
using MonsterHotel.Gameplay;
using FluentAssertions;

namespace MonsterHotel.UnitTest
{
    [TestClass]
    public class BoardGeneratorTests
    {
        [TestMethod]
        public void CanGenerateBoard()
        {
            var randomNumberGenerator = new SweepingRandomNumberGenerator();
            var boardGenerator = new BoardGenerator(randomNumberGenerator);

            int passes = 0;
            while (randomNumberGenerator.Next())
            {
                var board = boardGenerator.GenerateBoard();
                ++passes;
            }

            passes.Should().Be(5);
        }
    }
}

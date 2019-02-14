using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.GameEngine
{
    [TestFixture]
    public class HelperEngineUnitTests
    {
        [Test]
        public void RollDice_Roll_1_Dice_10_Should_Pass()
        {
            // Arrange
            var Roll = 1;
            var Dice = 10;

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert
            Assert.NotZero(Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void RollDice_Roll_2_Dice_10_Should_Pass()
        {
            // Arrange
            var Roll = 2;
            var Dice = 10;

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert
            Assert.NotZero(Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void RollDice_Roll_0_Dice_10_Should_Pass()
        {
            // Arrange
            var Roll = 0;
            var Dice = 10;
            var ExpectedValue = 0; //Defensive check should return 0 meaning fail

            // Act
            var Actual = Crawl.GameEngine.HelperEngine.RollDice(Roll, Dice);

            // Assert
            Assert.AreEqual(ExpectedValue, Actual, TestContext.CurrentContext.Test.Name);
        }
    }
}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crawl.Models;

namespace UnitTests.Models
{
    [TestFixture]
    public class CharacterUnitTests
    {
        [Test]
        public void Character_ScaleLevel_1_Should_Pass()
        {
            // Arrange
            var Test = new Character();
            int Level = 1;
            bool Expected = true;

            // Act
            var Actual = Test.ScaleLevel(Level);

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_0_Should_Fail()
        {
            // Arrange
            var Test = new Character();
            int Level = 0;
            bool Expected = false;

            // Act
            var Actual = Test.ScaleLevel(Level);

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_Neg1_Should_Fail()
        {
            // Arrange
            var Test = new Character();
            int Level = -1;
            bool Expected = false;

            // Act
            var Actual = Test.ScaleLevel(Level);

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_GreaterThanMax_21_Should_Fail()
        {
            // Arrange
            var Test = new Character();
            int Level = 21;
            bool Expected = false;

            // Act
            var Actual = Test.ScaleLevel(Level);

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_LessThanCurrent_Should_Fail()
        {
            // Arrange
            var Test = new Character();
            int Level = 2;
            bool Expected = false;
            
            Test.ScaleLevel(Level); //set character level higher than 1

            // Act
            var Actual = Test.ScaleLevel(Level-1);

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_SameLevel_Should_Fail()
        {
            // Arrange
            var Test = new Character();
            int Level = 2;
            bool Expected = false;

            Test.ScaleLevel(Level); //set character level 2

            // Act
            var Actual = Test.ScaleLevel(Level);

            // Assert
            Assert.AreEqual(Expected, Actual, TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_Level_1_Forced_5_ShouldReturnMaxHealth_5()
        {
            // Arrange
            var Test = new Character();
            int Level = 1;
            int Expected = 5;  // Expected value

            // Turn on Forced Values
            GameGlobals.SetForcedRandomNumbers(5);

            // Act
            var Actual = Test.ScaleLevel(Level);

            // Reset
            GameGlobals.DisableRandomValues();

            // Assert
            Assert.AreEqual(Expected, Test.GetHealthMax(), TestContext.CurrentContext.Test.Name);
        }

        [Test]
        public void Character_ScaleLevel_Level_2_Forced_7_ShouldReturnMaxHealth_14()
        {
            // Arrange
            var Test = new Character();
            int Level = 2;
            int Expected = 14;  // Expected MaxHealth

            // Turn on Forced Values
            GameGlobals.SetForcedRandomNumbers(7);

            // Act
            var Actual = Test.ScaleLevel(Level);

            // Reset
            GameGlobals.DisableRandomValues();

            // Assert
            Assert.AreEqual(Expected, Test.GetHealthMax(), TestContext.CurrentContext.Test.Name);
        }
    }
}

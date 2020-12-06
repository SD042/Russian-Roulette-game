using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Russian_Roulette_game;
using Russian_Roulette_game.Properties;

namespace Russian_Roulette_gameUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Game_logic unitTesting_obj = new Game_logic();
        [TestMethod]
        
        public void Shoot_Test()
        {
            unitTesting_obj.load_position = 1;
            unitTesting_obj.spin_position = 1;
            int testResult = unitTesting_obj.Shoot_method();
            Assert.AreEqual(1, testResult);
        }
        [TestMethod]
        public void Shoot_Test_Neg()
        {

            unitTesting_obj.load_position = 1;
            unitTesting_obj.spin_position = 5;
            int testResult = unitTesting_obj.Shoot_method();
            Assert.AreNotEqual(1, testResult);
        }
    }
}

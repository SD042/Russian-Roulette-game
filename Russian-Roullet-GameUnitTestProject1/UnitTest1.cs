using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Russian_Roullet_GameUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Game_logic unitTesting_obj = new Game_logic();

        [TestMethod]
        public void Shoot_Test()
        {
            unitTesting_obj.load_Position = 1;
            unitTesting_obj.spin_Position = 1;
            int testResult = unitTesting_obj.shoot_method();
            Assert.AreEqual(1, testResult);
        }
        [TestMethod]
        public void Shoot_Test_Neg()
        {
            unitTesting_obj.load_position = 1;
            unitTesting_obj.spin_position = 5;
            int testResult = unitTesting_obj.shoot_method();
            Assert.AreNotEqual(1, testResult);
        }
    }
}


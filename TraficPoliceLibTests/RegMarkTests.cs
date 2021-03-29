using Microsoft.VisualStudio.TestTools.UnitTesting;
using TraficPoliceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraficPoliceLib.Tests
{
    [TestClass()]
    public class RegMarkTests
    {
        [TestMethod()]
        public void CheckMark_CorrectRegMark_ReturnsTrue()
        {
            //Arrange
            string vin = "A000AA46";
            bool expected = true;
            //Act
            bool actual = RegMark.CheckMark(vin);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckMark_LessThen8Chars_ReturnsFalse()
        {
            //Arrange
            string vin = "A000AA4";
            bool expected = false;
            //Act
            bool actual = RegMark.CheckMark(vin);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetMarkInfo_CorrectRegMark_ReturnsTrue()
        {
            //Arrange
            string vin = "A000AA46";
            bool expected = true;
            //Act
            string result = RegMark.GetMarkInfo(vin);
            bool actual = !result.Contains("Ошибка!");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
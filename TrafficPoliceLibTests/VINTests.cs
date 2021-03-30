using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficPoliceLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficPoliceLib.Tests
{
    [TestClass()]
    public class VINTests
    {
        [TestMethod()]
        public void CheckVIN_CorrectVIN_ReturnsTrue()
        {
            //Arrange
            string vin = "KJASHDJK3SKDH1234";
            bool expected = true;
            //Act
            bool actual = VIN.CheckVIN(vin);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CheckVIN_LessThen17Chars_ReturnsFalse()
        {
            //Arrange
            string vin = "KJASHDJK3SKDH123";
            bool expected = false;
            //Act
            bool actual = VIN.CheckVIN(vin);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetVINInfo_CorrectVIN_ReturnsTrue()
        {
            //Arrange
            string vin = "KJASHDJK3SKDH1234";
            bool expected =true;
            //Act
            string result = VIN.GetVINInfo(vin);
            bool actual = !result.Contains("Ошибка!");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
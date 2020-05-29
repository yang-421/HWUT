using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_GetSet_ID_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Id = "zero";

            // Assert
            Assert.AreEqual(result.Id, "zero");
        }

        [TestMethod]
        public void ProductModel_GetSet_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Maker = "Sen Yang";

            // Assert
            Assert.AreEqual(result.Maker, "Sen Yang");
        }

        [TestMethod]
        public void ProductModel_GetSet_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Image = "earphone1.png";

            // Assert
            Assert.AreEqual(result.Image, "earphone1.png");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
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

        [TestMethod]
        public void ProductModel_GetSet_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Url = "https://www.microsoft.com/en-us/";

            // Assert
            Assert.AreEqual(result.Url, "https://www.microsoft.com/en-us/");
        }

        [TestMethod]
        public void ProductModel_GetSet_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Title = "software";

            // Assert
            Assert.AreEqual(result.Title, "software");
        }

        [TestMethod]
        public void ProductModel_GetSet_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Description = "hello";

            // Assert
            Assert.AreEqual(result.Description, "hello");
        }

        [TestMethod]
        public void ProductModel_GetSet_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Sequence = "first";

            // Assert
            Assert.AreEqual(result.Sequence, "first");
        }

        [TestMethod]
        public void ProductModel_GetSet_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Email = "Unknown";

            // Assert
            Assert.AreEqual(result.Email, "Unknown");
        }

        [TestMethod]
        public void ProductModel_GetSet_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();
            result.Logistics = "";

            // Assert
            Assert.AreEqual(result.Logistics, "");
        }

        [TestMethod]
        public void ProductModel_GetSet_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();


            // Assert
            Assert.AreEqual(result.Ratings.Length, 1);
            Assert.AreEqual(result.Ratings[0], 5);
        }

        [TestMethod]
        public void ProductModel_GetSet_ToString_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(result.ToString(), JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void ProductModel_GetSet_AverageRating1_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert Initialize rating is 5
            Assert.AreEqual(result.AverageRating(), 5);
        }
            [TestMethod]
            public void ProductModel_GetSet_AverageRating2_Default_Should_Pass()
            {
                // Act
                var result = new ProductModel();
                result.Ratings = null;

                // Assert
                Assert.AreEqual(result.AverageRating(), 0);
            }

            [TestMethod]
            public void ProductModel_GetSet_AverageRating3_Default_Should_Pass()
            {
                // Act
                var result = new ProductModel();
                result.Ratings = new int[] { };

                // Assert
                Assert.AreEqual(result.AverageRating(), 0);
            }

            [TestMethod]
            public void ProductModel_GetSet_AverageRating4_Default_Should_Pass()
            {   // Act
                var result = new ProductModel();
                result.Ratings = new int[] { 0, 0 };

                // Assert
                Assert.AreEqual(result.AverageRating(), 0);
            }

            [TestMethod]
            public void ProductModel_GetSet_AverageRating5_Default_Should_Pass()
            {// Act
                var result = new ProductModel();
                result.Ratings = new int[] { 5, 5 };

                // Assert
                Assert.AreEqual(result.AverageRating(), 5);
            }
        }
    }

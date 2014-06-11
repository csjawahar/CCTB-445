using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindSystem.BLL; // for access to my system
using NorthwindSystem.Entities; //for EF entities
using Xunit; //core for testing
using Xunit.Extensions; // for theories, auto rollback etc

namespace NorthwindSystem.Requirements.UnitTests.CRUD
{
    public class CRUD_Product
    {

        [Fact] //this is a test
        [AutoRollback] // undo db changes after test
        public void Should_Add_Product()
        {
            //Arrange
            var sut = new NorthwindManager();
            var expected = new Product()
            {
                ProductName = "Product number one",
                UnitsInStock = 20, 
                UnitPrice = 14
            };

            //Act
            var actualId = sut.AddProduct(expected);

            //Assert
            Assert.True(actualId > 0);

            var actual = sut.GetProduct(actualId);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(actualId, actual.ProductID);
        }

        #region Properties for test data
        //backing field
        private static IEnumerable<object[]> _CurrentProducts = null;

        public static IEnumerable<object[]> CurrentProducts
        {
            get
            {
                if (_CurrentProducts == null) //Lazy loading
                {
                    var controller = new NorthwindManager();
                    var temp = new List<object[]>(); //empty list
                    foreach (Product elem in controller.ListProducts())
                    {
                        temp.Add(new object[] { elem });
                    }

                    _CurrentProducts = temp;
                }

                return _CurrentProducts;
            }
        }

        [Theory] //test with potentially external data
        [PropertyData("CurrentProducts")]
        [AutoRollback]
        public void Should_Update_Product(Product existing)
        {
            //arrange
            existing.UnitPrice = 25;
            var sut = new NorthwindManager();

            //act
            sut.UpdateProduct(existing);

            //assert
            var actual = sut.GetProduct(existing.ProductID);
            Assert.NotNull(actual);
            Assert.Equal(existing.ProductID, actual.ProductID);

        }


        [Fact]
        [AutoRollback]
        public void Should_Deklete_Product()
        {
            //Arrange
            var sut = new NorthwindManager();
            var expected = new Product()
            {
                ProductName = "Product name modified",
                UnitsInStock = 70
            };
            expected.ProductID = sut.AddProduct(expected);
            //Act
            sut.DeleteProduct(expected);

            //Assert
            var actual = sut.GetShipper(expected.ProductID);
            Assert.Null(actual);
        }

        #endregion

    }
}

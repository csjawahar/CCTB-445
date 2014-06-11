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
    public class CRUD_Shipper
    {
        [Fact] //indicates that this is a test
        public void Should_add_NUmbers()
        {
            //Arrange
            int first = 5, second = 7;

            //Act
            int actual = first + second;
            //Assert
            Assert.Equal(12, actual);
        }

        [Fact] //this is a test
        [AutoRollback] // undo db changes after test
        public void Should_Add_Shipper()
        { 
            //Arrange
            var sut = new NorthwindManager();
            var expected = new Shipper()
            {
                CompanyName = "Montgomery Scott's Transporter Service",
                Phone = "780.555.1212"
            };

            //Act
            var actualId = sut.AddShipper(expected);

            //Assert
            Assert.True(actualId > 0);

            var actual = sut.GetShipper(actualId);
            Assert.Equal(expected.CompanyName, actual.CompanyName);
            Assert.Equal(expected.Phone, actual.Phone);
            Assert.Equal(actualId, actual.ShipperID);

        }

        #region Properties for test data
        //backing field
        private static  IEnumerable<object[]> _CurrentShippers = null;

        public static IEnumerable<object[]> CurrentShippers
        {
            get
            {
                if (_CurrentShippers == null) //Lazy loading
                {
                    var controller = new NorthwindManager();
                    var temp = new List<object[]>(); //empty list
                    foreach (Shipper company in controller.ListShippers())
                    {
                        temp.Add(new object[] {company});
                    }
                    
                    _CurrentShippers = temp;
                }

                return _CurrentShippers;
            }
        }

        [Theory] //test with potentially external data
        [PropertyData("CurrentShippers")]
        [AutoRollback]
        public void Should_Update_Shipper(Shipper existing)
        {
            //arrange
            existing.Phone = "780.999.9999";
            var sut = new NorthwindManager();

            //act
            sut.UpdateShipper(existing);

            //assert
            var actual = sut.GetShipper(existing.ShipperID);
            Assert.NotNull(actual);
            Assert.Equal(existing.Phone, actual.Phone);
            
        }


        [Fact]
        [AutoRollback]
        public void Should_Deklete_Shipper()
        {
            //Arrange
            var sut = new NorthwindManager();
            var expected = new Shipper()
            {
                CompanyName = "Montgomery Scott's Transporter Service",
                Phone = "780.555.1212"
            };
            expected.ShipperID = sut.AddShipper(expected);
            //Act
            sut.DeleteShipper(expected);

            //Assert
            var actual = sut.GetShipper(expected.ShipperID);
            Assert.Null(actual);
        }

        #endregion

    }
}

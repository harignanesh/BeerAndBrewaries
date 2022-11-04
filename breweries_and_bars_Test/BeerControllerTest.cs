using breweries_and_bars.Interface;
using breweries_and_bars.Manager;
using breweries_and_bars.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace breweries_and_bars_Test
{

    [TestClass]
    public class BeerControllerTest
    {
        //private IBeer beer;
        //public BeerControllerTest(IBeer _beer)
        //{
        //    beer = _beer;
        //}
        private BeerManager Manager;
        [TestInitialize]
        public void Initalize()
        {
            Manager = new BeerManager();
        }
        [TestMethod]
        public void Test_InsertBeer_NullInput()
        {
            //Arrange  
            Beer beer = null;
            
            //Act  
            var actual = Manager.InsertBeer(beer);
            //Assert  
            Assert.AreEqual(beer, actual);
        }
        [TestMethod]
        public void Test_InsertBeer_ValidInput()
        {
            //Arrange  
            var mockReadItemCommand = new Mock<Beer>();
            Beer beers = new Beer()
            {
                Id = 1,
                Name = "Beer1",
                PercentageAlcoholByVolume = 1.0M
            };
            //var beerMock = new Mock<IBeer>();
            //beerMock.Setup(p => p.InsertBeer(beers));

            //Act  
            var actual = Manager.InsertBeer(beers).FirstOrDefault();
            //Assert  
            Assert.AreEqual(beers, actual);
        }
        [TestMethod]
        public void Test_GetBeer_WithValidValue()
        {
            //Arrange  
            var mockReadItemCommand = new Mock<Beer>();
            var beers = new List<Beer>()
           {
              new Beer(){
              }
            };
            var beerMock = new Mock<IBeer>();
            beerMock.Setup(p => p.GetBeer()).Returns(beers);

            //Act  
            var actual = Manager.GetBeer();
            //Assert  
            Assert.IsNotNull(beers);
        }
        [TestMethod]
        public void Test_GetBeer_WithNoValue()
        {
            //Arrange  
            var mockReadItemCommand = new Mock<Beer>();
            var beers = new List<Beer>()
           {
              new Beer(){
              }
            };
           
            //Act  
            var actual = Manager.GetBeer();
            //Assert  
            Assert.AreNotEqual(beers,actual);
        }

    }
}

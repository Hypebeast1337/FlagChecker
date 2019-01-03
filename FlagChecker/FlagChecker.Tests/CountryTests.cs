using FlagChecker.Common;
using FlagChecker.Data.Repositories;
using FlagChecker.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FlagChecker.Tests
{
    [TestClass]
    public class CountryTests
    {
        TestHelpers testHelpers = new TestHelpers();

        [TestMethod]
        public void ShouldReturnAllCountries()
        {
            //Arrange                        
            var mockedList = testHelpers.ProvideSampleCountries();
            var mockCountryRepository = new Mock<ICountryRepository>();
            mockCountryRepository.Setup(r => r.GetAllCountries()).Returns(mockedList);
            var countryService = new CountryService(mockCountryRepository.Object);

            var countriesTotal = testHelpers.ProvideSampleCountries().Count;

            //Act
            var countriesToTest = countryService.GetAllCountries();

            //Assert
            Assert.AreEqual(countriesToTest.Count, countriesTotal);
        }

        [TestMethod]
        public void ShouldCountContinentsProperly()
        {
            //Arrange
            var mockCountryRepository = new Mock<ICountryRepository>();
            var countryService = new CountryService(mockCountryRepository.Object);

            //Act
            var continentToTest1 = countryService.GetContinentCount("Africa", testHelpers.ProvideSampleCountries());
            var continentToTest2 = countryService.GetContinentCount("", testHelpers.ProvideSampleCountries());

            //Assert
            Assert.AreNotEqual(continentToTest1, 0);
            Assert.AreEqual(continentToTest2, 0);
        }

        [TestMethod]
        public void ShouldGetCountriesArea()
        {
            //Arrange
            var mockCountryRepository = new Mock<ICountryRepository>();
            var countryService = new CountryService(mockCountryRepository.Object);

            //Act
            var countriesToTest = countryService.GetCountriesArea(testHelpers.ProvideSampleCountries());

            //Assert
            Assert.IsTrue(countriesToTest>0);
        }

        [TestMethod]
        public void ShouldGetCountriesPercent()
        {
            //Arrange
            var mockCountryRepository = new Mock<ICountryRepository>();
            var countryService = new CountryService(mockCountryRepository.Object);

            //Act
            var countriesToTest = countryService.CountCountriesPercent(50);

            //Assert
            Assert.IsTrue(countriesToTest > 0);
        }

        [TestMethod]
        public void ShouldGetCountriesAreaPercent()
        {
            //Arrange
            var mockCountryRepository = new Mock<ICountryRepository>();
            var countryService = new CountryService(mockCountryRepository.Object);

            //Act
            var countriesToTest = countryService.CountCountriesAreaPercent(50000);

            //Assert
            Assert.IsTrue(countriesToTest > 0);
        }
    }
}

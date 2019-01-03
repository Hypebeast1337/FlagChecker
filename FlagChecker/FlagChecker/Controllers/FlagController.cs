using System;
using System.Collections.Generic;
using System.Web.Mvc;
using FlagChecker.Data.Models;
using FlagChecker.Services;
using FlagChecker.Models;

namespace FlagChecker.Controllers
{
    public class FlagController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly IShareService _shareService;
        private readonly IHelperService _helperService;

        public FlagController(ICountryService countryService, IShareService shareService, IHelperService helperService)
        {
            _countryService = countryService;
            _shareService = shareService;
            _helperService = helperService; 
        }
        public ActionResult Index()
        {
            return View(_helperService.SortCountries(_countryService.GetAllCountries()));
        }

        [HttpPost]
        public ActionResult Summary(List<string> countriesChecked)
        {
            if (countriesChecked != null)
            {
                var checkedCountries = _countryService.GetCountriesByIds(countriesChecked);
                var countriesViewModel = CreateViewModel(checkedCountries);

                _shareService.SaveShareLink(countriesViewModel.ShareLink.Substring(4), DateTime.Now, countriesViewModel.Countries);

                return View(countriesViewModel);
            }
            else
            {
                return View("Error", ErrorViewModel.Type.Default);
            }
        }

        [HttpGet]
        public ActionResult Summary(string id)
        {
            var checkedCountries = _shareService.GetCountriesByShareUid(id);

            if(checkedCountries == null)
                return View("Error", ErrorViewModel.Type.Link);

            var countriesViewModel = CreateViewModel(checkedCountries);

            return View(countriesViewModel);
        }

        public ActionResult Error(ErrorViewModel.Type errorType)
        {
            return View(errorType);
        }

        public CountryViewModel CreateViewModel(List<Country> countries)
        {
            CountryViewModel flags = new CountryViewModel();

            flags.Countries = countries;
            flags.CountriesCount = countries.Count;
            flags.EuropeanCountriesCount = _countryService.GetContinentCount("Europe", countries);
            flags.AsianCountriesCount = _countryService.GetContinentCount("Asia", countries);
            flags.AfricanCountriesCount = _countryService.GetContinentCount("Africa", countries);
            flags.SAmericanCountriesCount = _countryService.GetContinentCount("South America", countries);
            flags.NAmericanCountriesCount = _countryService.GetContinentCount("North America", countries);
            flags.AustralianCountriesCount = _countryService.GetContinentCount("Australia", countries);
            flags.CountriesArea = _countryService.GetCountriesArea(countries).ToString("N0");
            flags.CountriesPercent = _countryService.CountCountriesPercent(flags.CountriesCount);
            flags.CountriesAreaPercent = _countryService.CountCountriesAreaPercent(_countryService.GetCountriesArea(countries));
            flags.ShareLink = "?id=" + _shareService.GenerateGuid();

            return flags;
        }
    }
}
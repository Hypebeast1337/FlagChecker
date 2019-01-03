using System;
using System.Collections.Generic;
using FlagChecker.Data.Models;
using FlagChecker.Data.Repositories;

namespace FlagChecker.Services
{
    public class ShareService : IShareService
    {
        private readonly IShareRepository _repository;
        private readonly IHelperService _helperService;

        public ShareService(IShareRepository repository, IHelperService helperService)
        {
            _repository = repository;
            _helperService = helperService;
        }

        public string GenerateGuid()
        {
            return Guid.NewGuid().ToString("N").Substring(0,12);
        }

        public void SaveShareLink(string uid, DateTime date, List<Country> countries)
        {
            _repository.Save(uid, date, _helperService.Serialize(countries));
        }

        public List<Country> GetCountriesByShareUid(string uid)
        {
            var countries = _repository.GetCountriesByUid(uid).Countries;

            if (countries == null)
                return null;
            return _helperService.Deserialize(countries);
        }
    }
}

using Data.Context;
using Data.Interface;
using EmergentWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace EmergentWeb.Controllers
{
    public class VersionController : Controller
    {
        private readonly IVersionService _versionService;

        private readonly IVersionRepository _versionRepository;
        public VersionController(IVersionService versionService, IVersionRepository versionRepository) 
        {
            _versionService = versionService;
            _versionRepository = versionRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexDb()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckVersion(string version)
        {
            if (!_versionService.IsValidVersion(version))
            {
                return View("Index", "Invalid version format.");
            }

            var allSoftware = SoftwareManager.GetAllSoftware();
            var filteredSoftware = allSoftware.Where(s => _versionService.IsVersionGreaterThan(version, s.Version)).ToList();

            return View("Results", filteredSoftware);
        }

        [HttpPost]
        public IActionResult CheckVersionDb(string version)
        {
            if (!_versionService.IsValidVersion(version))
            {
                return View("IndexDb", "Invalid version format.");
            }

            var listSoftwareDb = _versionRepository.GetAll();
            var listSoftware = MapDbModelListToSoftwareModelList(listSoftwareDb.ToList());

            var filteredSoftware = listSoftware.Where(s => _versionService.IsVersionGreaterThan(version, s.Version)).ToList();

            return View("ResultsDb", filteredSoftware);
        }


        public List<SoftwareModel> MapDbModelListToSoftwareModelList(List<SoftwareModelDb> dbModels)
        {
            var models = new List<SoftwareModel>();
            foreach (var dbModel in dbModels)
            {
                models.Add(new SoftwareModel
                {
                    Name = dbModel.Name,
                    Version = dbModel.Version
                });
            }
            return models;
        }


    }
}

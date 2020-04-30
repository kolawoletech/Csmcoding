using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sm_coding_challenge.Models;
using sm_coding_challenge.Services.DataProvider;

namespace sm_coding_challenge.Controllers
{
    public class HomeController : Controller
    {

        private IDataProvider _dataProvider;
        public HomeController(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider ?? throw new ArgumentNullException(nameof(dataProvider));
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> PlayerAsync(string id)
        {
            return Json(await _dataProvider.GetPlayerById(id));
        }

        [HttpGet]
        public async Task<IActionResult> PlayersAsync(string ids)
        {
            var idList = ids.Split(',');
            var returnList = new List<PlayerModel>();
            foreach (var id in idList)
            {
                returnList.Add(await _dataProvider.GetPlayerById(id));
            }
            return Json(returnList);
        }

       


        [HttpGet]
        public async Task<IActionResult> LatestPlayersAsync(string ids)
        {
            var idList = ids.Split(',');
            var returnList = new List<LatestPlayerModel>();
            foreach (var id in idList)
            {
                returnList.Add(await _dataProvider.GetLatestPlayers(ids));
            }
            return Json(returnList);        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

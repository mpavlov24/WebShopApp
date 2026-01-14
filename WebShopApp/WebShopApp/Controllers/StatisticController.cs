using Microsoft.AspNetCore.Mvc;

using WebShopApp.Core.Contracts;
using WebShopApp.Models.Statistic;

namespace WebShopApp.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IStatisticService statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            this.statisticService = statisticService;
        }
        public IActionResult Index()
        {
            StatisticVM statistic = new StatisticVM();

            statistic.CountClients = statisticService.CountClients();
            statistic.CountOrders = statisticService.CountOrders();
            statistic.CountProducts = statisticService.CountProducts();
            statistic.SumOrders = statisticService.SumOrders();

            return View(statistic);
        }
    }
}

﻿using APIDashboard.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDashboard.Controllers
{
    public class ProductionController : Controller
    {
        // GET: /<controller>/
        public IActionResult Production(string titleInfos, string infos, string stateInfos,
        string titlePC, string statusbyMetPC, int numberPC,
        string titleIss, int numIss, string expliIss, string stIss, string dateResoIss,
        string titleMet, string cateMet, string nameMet, string staMet)
        {
            DashBoardProd dashboardP = new DashBoardProd()
            {
                TitleImportantInformations = titleInfos,
                ImportantInfos = infos,
                StateImportantInformations = stateInfos,
                TitlePieChart = titlePC,
                StatusByMethodPieChart = statusbyMetPC,
                NumberMethodsByStatus = numberPC,
                TitleIssue = titleIss,
                NumberIssue = numIss,
                ExplicationIssue = expliIss,
                StateIssue = stIss,
                DateOfResolutionIssue = dateResoIss,
                TitleMethod = titleMet,
                CategoryMethod = cateMet,
                NameMethod = nameMet,
                StateMethod = staMet,
            };
            dashboardP.GetMethodsStatusList();

            return View(dashboardP);
        }
    }
}
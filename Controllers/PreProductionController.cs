﻿using Microsoft.AspNetCore.Mvc;
using APIDashboard.Models;
using System;

namespace APIDashboard.Controllers
{
    public class PreProductionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PreProduction(string titleInfos, string infos, string stateInfos, string titlePC, string statusbyMetPC, int numberPC, string titleIss, int numIss, string expliIss, string stIss, string dateResoIss, string titleMet, string nameMet, string staMet, string titleCal, string month, string monthPlus1, string dateOfTheDay, string state)
        {            
            DashBoardPreProd dashboardPP = new DashBoardPreProd()
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
                NameMethod = nameMet,
                StateMethod = staMet,
                TitleCalendar = titleCal,
                Month = month,
                MonthPlus1 = monthPlus1,
                DateOfTheDay = dateOfTheDay,
                StateDateCalendar = state
            };
            dashboardPP.GetMethodsStatusList();

            return View(dashboardPP);
        }
    }
}
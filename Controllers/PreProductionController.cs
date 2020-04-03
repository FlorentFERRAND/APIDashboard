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

        public IActionResult PreProduction(string titleInfos, string infos, string stateInfos, string titlePC, string statusbyMetPC, int numberPC, string titleIss, int numIss, string expliIss, string stIss, string dateResoIss, string titleMet, string nameMet, string staMet, string titleCal1, string monthAP1 ,string titleCal, string month, string monthPlus1, string dateOfTheDay, string state, /*string titleCal1M1,*/ string monthAPP1M1, string titleCalM1, string monthM1, string monthPlus1M1, string dateOfTheDayM1, string stateM1)
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
                TitleCalendar1 = titleCal1,
                MonthAP = monthAP1,
                TitleCalendar = titleCal,
                Month = month,
                MonthPlus1 = monthPlus1,
                DateOfTheDay = dateOfTheDay,
                StateDateCalendar = state,
                //TitleCalendar1M1 = titleCal1M1,
                MonthAPM1 = monthAPP1M1,
                TitleCalendarM1 = titleCalM1,
                MonthM1 = monthM1,
                MonthPlus1M1 = monthPlus1M1,
                DateOfTheDayM1 = dateOfTheDayM1,
                StateDateCalendarM1 = stateM1
            };
            dashboardPP.GetMethodsStatusList();

            return View(dashboardPP);
        }
    }
}
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

        public IActionResult PreProduction(string titleInfos, string infos, string stateInfos,
        string titlePC, string statusbyMetPC, int numberPC,
        string titleIss, int numIss, string expliIss, string stIss, string dateResoIss,
        string titleMet, string cateMet, string nameMet, string staMet,
        string titleCalendrM1, string monthCalM1, string day1M1, string day2M1, string day3M1, string day4M1, string day5M1,
        string monthCalM2, string day1M2, string day2M2, string day3M2, string day4M2, string day5M2)
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
                CategoryMethod = cateMet,
                NameMethod = nameMet,
                StateMethod = staMet,
                TitleCalendarM1 = titleCalendrM1,
                MonthCalM1 = monthCalM1,
                DayOfTheWeekDayStatusOfTheDay1M1 = day1M1,
                DayOfTheWeekDayStatusOfTheDay2M1 = day2M1,
                DayOfTheWeekDayStatusOfTheDay3M1 = day3M1,
                DayOfTheWeekDayStatusOfTheDay4M1 = day4M1,
                DayOfTheWeekDayStatusOfTheDay5M1 = day5M1,
                MonthCalM2 = monthCalM2,
                DayOfTheWeekDayStatusOfTheDay1M2 = day1M2,
                DayOfTheWeekDayStatusOfTheDay2M2 = day2M2,
                DayOfTheWeekDayStatusOfTheDay3M2 = day3M2,
                DayOfTheWeekDayStatusOfTheDay4M2 = day4M2,
                DayOfTheWeekDayStatusOfTheDay5M2 = day5M2
            };
            dashboardPP.GetMethodsStatusList();

            return View(dashboardPP);
        }
    }
}
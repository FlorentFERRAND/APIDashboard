using APIDashboard.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDashboard.Controllers
{
    public class APISOAPController : Controller
    {
        public IActionResult APISOAP(string titleInfos, string infos, string stateInfos,
        string titlePC, string statusbyMetPC, int numberPC,
        string titleIss, int numIss, string expliIss, string stIss, string dateResoIss,
        string titleMet, string cateMet, string typeMet, string nameMet, string staMet, string tooltipStaMet)
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
                TypeMethod = typeMet,
                NameMethod = nameMet,
                StateMethod = staMet,
                TooltipStateMethod = tooltipStaMet
            };
            dashboardP.GetMethodsStatusList();

            return View(dashboardP);
        }

        public IActionResult Production(string titleInfos, string infos, string stateInfos,
        string titlePC, string statusbyMetPC, int numberPC,
        string titleIss, int numIss, string expliIss, string stIss, string dateResoIss,
        string titleMet, string cateMet, string typeMet, string nameMet, string staMet, string tooltipStaMet)
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
                TypeMethod = typeMet,
                NameMethod = nameMet,
                StateMethod = staMet,
                TooltipStateMethod = tooltipStaMet
            };
            dashboardP.GetMethodsStatusList();

            return View(dashboardP);
        }
        public IActionResult PreProduction(string titleInfos, string infos, string stateInfos,
        string titlePC, string statusbyMetPC, int numberPC,
        string titleIss, int numIss, string expliIss, string stIss, string dateResoIss,
        string titleMet, string cateMet, string typeMet, string nameMet, string staMet, string tooltipStaMet,
        string calsCTitle, string monthCalM1, string day1M1, string day2M1, string day3M1, string day4M1, string day5M1,
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
                TypeMethod = typeMet,
                NameMethod = nameMet,
                StateMethod = staMet,
                TooltipStateMethod = tooltipStaMet,
                CalendarsCardTitle = calsCTitle,
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
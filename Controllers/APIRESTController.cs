using APIDashboard.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDashboard.Controllers
{
    public class APIRESTController : Controller
    {
        public IActionResult APIREST(string titleInfos, string infos, string stateInfos,
        string titlePC, string statusbyMetPC, int numberPC,
        string titleIss, int numIss, string expliIss, string stIss, string dateResoIss,
        string titleMet, string cateMet, string typeMet, string nameMet, string staMet, string tooltipStaMet)
        {
            DashBoardProdREST dashboardPREST = new DashBoardProdREST()
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
            dashboardPREST.GetMethodsStatusListREST();

            return View(dashboardPREST);
        }
        public IActionResult Production(string titleInfos, string infos, string stateInfos,
        string titlePC, string statusbyMetPC, int numberPC,
        string titleIss, int numIss, string expliIss, string stIss, string dateResoIss,
        string titleMet, string cateMet, string typeMet, string nameMet, string staMet, string tooltipStaMet)
        {
            DashBoardProdREST dashboardPREST = new DashBoardProdREST()
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
            dashboardPREST.GetMethodsStatusListREST();

            return View(dashboardPREST);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.IO;

namespace APIDashboard.Models
{
    public class DashBoardPreProd
    {
        public string TitleImportantInformations { get; set; }
        public string ImportantInfos { get; set; }
        public string StateImportantInformations { get; set; }
        public List<Informations> _Informations;

        public string TitlePieChart { get; set; }
        public string StatusByMethodPieChart { get; set; }
        public int NumberMethodsByStatus { get; set; }
        public List<PieChart> _PieChart;

        public string TitleIssue { get; set; }
        public int NumberIssue { get; set; }
        public string ExplicationIssue { get; set; }
        public string StateIssue { get; set; }
        public string DateOfResolutionIssue { get; set; }
        public List<Issues> _Issues;

        public string TitleMethod { get; set; }
        public string NameMethod { get; set; }
        public string StateMethod { get; set; }
        public List<Methods> _Methods;

        public string TitleCalendar { get; set; }
        public string Month { get; set; }
        public string MonthPlus1 { get; set; }
        public string DateOfTheDay { get; set; }
        public string StateDateCalendar { get; set; }
        public List<Calendars> _Calendars;

        public DashBoardPreProd()
        {
            _Informations = GetImportantInformationsList();
            _PieChart = GetPieChartList();
            _Issues = GetAPIIssuesList();
            _Methods = GetMethodsStatusList();
            SetMethodsStatusList();
            _Calendars = GetCalendarsDateStateList();
        }

        public List<Informations> GetImportantInformationsList()
        {
            List<Informations> NameStateInfosList = new List<Informations>();
            string error = string.Empty;

            try
            {
                /*string folderCSV = Path.GetFullPath("FichiersCSV\\PreProduction\\");
                string fileImportantInformationsCSV = "ImportantInformations";
                string filePathExtension = ".csv";
                string fileMethodsStatus = Path.GetFullPath(folderCSV + fileImportantInformationsCSV + filePathExtension);*/
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PreProduction","ImportantInformations.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitleImportantInformations = new List<string>();
                    List<string> listImportantInfos = new List<string>();
                    List<string> listStateImportantInformations = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitleImportantInformations.Add(values[0]);
                        listImportantInfos.Add(values[1]);
                        listStateImportantInformations.Add(values[2]);

                        string TitleImpInfos = "";
                        if (String.IsNullOrEmpty(TitleImpInfos))
                        {
                            TitleImpInfos = values[0];
                        }

                        string ImpInfos = "";
                        if (String.IsNullOrEmpty(ImpInfos))
                        {
                            ImpInfos = values[1];
                        }

                        string StateImpInfos = "";
                        if (String.IsNullOrEmpty(StateImpInfos))
                        {
                            StateImpInfos = values[2];
                        }

                        NameStateInfosList.Add(new Informations()
                        {
                            TitleImportantInformations = TitleImpInfos,
                            ImportantInfos = ImpInfos,
                            StateImportantInformations = StateImpInfos
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return NameStateInfosList;
        }

        public List<PieChart> GetPieChartList()
        {
            List<PieChart> PieChartList = new List<PieChart>();
            string error = string.Empty;

            try
            {
                /*string folderCSV = Path.GetFullPath("FichiersCSV\\PreProduction\\");
                string fileImportantInformationsCSV = "PieChart";
                string filePathExtension = ".csv";
                string fileMethodsStatus = Path.GetFullPath(folderCSV + fileImportantInformationsCSV + filePathExtension);*/
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PreProduction","PieChart.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitlePieChart = new List<string>();
                    List<string> listStatusByMethodPieChart = new List<string>();
                    List<int> listNumberMethodsByStatus = new List<int>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitlePieChart.Add(values[0]);
                        listStatusByMethodPieChart.Add(values[1]);
                        listNumberMethodsByStatus.Add(Convert.ToInt16(values[2]));

                        string TitlePieChart = "";
                        if (String.IsNullOrEmpty(TitlePieChart))
                        {
                            TitlePieChart = values[0];
                        }

                        string StatusPieChart = "";
                        if (String.IsNullOrEmpty(StatusPieChart))
                        {
                            StatusPieChart = values[1];
                        }

                        int? NumberPieChart = 1;
                        if (NumberPieChart.HasValue)
                        {
                            NumberPieChart = Convert.ToInt16(values[2]);
                        }

                        PieChartList.Add(new PieChart()
                        {
                            TitlePieChart = TitlePieChart,
                            StatusByMethodPieChart = StatusPieChart,
                            NumberMethodsByStatus = Convert.ToInt16(NumberPieChart)
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return PieChartList;
        }

        public List<Issues> GetAPIIssuesList()
        {
            List<Issues> APIIssuesList = new List<Issues>();
            string error = string.Empty;

            try
            {
                /*string folderCSV = Path.GetFullPath("FichiersCSV\\PreProduction\\");
                string fileAPIIssuesCSV = "APIIssues";
                string filePathExtension = ".csv";
                string fileMethodsStatus = Path.GetFullPath(folderCSV + fileAPIIssuesCSV + filePathExtension);*/
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PreProduction","APIIssues.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitleIssue = new List<string>();
                    List<int> listNumberIssue = new List<int>();
                    List<string> listExplicationIssue = new List<string>();
                    List<string> listStateIssue = new List<string>();
                    List<string> listDateOfResolutionIssue = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitleIssue.Add(values[0]);
                        listNumberIssue.Add(Convert.ToInt16(values[1]));
                        listExplicationIssue.Add(values[2]);
                        listStateIssue.Add(values[3]);
                        listDateOfResolutionIssue.Add(values[4]);

                        string TiIssue = "";
                        if (String.IsNullOrEmpty(TiIssue))
                        {
                            TiIssue = values[0];
                        }

                        int? NumIssue = 1;
                        if (NumIssue.HasValue)
                        {
                            NumIssue = Convert.ToInt16(values[1]);
                        }

                        string ExpliIssue = "";
                        if (String.IsNullOrEmpty(ExpliIssue))
                        {
                            ExpliIssue = values[2];
                        }

                        string StaIssue = "";
                        if (String.IsNullOrEmpty(StaIssue))
                        {
                            StaIssue = values[3];
                        }

                        string DateResolIssue = "";
                        if (String.IsNullOrEmpty(DateResolIssue))
                        {
                            DateResolIssue = values[4];
                        }

                        APIIssuesList.Add(new Issues()
                        {
                            TitleIssue = TiIssue,
                            NumberIssue = Convert.ToInt16(NumIssue),
                            ExplicationIssue = ExpliIssue,
                            StateIssue = StaIssue,
                            DateOfResolutionIssue = DateResolIssue
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return APIIssuesList;
        }

        public List<Methods> GetMethodsStatusList()
        {
            List<Methods> MethodsStatusList = new List<Methods>();
            string error = string.Empty;
            try
            {
                /*string folderCSV = Path.GetFullPath("FichiersCSV\\PreProduction\\");
                string fileNameMethodsStatusCSV = "StatusByMethod";
                string filePathExtension = ".csv";
                string fileMethodsStatus = Path.GetFullPath(folderCSV + fileNameMethodsStatusCSV + filePathExtension);*/
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PreProduction","StatusByMethod.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitleMethod = new List<string>();
                    List<string> listNameMethod = new List<string>();
                    List<string> listStateMethod = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitleMethod.Add(values[0]);
                        listNameMethod.Add(values[1]);
                        listStateMethod.Add(values[2]);

                        string Title = "";
                        if (String.IsNullOrEmpty(Title))
                        {
                            Title = values[0];
                        }

                        string Name = "";
                        if (String.IsNullOrEmpty(Name))
                        {
                            Name = values[1];
                        }

                        string State = "";
                        if (String.IsNullOrEmpty(State))
                        {
                            State = values[2];
                        }

                        MethodsStatusList.Add(new Methods()
                        {
                            TitleMethod = Title,
                            NameMethod = Name,
                            StateMethod = State
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return MethodsStatusList;
        }

        protected void SetMethodsStatusList()
        {
            foreach (Methods m in _Methods)
            {
                if (m.StateMethod == "OK")
                {
                    m._color = "st-green";
                }
                else if (m.StateMethod == "NOK")
                {
                    m._color = "st-yellow";
                }
                else
                {
                    m._color = "st-red";
                }
            }
        }

        public List<Calendars> GetCalendarsDateStateList()
        {
            List<Calendars> CalendarsDateStateList = new List<Calendars>();
            string error = string.Empty;

            try
            {
                /*string folderCSV = Path.GetFullPath("FichiersCSV\\PreProduction\\");
                string fileCalendarCSV = "Calendars";
                string filePathExtension = ".csv";
                string fileMethodsStatus = Path.GetFullPath(folderCSV + fileCalendarCSV + filePathExtension);*/
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PreProduction","Calendars.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitleCalendar = new List<string>();
                    List<string> listMonth = new List<string>();
                    List<string> listMonthPlus1 = new List<string>();
                    List<string> listDateOfTheDay = new List<string>();
                    List<string> listStateDateCalendar = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitleCalendar.Add(values[0]);
                        listMonth.Add(values[1]);
                        listMonthPlus1.Add(values[2]);
                        listDateOfTheDay.Add(values[3]);
                        listStateDateCalendar.Add(values[4]);

                        /*DateTime? DateDay = null;
                        if (DateDay.HasValue)
                        {
                            DateDay = Convert.ToDateTime(values[0]);
                        }*/

                        string TitleCal = "";
                        if (String.IsNullOrEmpty(TitleCal))
                        {
                            TitleCal = values[0];
                        }

                        string MonthCal = "";
                        if (String.IsNullOrEmpty(MonthCal))
                        {
                            MonthCal = values[1];
                        }

                        string MonthPlus1Cal = "";
                        if (String.IsNullOrEmpty(MonthPlus1Cal))
                        {
                            MonthPlus1Cal = values[2];
                        }

                        string Date = "";
                        if (String.IsNullOrEmpty(Date))
                        {
                            Date = values[3];
                        }

                        string State = "";
                        if (String.IsNullOrEmpty(State))
                        {
                            State = values[4];
                        }

                        CalendarsDateStateList.Add(new Calendars()
                        {
                            TitleCalendar = TitleCal,
                            Month = MonthCal,
                            MonthPlus1 =MonthPlus1Cal,
                            DateOfTheDay = Date,
                            StateDateCalendar = State
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return CalendarsDateStateList;
        }
    }
}
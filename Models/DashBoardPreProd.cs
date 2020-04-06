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
        public string CategoryMethod { get; set; }
        public string NameMethod { get; set; }
        public string StateMethod { get; set; }
        public List<Methods> _Methods;

        public string TitleCalendarM1 { get; set; }
        public string MonthCalM1 {get;set;}
        public string DayOfTheWeekDayStatusOfTheDay1M1 { get; set; }
        public string DayOfTheWeekDayStatusOfTheDay2M1 { get; set; }
        public string DayOfTheWeekDayStatusOfTheDay3M1 { get; set; }
        public string DayOfTheWeekDayStatusOfTheDay4M1 { get; set; }
        public string DayOfTheWeekDayStatusOfTheDay5M1 { get; set; }
        public List<CalendarM1> _CalendarM1;

        public string MonthCalM2 {get;set;}
        public string DayOfTheWeekDayStatusOfTheDay1M2 { get; set; }
        public string DayOfTheWeekDayStatusOfTheDay2M2 { get; set; }
        public string DayOfTheWeekDayStatusOfTheDay3M2 { get; set; }
        public string DayOfTheWeekDayStatusOfTheDay4M2 { get; set; }
        public string DayOfTheWeekDayStatusOfTheDay5M2 { get; set; }
        public List<CalendarM2> _CalendarM2;

        public DashBoardPreProd()
        {
            _Informations = GetImportantInformationsList();
            _PieChart = GetPieChartList();
            _Issues = GetAPIIssuesList();
            _Methods = GetMethodsStatusList();
            _CalendarM1 = GetCalendarsDateStateListM1();
            _CalendarM2 = GetCalendarsDateStateListM2();
        }

        public List<Informations> GetImportantInformationsList()
        {
            List<Informations> NameStateInfosList = new List<Informations>();
            string error = string.Empty;

            try
            {
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
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PreProduction","StatusByMethod.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitleMethod = new List<string>();
                    List<string> listCategoryMethod = new List<string>();
                    List<string> listNameMethod = new List<string>();
                    List<string> listStateMethod = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitleMethod.Add(values[0]);
                        listCategoryMethod.Add(values[1]);
                        listNameMethod.Add(values[2]);
                        listStateMethod.Add(values[3]);

                        string Title = "";
                        if (String.IsNullOrEmpty(Title))
                        {
                            Title = values[0];
                        }

                        string CategoryMeth = "";
                        if (String.IsNullOrEmpty(CategoryMeth))
                        {
                            CategoryMeth = values[1];
                        }

                        string Name = "";
                        if (String.IsNullOrEmpty(Name))
                        {
                            Name = values[2];
                        }

                        string State = "";
                        if (String.IsNullOrEmpty(State))
                        {
                            State = values[3];
                        }

                        MethodsStatusList.Add(new Methods()
                        {
                            TitleMethod = Title,
                            CategoryMethod = CategoryMeth,
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

        public List<CalendarM1> GetCalendarsDateStateListM1()
        {
            List<CalendarM1> CalendarsDateStateList = new List<CalendarM1>();
            string error = string.Empty;

            try
            {
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PreProduction","CalendarM1.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitleCalendarM1 = new List<string>();
                    List<string> listMonthCalM1 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay1M1 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay2M1 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay3M1 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay4M1 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay5M1 = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitleCalendarM1.Add(values[0]);
                        listMonthCalM1.Add(values[1]);
                        listDayOfTheWeekDayStatusOfTheDay1M1.Add(values[2]);
                        listDayOfTheWeekDayStatusOfTheDay2M1.Add(values[3]);
                        listDayOfTheWeekDayStatusOfTheDay3M1.Add(values[4]);
                        listDayOfTheWeekDayStatusOfTheDay4M1.Add(values[5]);
                        listDayOfTheWeekDayStatusOfTheDay5M1.Add(values[6]);

                        string TitleCalM1 = "";
                        if (String.IsNullOrEmpty(TitleCalM1))
                        {
                            TitleCalM1 = values[0];
                        }

                        string MonthCaldrM1 = "";
                        if (String.IsNullOrEmpty(MonthCaldrM1))
                        {
                            MonthCaldrM1 = values[1];
                        }

                        string Day1M1 = "";
                        if (String.IsNullOrEmpty(Day1M1))
                        {
                            Day1M1 = values[2];
                        }

                        string Day2M1 = "";
                        if (String.IsNullOrEmpty(Day2M1))
                        {
                            Day2M1 = values[3];
                        }

                        string Day3M1 = "";
                        if (String.IsNullOrEmpty(Day3M1))
                        {
                            Day3M1 = values[4];
                        }

                        string Day4M1 = "";
                        if (String.IsNullOrEmpty(Day4M1))
                        {
                            Day4M1 = values[5];
                        }

                        string Day5M1 = "";
                        if (String.IsNullOrEmpty(Day5M1))
                        {
                            Day5M1 = values[6];
                        }

                        CalendarsDateStateList.Add(new CalendarM1()
                        {
                            TitleCalendarM1 = TitleCalM1,
                            MonthCalM1 = MonthCaldrM1,
                            DayOfTheWeekDayStatusOfTheDay1M1 = Day1M1,
                            DayOfTheWeekDayStatusOfTheDay2M1 = Day2M1,
                            DayOfTheWeekDayStatusOfTheDay3M1 = Day3M1,
                            DayOfTheWeekDayStatusOfTheDay4M1 = Day4M1,
                            DayOfTheWeekDayStatusOfTheDay5M1 = Day5M1
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

        public List<CalendarM2> GetCalendarsDateStateListM2()
        {
            List<CalendarM2> CalendarsDateStateListM1 = new List<CalendarM2>();
            string error = string.Empty;

            try
            {
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/PreProduction","CalendarM2.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listMonthCalM2 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay1M2 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay2M2 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay3M2 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay4M2 = new List<string>();
                    List<string> listDayOfTheWeekDayStatusOfTheDay5M2 = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listMonthCalM2.Add(values[0]);
                        listDayOfTheWeekDayStatusOfTheDay1M2.Add(values[1]);
                        listDayOfTheWeekDayStatusOfTheDay2M2.Add(values[2]);
                        listDayOfTheWeekDayStatusOfTheDay3M2.Add(values[3]);
                        listDayOfTheWeekDayStatusOfTheDay4M2.Add(values[4]);
                        listDayOfTheWeekDayStatusOfTheDay5M2.Add(values[5]);

                        string MonthCaldrM2 = "";
                        if (String.IsNullOrEmpty(MonthCaldrM2))
                        {
                            MonthCaldrM2 = values[0];
                        }

                        string Day1M2 = "";
                        if (String.IsNullOrEmpty(Day1M2))
                        {
                            Day1M2 = values[1];
                        }

                        string Day2M2 = "";
                        if (String.IsNullOrEmpty(Day2M2))
                        {
                            Day2M2 = values[2];
                        }

                        string Day3M2 = "";
                        if (String.IsNullOrEmpty(Day3M2))
                        {
                            Day3M2 = values[3];
                        }

                        string Day4M2 = "";
                        if (String.IsNullOrEmpty(Day4M2))
                        {
                            Day4M2 = values[4];
                        }

                        string Day5M2 = "";
                        if (String.IsNullOrEmpty(Day5M2))
                        {
                            Day5M2 = values[5];
                        }

                        CalendarsDateStateListM1.Add(new CalendarM2()
                        {
                            MonthCalM2 = MonthCaldrM2,
                            DayOfTheWeekDayStatusOfTheDay1M2 = Day1M2,
                            DayOfTheWeekDayStatusOfTheDay2M2 = Day2M2,
                            DayOfTheWeekDayStatusOfTheDay3M2 = Day3M2,
                            DayOfTheWeekDayStatusOfTheDay4M2 = Day4M2,
                            DayOfTheWeekDayStatusOfTheDay5M2 = Day5M2
                        });
                    }
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                error = e.Message;
            }

            return CalendarsDateStateListM1;
        }
    }
}
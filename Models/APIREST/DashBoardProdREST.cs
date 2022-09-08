﻿using System;
using System.Collections.Generic;
using System.IO;

namespace APIDashboard.Models
{
    public class DashBoardProdREST
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
        public string VersionMethod { get; set; }
        public string CategoryMethod { get; set; }
        public string TypeMethod { get; set; }
        public string NameMethod { get; set; }
        public string StateMethod { get; set; }
        public string TooltipStateMethod { get; set; }
        public List<Methods> _Methods;

        public string TitleMethodV2 { get; set; }
        public string VersionMethodV2 { get; set; }
        public string CategoryMethodV2 { get; set; }
        public string TypeMethodV2 { get; set; }
        public string NameMethodV2 { get; set; }
        public string StateMethodV2 { get; set; }
        public string TooltipStateMethodV2 { get; set; }
        public List<MethodsV2> _MethodsV2;
        public DashBoardProdREST()
        {
            _Informations = GetImportantInformationsListREST();
            _PieChart = GetPieChartListREST();
            _Issues = GetAPIIssuesListREST();
            _Methods = GetMethodsStatusListREST();
            _MethodsV2 = GetMethodsStatusListRESTV2();
        }

        public List<Informations> GetImportantInformationsListREST()
        {
            List<Informations> NameStateInfosList = new List<Informations>();
            string error = string.Empty;

            try
            {
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/APIREST/Production","ImportantInformations.csv");
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

        public List<PieChart> GetPieChartListREST()
        {
            List<PieChart> PieChartList = new List<PieChart>();
            string error = string.Empty;

            try
            {
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/APIREST/Production","PieChart.csv");
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

        public List<Issues> GetAPIIssuesListREST()
        {
            List<Issues> APIIssuesList = new List<Issues>();
            string error = string.Empty;

            try
            {
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/APIREST/Production","APIIssues.csv");
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

        public List<Methods> GetMethodsStatusListREST()
        {
            List<Methods> MethodsStatusList = new List<Methods>();
            string error = string.Empty;
            try
            {
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/APIREST/Production","StatusByMethod.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitleMethod = new List<string>();
                    List<string> listVersionMethod = new List<string>();
                    List<string> listCategoryMethod = new List<string>();
                    List<string> listTypeMethod = new List<string>();
                    List<string> listNameMethod = new List<string>();
                    List<string> listStateMethod = new List<string>();
                    List<string> listTooltipStateMethod = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitleMethod.Add(values[0]);
                        listVersionMethod.Add(values[1]);
                        listCategoryMethod.Add(values[2]);
                        listTypeMethod.Add(values[3]);
                        listNameMethod.Add(values[4]);
                        listStateMethod.Add(values[5]);
                        listTooltipStateMethod.Add(values[6]);

                        string Title = "";
                        if (String.IsNullOrEmpty(Title))
                        {
                            Title = values[0];
                        }

                        string Version = "";
                        if (String.IsNullOrEmpty(Version))
                        {
                            Version = values[1];
                        }

                        string CategoryMeth = "";
                        if (String.IsNullOrEmpty(CategoryMeth))
                        {
                            CategoryMeth = values[2];
                        }

                        string TypeMeth = "";
                        if (String.IsNullOrEmpty(TypeMeth))
                        {
                            TypeMeth = values[3];
                        }

                        string Name = "";
                        if (String.IsNullOrEmpty(Name))
                        {
                            Name = values[4];
                        }

                        string State = "";
                        if (String.IsNullOrEmpty(State))
                        {
                            State = values[5];
                        }

                        string Tootltip = "";
                        if (String.IsNullOrEmpty(Tootltip))
                        {
                            Tootltip = values[6];
                        }

                        MethodsStatusList.Add(new Methods()
                        {
                            TitleMethod = Title,
                            VersionMethod = Version,
                            CategoryMethod = CategoryMeth,
                            TypeMethod = TypeMeth,
                            NameMethod = Name,
                            StateMethod = State,
                            TooltipStateMethod = Tootltip
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

        public List<MethodsV2> GetMethodsStatusListRESTV2()
        {
            List<MethodsV2> MethodsStatusList = new List<MethodsV2>();
            string error = string.Empty;
            try
            {
				string fileMethodsStatus = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/APIREST/Production","StatusByMethod_V2.csv");
                using (var reader = new StreamReader(fileMethodsStatus))
                {
                    List<string> listTitleMethod = new List<string>();
                    List<string> listVersionMethod = new List<string>();
                    List<string> listCategoryMethod = new List<string>();
                    List<string> listTypeMethod = new List<string>();
                    List<string> listNameMethod = new List<string>();
                    List<string> listStateMethod = new List<string>();
                    List<string> listTooltipStateMethod = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listTitleMethod.Add(values[0]);
                        listVersionMethod.Add(values[1]);
                        listCategoryMethod.Add(values[2]);
                        listTypeMethod.Add(values[3]);
                        listNameMethod.Add(values[4]);
                        listStateMethod.Add(values[5]);
                        listTooltipStateMethod.Add(values[6]);

                        string Title = "";
                        if (String.IsNullOrEmpty(Title))
                        {
                            Title = values[0];
                        }

                        string Version = "";
                        if (String.IsNullOrEmpty(Version))
                        {
                            Version = values[1];
                        }

                        string CategoryMeth = "";
                        if (String.IsNullOrEmpty(CategoryMeth))
                        {
                            CategoryMeth = values[2];
                        }

                        string TypeMeth = "";
                        if (String.IsNullOrEmpty(TypeMeth))
                        {
                            TypeMeth = values[3];
                        }

                        string Name = "";
                        if (String.IsNullOrEmpty(Name))
                        {
                            Name = values[4];
                        }

                        string State = "";
                        if (String.IsNullOrEmpty(State))
                        {
                            State = values[5];
                        }

                        string Tootltip = "";
                        if (String.IsNullOrEmpty(Tootltip))
                        {
                            Tootltip = values[6];
                        }

                        MethodsStatusList.Add(new MethodsV2()
                        {
                            TitleMethodV2 = Title,
                            VersionMethodV2 = Version,
                            CategoryMethodV2 = CategoryMeth,
                            TypeMethodV2 = TypeMeth,
                            NameMethodV2 = Name,
                            StateMethodV2 = State,
                            TooltipStateMethodV2 = Tootltip
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

    }
}
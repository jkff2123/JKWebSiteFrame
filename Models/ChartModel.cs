using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteFrame.Models
{
    public class OverviewChartSet
    {
        public OverviewChartSet(OverviewBarChartModel barChart, OverviewTimeChartModel timeChart)
        {
            BarChart = barChart;
            TimeChart = timeChart;
        }

        public OverviewBarChartModel BarChart { get; set; }
        public OverviewTimeChartModel TimeChart { get; set; }
    }

    public class OverviewBarChartModel
    {
        public OverviewBarChartModel(string title, string[] columnLabels, string[] rowLabels, double[] data)
        {
            Title = title;
            ColumnLabels = columnLabels;
            RowLabels = rowLabels;
            Data = data;
        }

        public string Title { get; set; }
        public string[] ColumnLabels { get; set; }
        public string[] RowLabels { get; set; }
        public double[] Data { get; set; }
    }

    public class OverviewTimeChartModel
    {
        public OverviewTimeChartModel(string title, string[] columnLabels, string time, double data)
        {
            Title = title;
            ColumnLabels = columnLabels;
            Time = time;
            Data = data;
        }

        public string Title { get; set; }
        public string[] ColumnLabels { get; set; }
        public string Time { get; set; }
        public double Data { get; set; }
    }
}

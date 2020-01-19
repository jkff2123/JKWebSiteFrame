using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using WebSiteFrame.Models;
using System;

namespace WebSiteFrame.Hubs
{
    public class ChartHub : Hub
    {
        public async Task RealTimeChartRefresh()
        {
            var rand = new Random();

            var barChart = new OverviewBarChartModel("temp Chart",
                new string[] { "row name", "col1"},
                new string[] { "row1", "row2", "row3", "row4", "row5", "row6" },
                new double[] {
                    rand.Next(1,100)*rand.NextDouble(),
                    rand.Next(1, 100) * rand.NextDouble(),
                    rand.Next(1, 100) * rand.NextDouble(),
                    rand.Next(1, 100) * rand.NextDouble(),
                    rand.Next(1, 100) * rand.NextDouble(),
                    rand.Next(1,100)*rand.NextDouble() 
                }
            );

            var timeChart = new OverviewTimeChartModel("Time Chart",
                new string[] {"Time", "Data1"},
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                rand.Next(1, 100) * rand.NextDouble()
            );

            var result = new OverviewChartSet(barChart, timeChart);

            await Clients.All.SendAsync("ChartRefresh", result);
        }
    }
}

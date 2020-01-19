var chartColor = {
    red: 'rgb(255, 99, 132)',
    orange: 'rgb(255, 159, 64)',
    yellow: 'rgb(255, 205, 86)',
    green: 'rgb(75, 192, 192)',
    blue: 'rgb(54, 162, 235)',
    purple: 'rgb(153, 102, 255)',
    grey: 'rgb(201, 203, 207)'
};

var timeTable = [];

function setOverviewBarChartData(content){
    var table = [];
    table.push(content.columnLabels);
    for (var i = 0; i < content.rowLabels.length; i++) {
        var row = [content.rowLabels[i], content.data[i]];
        table.push(row);
    }

    return new google.visualization.arrayToDataTable(table);
}

function setOverviewTimeChartData(content) {
    if (timeTable.length == 0) {
        timeTable.push(content.columnLabels);
    }
    
    var row = [new Date(content.time), content.data];
    timeTable.push(row);

    if (timeTable.length > 20) {
        timeTable.splice(1, 1);
    }

    return new google.visualization.arrayToDataTable(timeTable);
}

function overviewBarChart(content, id) {
    var data = setOverviewBarChartData(content);
    var barChart = new google.visualization.BarChart(document.getElementById(id));
    var options = {
        title: content.title,
    };
    barChart.draw(data, options);

    return barChart;
}

function overviewTimeChart(content, id) {
    var data = setOverviewTimeChartData(content);
    var timeChart = new google.visualization.LineChart(document.getElementById(id));
    var options = {
        title: content.title,
    };
    timeChart.draw(data, options);

    return timeChart;
}
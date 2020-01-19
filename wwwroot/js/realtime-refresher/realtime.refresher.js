var connection = null;

function setHubAddress(hubPath) {
    connection = new signalR.HubConnectionBuilder().withUrl(hubPath).build();
}

function setReceiveFunction(functionName, action) {
    connection.on(functionName, action);
}

function startHub() {
    connection.start().catch(function (err) {
        return console.error(err.toString());
    });
}

function executeIntervalRefresh(milisecond) {
    setInterval(function () {
        connection.invoke("RealTimeChartRefresh").catch(function (err) {
            return console.error(err.toString());
        });
        //event.preventDefault();
    }, milisecond);
}
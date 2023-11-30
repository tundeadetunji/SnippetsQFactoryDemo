function sendData(d) {
    const Http = new XMLHttpRequest();
    var url = "https://domain.com/handler.ashx?value=" + d;
    Http.open("GET", url);
    Http.send();
}
function multipleData(url, data) {
    const Http = new XMLHttpRequest();
    //var url = "https://domain.com/handler.ashx?value=" + d;
    Http.open("GET", url + data);
    Http.send();
}
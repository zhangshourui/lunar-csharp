//var elements = document.querySelectorAll(".hr-scroller");

window.visibelCalendarSelection = () => {


    var allNodes = document.querySelectorAll(".hr-scroller div.active");
    allNodes.forEach(function (node) {
        var n = node;
        setTimeout(function () {
            n.focus();
        }, 1);
    });
    //for (var i in allNodes) {
    //    allNodes[i].focus();
    //}

    return "";
}
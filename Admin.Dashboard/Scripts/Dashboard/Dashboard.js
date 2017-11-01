$(function () {
    new Chart(document.getElementById("bar_chart").getContext("2d"), getChartJs());
    getMorris("donut_chart");
});
function initSparkline() {
    $(".sparkline").each(function () {
        var $this = $(this);
        $this.sparkline('html', $this.data());
    });
}
function getChartJs() {
    var config = {
        type: 'bar',
        data: {
            labels: ["Mo", "Tu", "We", "Th", "Fr", "Sa", "Su"],
            datasets: [{
                label: "My First dataset",
                data: [65, 59, 80, 81, 56, 55, 40],
                backgroundColor: 'rgba(0, 188, 212, 0.8)'
            }, {
                label: "My Second dataset",
                data: [28, 48, 40, 19, 86, 27, 90],
                backgroundColor: 'rgba(233, 30, 99, 0.8)'
            }]
        },
        options: {
            responsive: true,
            legend: false
        }
    }
    return config;
}

function getMorris(element) {
    Morris.Donut({
        element: element,
        height: 300,
        data: [{
            label: 'Gross',
            value: 40
        }, {
            label: 'Net',
            value: 30
        }, {
            label: 'Empty',
            value: 30
        }],
        colors: ['rgb(233, 30, 99)', 'rgb(0, 188, 212)', 'rgb(255, 152, 0)'],
        formatter: function (y) {
            return y + '%'
        }
    });
}
var HomePage = {
    ChartListingsLastest: function () {
        const myChart = new Chart(
            document.getElementById('chartListingLastest'),
            config
        );
        let datapage = $('datapage').val();
        const config = {
            type: 'line',
            data: data,
        };
        const labels = Utils.months({ count: 7 });
        const data = {
            labels: labels,
            datasets: [{
                label: 'My First Dataset',
                data: [65, 59, 80, 81, 56, 55, 40],
                fill: false,
                borderColor: 'rgb(75, 192, 192)',
                tension: 0.1
            }]
        };
    }
};
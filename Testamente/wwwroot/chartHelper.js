// wwwroot/chartHelper.js
window.renderInheritanceChart = (familyMembers) => {
    const ctx = document.getElementById('inheritanceChart').getContext('2d');

    const data = {
        labels: familyMembers.map(member => member.Name),
        datasets: [{
            data: familyMembers.map(member => member.InheritanceShare),
            backgroundColor: [
                '#FF6384', '#36A2EB', '#FFCE56', '#4BC0C0', '#9966FF', '#FF9F40'
            ],
            hoverOffset: 4
        }]
    };

    const config = {
        type: 'pie',
        data: data,
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'top',
                }
            }
        }
    };

    new Chart(ctx, config);
};

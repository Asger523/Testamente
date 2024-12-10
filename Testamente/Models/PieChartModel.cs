using Microsoft.AspNetCore.Mvc;
using ChartDirector;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class PieChartModel : PageModel
{
    // Default page request handler
    public void OnGet () { }

    // Action to generate and return the pie chart image
    public IActionResult OnGetPieChartImage ()
    {
        // Define data and labels for the pie chart
        double[] data = { 10, 30, 20, 40 };
        string[] labels = { "Red", "Green", "Blue", "Yellow" };

        // Create the PieChart object
        PieChart chart = new PieChart (300, 300);

        // Set the pie chart data
        chart.setData (data, labels);

        // Set custom slice colors
        chart.setColors2 (0, new int[] { 0xFF6347, 0x32CD32, 0x1E90FF, 0xFFD700 });  // Red, Green, Blue, Yellow

        // Add title (optional)
        chart.addTitle ("Custom Pie Chart", "Arial", 14);

        // Generate the chart as a PNG image
        byte[] chartImage = chart.makeChart2 (Chart.PNG);

        // Return the image as a response (MIME type: image/png)
        return File (chartImage, "image/png");
    }
}

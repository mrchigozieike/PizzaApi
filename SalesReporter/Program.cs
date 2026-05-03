using System.Text; // Provides the StringBuilder class for efficient string construction

// Define the folder that contains the sales .txt files
string salesFolder = "SalesData";

// Check if the folder exists before processing
if (!Directory.Exists(salesFolder))
{
    Console.WriteLine($"Folder '{salesFolder}' not found.");
    return; // Exit the program if folder is missing
}

// Get all .txt files inside the sales folder
string[] salesFiles = Directory.GetFiles(salesFolder, "*.txt");

// Create a StringBuilder to build the summary report
var summary = new StringBuilder();

// Variable to store total sales across all files
decimal totalSales = 0;

// List to store each file's name and its total sales
var fileTotals = new List<(string FileName, decimal Total)>();

// Loop through each sales file
foreach (var filePath in salesFiles)
{
    // Extract just the file name (without full path)
    string fileName = Path.GetFileName(filePath);

    decimal fileTotal = 0;

    // Read all lines from the current file
    var lines = File.ReadAllLines(filePath);
    
    // Loop through each line in the file
    foreach (string line in lines)
    {
        // Try to convert the line into a decimal (sales amount)
        if (decimal.TryParse(line, out decimal amount))
            fileTotal += amount; // Add valid numbers to file total
    }
    
    // Add file total to overall total
    totalSales += fileTotal;

    // Store the result for this file
    fileTotals.Add((fileName, fileTotal));
}

// Build the summary report content
summary.AppendLine("Sales Summary");
summary.AppendLine("----------------------------");

// Format total sales as currency
summary.AppendLine($"Total Sales: {totalSales:C}");

summary.AppendLine();
summary.AppendLine("Details:");

// Add each file's sales details to the report
foreach (var item in fileTotals)
{
    summary.AppendLine($"  {item.FileName}: {item.Total:C}");
}

// Define the output file path for the report
string reportPath = "SalesSummaryReport.txt";

// Write the report content to the file
File.WriteAllText(reportPath, summary.ToString());

// Display confirmation and report content in the console
Console.WriteLine($"Report saved to {reportPath}");
Console.WriteLine(summary.ToString());
using OfficeOpenXml;

string path = @"D:\RPO\table.xlsx";
FileInfo fileInfo = new FileInfo(path);

ExcelPackage package = new ExcelPackage(fileInfo);
ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

int rows = worksheet.Dimension.Rows;
int columns = worksheet.Dimension.Columns;

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= columns; j++)
    {

        string content = worksheet.Cells[i, j].Value.ToString();
        Console.Write($"{content}\t");
    }
    Console.WriteLine();
}
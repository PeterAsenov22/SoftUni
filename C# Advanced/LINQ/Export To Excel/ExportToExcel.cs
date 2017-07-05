namespace Export_To_Excel
{
    using System;
    using System.IO;
    using System.Linq;
    using OfficeOpenXml;

    public class ExportToExcel
    {
        public static void Main()
        {
            var xlsPackage = new ExcelPackage();
            var worksheet = xlsPackage.Workbook.Worksheets.Add("Sample");

            using (var reader = new StreamReader("../../StudentData.txt"))
            {
                var line = reader.ReadLine();
                var row = 1;
                while (line!=null)
                {
                    var columns = line.Split(new []{' ','\t'},StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                   
                    for (int i = 1; i <= columns.Length; i++)
                    {
                        worksheet.Cells[row, i].Value = columns[i-1];
                    }

                    row++;
                    line = reader.ReadLine();
                }
            }

            var output = new FileStream("../../sample.xlsx", FileMode.Create);
            xlsPackage.SaveAs(output);
        }
    }
}

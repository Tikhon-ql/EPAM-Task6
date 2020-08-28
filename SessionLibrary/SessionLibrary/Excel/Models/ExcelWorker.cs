using OfficeOpenXml;
using SessionLibrary.Excel.DataClasses;
using SessionLibrary.Excel.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.Models
{
    public class ExcelWorker : IExcelWorker
    {
        public void Write(string filename, ICollection<GroupResult> collection)
        {
            using(ExcelPackage package = new ExcelPackage())
            {
                package.Workbook.Properties.Title = "Session results";
                package.Workbook.Properties.Created = DateTime.Now;
                string[] headers = { "Surname", "Name", "Midle name", "Date", "Subject", "Work's type", "Result" };
                foreach(GroupResult item in collection)
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(item.GroupName);
                    for(int i = 1; i <= headers.Length;i++)
                    {
                        worksheet.Cells[1, i].Value = headers[--i];
                    }
                    for(int i = 0;i < item.StudentResults.Count; i++)
                    {
                        worksheet.Cells[i, 1].Value = item.StudentResults.ToList()[i].StudentSurname;
                        worksheet.Cells[i, 2].Value = item.StudentResults.ToList()[i].StudentName;
                        worksheet.Cells[i, 3].Value = item.StudentResults.ToList()[i].StudentMidleName;
                        worksheet.Cells[i, 4].Value = item.StudentResults.ToList()[i].Date;
                        worksheet.Cells[i, 5].Value = item.StudentResults.ToList()[i].Subject;
                        worksheet.Cells[i, 6].Value = item.StudentResults.ToList()[i].WorkType;
                        worksheet.Cells[i, 7].Value = item.StudentResults.ToList()[i].Result;
                        worksheet.Dispose();
                    }
                }
                FileInfo fi = new FileInfo(filename);
                package.SaveAs(fi);
            }
        }
    }
}

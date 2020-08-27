using SessionLibrary.Excel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary.Excel.Models
{
    public class ExcelWorker : IExcelWorker
    {
        public void Write<T>(string filename, T object)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SessionLibrary.Excel.Interfaces
{
    interface IExcelWorker
    {
        void Write<T>(string filename,ICollection<T> collection);
    }
}

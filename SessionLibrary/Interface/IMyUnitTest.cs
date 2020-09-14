using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    
    public interface IMyUnitTest<T>
    {
        void CreateTestMethod(T student);
        void ReadTestMethod();
        void DeleteTestMethod(int id);
        void UpdateTestMethod(T student);
        void GetAllTestMethod();
    }
}

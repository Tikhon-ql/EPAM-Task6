using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Interface
{
    public interface IDao<T>
    {
        void Create(T value);
        T Read(int id);
        void Delete(int id);
        void Update(T value);
    }
}

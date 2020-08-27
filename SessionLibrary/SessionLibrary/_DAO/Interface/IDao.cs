using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Interface
{
    public interface IDao<T>
    {
        bool Create(T value);
        T Read(int id);
        bool Delete(int id);
        bool Update(T value);
        ICollection<T> GetAll();
    }
}

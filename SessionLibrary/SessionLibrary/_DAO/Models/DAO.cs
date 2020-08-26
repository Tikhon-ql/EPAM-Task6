
using SessionLibrary._DAO.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace SessionLibrary._DAO.Models
{
    public class Dao<T>:IDao<T>
    {
        SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
        public Dao(SqlConnectionStringBuilder builder)
        {
            stringBuilder = builder;
        }
        public void Create(T value)
        {
            using (SqlConnection cnn = new SqlConnection())
            {
                cnn.ConnectionString = stringBuilder.ConnectionString;
                Type type = value.GetType();
                PropertyInfo[] infos = type.GetProperties();
                SqlCommand command = new SqlCommand();
                command.Connection = cnn;
                string values = "";
                string columns = "";
                foreach (PropertyInfo item in infos)
                {
                    command.Parameters.AddWithValue("@" + item.Name, item.GetValue(value));
                    if (columns != "")
                        columns = "," + item.Name;
                    else
                        columns += item.Name;
                    if (values != "")
                        values += ",@" + item.Name;
                    else
                        values += "@" + item.Name;
                }
                command.CommandText = "insert into @table (" + columns + ")" + "values(" + values + ")";
                cnn.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection cnn = new SqlConnection())
            {
                cnn.ConnectionString = stringBuilder.ConnectionString;
                Type type = typeof(T);
                SqlCommand command = new SqlCommand("delete from @table where Id = @id",cnn);
                command.Parameters.AddWithValue("@id",id);
                command.Parameters.AddWithValue("@table",type.Name);
                command.ExecuteNonQuery();
            }
        }

        public T Read(int id)
        {
            using(SqlConnection cnn = new SqlConnection())
            {
                cnn.ConnectionString = stringBuilder.ConnectionString;
                Type type = typeof(T);
                PropertyInfo[] infos = type.GetProperties();
                SqlCommand command = new SqlCommand("select * from @table where Id = @id", cnn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@table", type.Name);
                dynamic value = null;
                using(SqlDataReader sdr = command.ExecuteReader())
                {
                    sdr.Read();
                    foreach (PropertyInfo item in infos)
                    {
                        item.SetValue(value,sdr[item.Name]);
                    }
                }
                return value;
            }
        }

        public void Update(T value)
        {
            using(SqlConnection cnn = new SqlConnection())
            {
                
            }
        }
    }
}

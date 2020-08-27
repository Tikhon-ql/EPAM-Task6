
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
                cnn.Open();
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
                cnn.Open();
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
                cnn.ConnectionString = stringBuilder.ConnectionString;
                Type type = typeof(T);
                PropertyInfo[] infos = type.GetProperties();
                SqlCommand command = new SqlCommand();
                command.Connection = cnn;
                PropertyInfo id = type.GetProperty("Id");
                string setters = "";
                foreach(PropertyInfo item in infos)
                {
                    if (setters != "")
                        setters += ", " + item.Name + " = " + item.GetValue(value).ToString();
                    else
                        setters += item.Name + " = " + item.GetValue(value).ToString();
                }
                command.Parameters.AddWithValue("@table",type.Name);
                command.Parameters.AddWithValue("@id",id.GetValue(value));
                command.CommandText = $"update @table set {setters} where Id = @id";
                cnn.Open();
                command.ExecuteNonQuery();
            }
        }
        public ICollection<T> GetAll()
        {
            using (SqlConnection cnn = new SqlConnection())
            {
                ICollection<T> list = new List<T>();
                cnn.ConnectionString = stringBuilder.ConnectionString;
                Type type = typeof(T);
                PropertyInfo[] infos = type.GetProperties();
                SqlCommand command = new SqlCommand("select * from @table", cnn);
                command.Parameters.AddWithValue("@table", type.Name);
                cnn.Open();
                dynamic value = null;
                using (SqlDataReader sdr = command.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        foreach (PropertyInfo item in infos)
                        {
                            item.SetValue(value, sdr[item.Name]);
                        }
                        list.Add(value);
                    }
                }
                return list;
            }
        }
    }
}

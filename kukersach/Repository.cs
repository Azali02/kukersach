using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kukersach
{
    internal class Repository
    {
        // Метод для получения всех данных из указанной таблицы и отображения их в таблице DataGridView
        public void allTable(string table, DataGridView dataGrid) //имя таблицы и место отбражения
        {
            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT * FROM " + table;
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            dataGrid.DataSource = dataTable;

            db.CloseConnection();
        }

        // Метод для получения данных с фильтром по одному столбцу и отображения их в таблице DataGridView
        public void oneСondition(string req, dynamic value, string table, DataGridView dataGrid) //столбец, его условие, имя таблицы и место отбражения
        {
            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT * FROM " + table + " WHERE " + req + " = @value";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@value", value);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;

            db.CloseConnection();
        }

        // Метод для получения данных с фильтром по двум столбцам и отображения их в таблице DataGridView
        public void notAllWithFilter(string condition, string req1, dynamic value1, string req2, dynamic value2, string table, DataGridView dataGrid) //отобрающие столбцы, столбец, его условие, имя таблицы и место отбражения
        {
            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT " + condition + " FROM " + table + " WHERE " + req1 + " = @value1 AND " + req2 + " = @value2";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@value1", value1);
            command.Parameters.AddWithValue("@value2", value2);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;

            db.CloseConnection();
        }

        // Метод для получения данных с фильтром по одному столбцу и отображения только указанных столбцов в таблице DataGridView
        public void notAllWithFilter(string condition, string req, dynamic value, string table, DataGridView dataGrid) //отобрающие столбцы, столбец, его условие, имя таблицы и место отбражения
        {
            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT " + condition + " FROM " + table + " WHERE " + req + " = @value";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@value", value);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;

            db.CloseConnection();
        }

        // Метод для заполнения ComboBox данными из указанной таблицы и указанного столбца
        public void fill_cb(string req, string table, List<string> requests, ComboBox cb) //столбец, имя таблицы, лист для заполнения, место отображения
        {
            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT DISTINCT " + req + " FROM " + table;
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection()); //выводим только один столбец
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                requests.Add(reader.GetString(0)); //построчно вписываем значения в список
            }
            reader.Close();

            cb.Items.Clear(); //очищаем прошлые записи комбоБокса
            foreach (string request in requests) //заполняем комбоБокс
            {
                cb.Items.Add(request);
            }

            db.CloseConnection();
        }

        // Метод для вставки данных в указанную таблицу
        public void insertInto(string req1, dynamic value1, string req2, dynamic value2, string req3, dynamic value3, string req4, dynamic value4, string table) //столбец, его значение, ..., имя таблицы
        {
            DB db = new DB();
            db.OpenConnection();

            string sql = "INSERT INTO " + table + " (" + req1 + ", " + req2 + ", " + req3 + ", " + req4 + ") VALUES (@value1, @value2, @value3, @value4)";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@value1", value1);
            command.Parameters.AddWithValue("@value2", value2);
            command.Parameters.AddWithValue("@value3", value3);
            command.Parameters.AddWithValue("@value4", value4);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            db.CloseConnection();
        }

        // Метод для обновления данных в указанной таблице по двум столбцам
        public void updete(string req, string req1, dynamic value1, string req2, dynamic value2, string table)
        {
            DB db = new DB();
            db.OpenConnection();

            string sql = "UPDATE " + table + " SET " + req + " = 0 WHERE " + req1 + " = @value1 AND " + req2 + " = @value2";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@value1", value1);
            command.Parameters.AddWithValue("@value2", value2);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            db.CloseConnection();
        }

        // Метод для обновления данных в указанной таблице по одному столбцу
        public void updete(dynamic value1, string sql)
        {
            DB db = new DB();
            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@value", value1);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            db.CloseConnection();
        }

    }
}

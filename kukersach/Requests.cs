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
    internal class Requests
    {
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
        //public void notAllTable_fillWithCB(string condition, string req, dynamic value, string table, ) //отобрающие столбцы, столбец, его условие, имя таблицы и место отбражения
        //{
        //    DB db = new DB();
        //    db.OpenConnection();

        //    string sql = "SELECT " + condition + " FROM " + table + " WHERE " + req + " = @value";
        //    MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
        //    command.Parameters.AddWithValue("@value", value);

        //    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //    DataTable dataTable = new DataTable();
        //    adapter.Fill(dataTable);
        //    dataGrid.DataSource = dataTable;

        //    db.CloseConnection();
        //}

        public void insertInto(string req1, dynamic value1, string req2, dynamic value2, string req3, dynamic value3, string req4, dynamic value4, string table) //столбец, его значение, ..., имя таблицы
        {
            DB _db = new DB();
            _db.OpenConnection();

            string sql = "INSERT INTO " + table + " (" + req1 + ", " + req2 + ", " + req3 + ", " + req4 + ") VALUES (@value1, @value2, @value3, @value4)";
            MySqlCommand command = new MySqlCommand(sql, _db.GetConnection());
            command.Parameters.AddWithValue("@value1", value1);
            command.Parameters.AddWithValue("@value2", value2);
            command.Parameters.AddWithValue("@value3", value3);
            command.Parameters.AddWithValue("@value4", value4);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            _db.CloseConnection();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void oneСondition(string req, string value, string table, DataGridView dataGrid) //столбец, его условие, имя таблицы и место отбражения
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
    }
}

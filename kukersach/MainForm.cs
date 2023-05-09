﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kukersach
{
    public partial class MainForm : Form
    {
        Point lastPoint;
        Requests requests = new Requests();
        string s = "all_flights";

        public MainForm()
        {
            InitializeComponent();
            FormUtils.CenterFormOnScreen(this);
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void panel_moved_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel_moved_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)
        {
            Close_btn.BackColor = Color.FromArgb(179, 117, 128);
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            Close_btn.BackColor = panel_moved.BackColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            requests.allTable(s, dataGridView);
            string sReq = "arrival";
            List<string> arrivals = new List<string>();
            requests.fill_cb(sReq, s, arrivals, cb_arrival);


            //DB db = new DB();
            //db.OpenConnection();

            ////выводим всю таблицу
            //string sql1 = "SELECT * FROM all_flights";
            //MySqlCommand command1 = new MySqlCommand(sql1, db.GetConnection());
            //MySqlDataReader reader1 = command1.ExecuteReader();

            //DataTable dataTable1 = new DataTable();
            //dataTable1.Load(reader1);
            //reader1.Close();
            //dataGridView.DataSource = dataTable1;

            ////заполняем список comboBox для пункта прибытия
            //string sql2 = "SELECT DISTINCT arrival FROM all_flights";
            //MySqlCommand command2 = new MySqlCommand(sql2, db.GetConnection());
            //MySqlDataReader reader2 = command2.ExecuteReader();

            //List<string> arrivals = new List<string>();
            //while (reader2.Read())
            //{
            //    arrivals.Add(reader2.GetString(0));
            //}
            //reader2.Close();
            
            //cb_arrival.Items.Clear();
            //foreach (string arrival in arrivals)
            //{
            //    cb_arrival.Items.Add(arrival);
            //}

            //db.CloseConnection();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string sReq = "date_f";
            string val = dateTimePicker.Value.ToString("yyyy-MM-dd");
            requests.oneСondition(sReq, val, s, dataGridView);

            //DB db = new DB();
            //db.OpenConnection();

            
            //string sql = "SELECT * FROM `all_flights` WHERE `date_f` = @search_date";
            //MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            //command.Parameters.Add("@search_date", MySqlDbType.Date).Value = search_date;
            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //dataGridView.DataSource = dataTable;

            //db.CloseConnection();
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            requests.allTable(s, dataGridView);

            //DB db = new DB();
            //db.OpenConnection();

            //string sql = "SELECT * FROM `all_flights`";
            //MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            //MySqlDataReader reader = command.ExecuteReader();

            //DataTable dataTable = new DataTable();
            //dataTable.Load(reader);

            //dataGridView.DataSource = dataTable;

            //reader.Close();
            //db.CloseConnection();
        }

        private void cb_arrival_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sReq = "arrival";
            string val = cb_arrival.SelectedItem.ToString();
            requests.oneСondition(sReq, val, s, dataGridView);

            //DB db = new DB();
            //db.OpenConnection();

            //string search_string = cb_arrival.SelectedItem.ToString();
            //string sql = "SELECT * FROM all_flights WHERE arrival = @search_string";
            //MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            //command.Parameters.AddWithValue("@search_string", search_string);
            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //dataGridView.DataSource = dataTable;

            //db.CloseConnection();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id"].Value);
                string departure = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["departure"].Value);
                string arrival = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["arrival"].Value);
                string time = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["time_dep"].Value);

                string name_f = departure + " - " + arrival + "  " + time;

                Hide();
                PlacesForm placesForm = new PlacesForm(selectedId, name_f);
                placesForm.Show();
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, rowIndex);
                dataGridView_CellClick(dataGridView, args);
            }
        }
    }
}

using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kukersach
{
    public partial class PlacesForm : Form
    {
        Point lastPoint;
        Requests requests = new Requests();
        string s = "flight";
        string s_people = "people";
        int id;
        List<string> documents = new List<string>();
        string name = "";
        DateTime birth;
        string doc = "";
        int b = 0;
        bool k = false;

        public PlacesForm(int selectedId, string name_f)
        {
            InitializeComponent();
            FormUtils.CenterFormOnScreen(this);
            id = selectedId;
            label1.Text = "Места на рейс: " + name_f;
        }
        private void PlacesForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT `place`, `freedom` FROM `flight` WHERE id_flight = @id AND `freedom` = 1 ORDER BY `flight`.`place` ASC";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);



            string sReq = "document";
            requests.fill_cb(sReq, s_people, documents, cb_doc);

            ////заполняем список comboBox паспортных данных
            //string sql2 = "SELECT DISTINCT `document` FROM `people`";
            //MySqlCommand command2 = new MySqlCommand(sql2, db.GetConnection());
            //MySqlDataReader reader2 = command2.ExecuteReader();

            //documents = new List<string>();
            //while (reader2.Read())
            //{
            //    documents.Add(reader2.GetString(0));
            //}
            //reader2.Close();
            //cb_doc.Items.Clear();
            //foreach (string document in documents)
            //{
            //    cb_doc.Items.Add(document);
            //}
            dataGridView.DataSource = dataTable;
            db.CloseConnection();
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

        private void Back_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Back_btn.BackColor = Color.FromArgb(114, 181, 172);
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back_btn.BackColor = panel_moved.BackColor;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "freedom")
            {
                object value = e.Value;
                if (value != null && value is int)
                {
                    int freedomValue = (int)value;
                    if (freedomValue == 1)
                        e.CellStyle.BackColor = Color.FromArgb(64, 200, 27);
                    else
                        e.CellStyle.BackColor = Color.FromArgb(200, 60, 27);
                }
            }
        }

        private void dataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            //if (e.ScrollOrientation == ScrollOrientation.VerticalScroll && e.Type == ScrollEventType.SmallIncrement && dataGridView.Rows.Count > 0)
            //{
            //    int lastIndex = dataGridView.Rows.Count - 1;
            //    if (dataGridView.FirstDisplayedScrollingRowIndex != -1 && dataGridView.FirstDisplayedScrollingRowIndex >= lastIndex)
            //    {
            //        // Отключить прокрутку вниз
            //        dataGridView.ScrollBars = ScrollBars.Vertical;
            //    }
            //    else
            //    {
            //        // Включить прокрутку вниз
            //        dataGridView.ScrollBars = ScrollBars.Both;
            //    }
            //}
        }

        private void btn_Freedom_Click(object sender, EventArgs e)
        {
            k = true;
            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT `place`, `freedom` FROM `flight` WHERE id_flight = @id AND `freedom` = 1 ORDER BY `flight`.`place` ASC";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
            db.CloseConnection();
            dataGridView.ClearSelection();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int freedom = Convert.ToInt32(dataGridView.CurrentRow.Cells["freedom"].Value);
            if (e.RowIndex >= 0 && freedom == 1)
            {
                k = true;
                int place = Convert.ToInt32(dataGridView.CurrentRow.Cells["place"].Value);
                DB db = new DB();
                db.OpenConnection();

                string sql = "SELECT `place`, `freedom` FROM `flight` WHERE id_flight = @id AND `place` = @place ORDER BY `flight`.`place` ASC";
                MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@place", place);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
                db.CloseConnection();
                dataGridView.ClearSelection();
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            k = false;
            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT `place`, `freedom` FROM `flight` WHERE id_flight = @id ORDER BY `flight`.`place` ASC";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@id", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
            db.CloseConnection();
            dataGridView.ClearSelection();
        }

        private void cb_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = null;
            birth = DateTime.Now;
            doc = cb_doc.Text.ToString();

            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT full_name, birth FROM people WHERE document = @doc";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@doc", doc);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                name = dataTable.Rows[0]["full_name"].ToString();
                birth = Convert.ToDateTime(dataTable.Rows[0]["birth"]);
            }
            db.CloseConnection();

            if (documents.Contains(doc))
            {
                tb_name.Text = name;
                dateTimePicker.Value = birth;
                tb_name.ReadOnly = true;
                dateTimePicker.Enabled = false;
            }
        }

        private void cb_doc_TextChanged(object sender, EventArgs e)
        {
            tb_name.ReadOnly = false;
            dateTimePicker.Enabled = true;
            tb_name.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (!k)
            {
                MessageBox.Show("Выберете место");
            }
            else if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(cb_doc.Text))
            {
                MessageBox.Show("Заполните данные о пассажире");
            }
            else
            {
                if (!documents.Contains(doc))
                {
                    if (chB_exemption.Checked)
                        b = 1;
                    else
                        b = 0;
                    name = tb_name.Text;
                    birth = dateTimePicker.Value;
                    doc = cb_doc.Text;
                    string birthDateString = birth.ToString("yyyy-MM-dd");

                    DB _db = new DB();
                    _db.OpenConnection();

                    string sql = "INSERT INTO `people` (`full_name`, `document`, `birth`, `exemption`) VALUES (@name, @doc, @birth, @b)";
                    MySqlCommand command = new MySqlCommand(sql, _db.GetConnection());
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@doc", doc);
                    command.Parameters.AddWithValue("@birth", birthDateString);
                    command.Parameters.AddWithValue("@b", b);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    _db.CloseConnection();
                }

                int place = Convert.ToInt32(dataGridView.Rows[0].Cells["place"].Value);
                DB db = new DB();
                db.OpenConnection();

                string sql1 = "UPDATE all_flights SET free_places = free_places - 1 WHERE id = @id";
                MySqlCommand command1 = new MySqlCommand(sql1, db.GetConnection());
                command1.Parameters.AddWithValue("@id", id);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                DataTable dataTable1 = new DataTable();
                adapter1.Fill(dataTable1);

                string sql2 = "UPDATE flight SET freedom = 0 WHERE id_flight = @id AND place = @place";
                MySqlCommand command2 = new MySqlCommand(sql2, db.GetConnection());
                command2.Parameters.AddWithValue("@id", id);
                command2.Parameters.AddWithValue("@place", place);
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(command2);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);

                db.CloseConnection();

                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}

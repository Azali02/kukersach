using MySql.Data.MySqlClient;
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
        Point lastPoint; // точка для хранения последней позиции мыши перед перетаскиванием формы
        Repository requests = new Repository(); // экземпляр класса Requests для работы с запросами к базе данных
        string s = "all_flights"; // имя таблицы в базе данных

        public MainForm()
        {
            InitializeComponent();
            FormUtils.CenterFormOnScreen(this); // центрируем форму на экране при запуске
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // закрываем приложение при нажатии на кнопку "Закрыть"
        }

        private void panel_moved_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // сохраняем текущую позицию мыши при нажатии на панель для перетаскивания формы
        }

        private void panel_moved_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // если нажата левая кнопка мыши
            {
                Left += e.X - lastPoint.X; // изменяем положение формы по горизонтали на разницу между текущей и сохраненной позицией мыши по горизонтали
                Top += e.Y - lastPoint.Y; // изменяем положение формы по вертикали на разницу между текущей и сохраненной позицией мыши по вертикали
            }
        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)
        {
            Close_btn.BackColor = Color.FromArgb(179, 117, 128); // изменяем цвет кнопки "Закрыть" при наведении на нее мышью
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            Close_btn.BackColor = panel_moved.BackColor; // возвращаем цвет кнопки "Закрыть" к исходному при уходе мыши с нее
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            requests.allTable(s, dataGridView); // загружаем все данные из таблицы в dataGridView при загрузке формы

            string sReq = "arrival";
            List<string> arrivals = new List<string>();
            requests.fill_cb(sReq, s, arrivals, cb_arrival); // заполняем ComboBox со списком городов при загрузке формы
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string sReq = "date_f";
            string val = dateTimePicker.Value.ToString("yyyy-MM-dd");
            requests.oneСondition(sReq, val, s, dataGridView); // отображаем данные в dataGridView согласно выбранной дате в dateTimePicker
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            requests.allTable(s, dataGridView); // отображаем все данные из таблицы в dataGridView при нажатии на кнопку "Показать все"
        }

        private void cb_arrival_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sReq = "arrival";
            string val = cb_arrival.SelectedItem.ToString();
            requests.oneСondition(sReq, val, s, dataGridView); // отображаем данные в dataGridView согласно выбранному городу в ComboBox
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // если была выбрана какая-то строка в dataGridView
            {
                int selectedId = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["id"].Value); // получаем id выбранной строки
                string departure = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["departure"].Value); // получаем город отправления выбранной строки
                string arrival = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["arrival"].Value); // получаем город прибытия выбранной строки
                string time = Convert.ToString(dataGridView.Rows[e.RowIndex].Cells["time_dep"].Value); // получаем время отправления выбранной строки

                string name_f = departure + " - " + arrival + "  " + time; // создаем строку с названием выбранного рейса

                Hide(); // скрываем текущую форму
                PlacesForm placesForm = new PlacesForm(selectedId, name_f); // создаем новую форму с доступными местами для выбранного рейса
                placesForm.Show(); // отображаем новую форму
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0) // если была выбрана какая-то строка в dataGridView
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, rowIndex);
                dataGridView_CellClick(dataGridView, args); // открываем форму с доступными местами для выбранного рейса при нажатии на кнопку "Открыть"
            }
        }
    }
}

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
        Point lastPoint; // определяем переменную для хранения последней позиции курсора мыши
        Repository requests = new Repository(); // создаем экземпляр класса Requests для выполнения запросов к базе данных
        string s = "flight"; // задаем имя таблицы flights
        string condition = "`place`, `freedom`"; // задаем условие для фильтрации данных при запросе (используется в методе notAllWithFilter класса Requests)
        string req = "id_flight"; // задаем имя столбца таблицы, который будет использоваться для фильтрации данных при запросе (используется в методе notAllWithFilter класса Requests)
        string s_people = "people"; // задаем имя таблицы people
        int id; // определяем переменную для хранения идентификатора выбранного рейса
        List<string> documents = new List<string>(); // создаем список для хранения документов пассажиров
        string name = ""; // определяем переменную для хранения имени пассажира
        DateTime birth; // определяем переменную для хранения даты рождения пассажира
        string doc = ""; // определяем переменную для хранения номера документа пассажира
        int b = 0; // определяем переменную для хранения информации об освобождении пассажира от оплаты (1 - освобожден, 0 - не освобожден)
        bool k = false; // определяем флаг для отслеживания выбора опции "Только свободные места" или конкретного места

        public PlacesForm(int selectedId, string name_f)
        {
            InitializeComponent();
            FormUtils.CenterFormOnScreen(this); // центрируем форму на экране при запуске
            id = selectedId; // сохраняем идентификатор выбранного элемента
            label1.Text = "Места на рейс: " + name_f; // устанавливаем текст заголовка формы
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

        private void Back_Click(object sender, EventArgs e)
        {
            Hide(); // скрываем текущую форму
            MainForm mainForm = new MainForm(); // создаем новый экземпляр главной формы
            mainForm.Show(); // отображаем новую главную форму
        }

        private void Back_MouseEnter(object sender, EventArgs e)
        {
            Back_btn.BackColor = Color.FromArgb(114, 181, 172); // изменяем цвет кнопки "Назад" при наведении на нее мышью
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Back_btn.BackColor = panel_moved.BackColor; // возвращаем цвет кнопки "Назад" к исходному при уходе мыши с нее
        }

        private void PlacesForm_Load(object sender, EventArgs e)
        {
            string req2 = "`freedom`"; // задаем имя столбца таблицы, который будет использоваться для фильтрации данных
            requests.notAllWithFilter(condition, req, id, req2, 1, s, dataGridView); // запрашиваем данные из таблицы и загружаем их в dataGridView

            string sReq = "document"; // задаем имя столбца таблицы, который содержит список документов
            requests.fill_cb(sReq, s_people, documents, cb_doc); // заполняем ComboBox со списком документов

            dataGridView.ClearSelection(); // очищаем выделение ячеек в таблице
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "freedom") // если текущая ячейка относится к столбцу "freedom"
            {
                object value = e.Value; // получаем значение ячейки
                if (value != null && value is int)
                {
                    int freedomValue = (int)value; // преобразуем значение ячейки к целочисленному типу
                    if (freedomValue == 1) // если значение равно 1
                        e.CellStyle.BackColor = Color.FromArgb(64, 200, 27); // устанавливаем зеленый цвет фона ячейки
                    else // в противном случае
                        e.CellStyle.BackColor = Color.FromArgb(200, 60, 27); // устанавливаем красный цвет фона ячейки
                }
            }
        }

        private void btn_Freedom_Click(object sender, EventArgs e)
        {
            k = true; // установка флага, что выбрана опция "Только свободные места"
            string req2 = "`freedom`"; // задаем имя столбца таблицы, который будет использоваться для фильтрации данных
            requests.notAllWithFilter(condition, req, id, req2, 1, s, dataGridView); // запрашиваем данные из таблицы и загружаем только свободные места в dataGridView

            dataGridView.ClearSelection(); // очищаем выделение ячеек в таблице
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int freedom = Convert.ToInt32(dataGridView.CurrentRow.Cells["freedom"].Value); // получаем значение столбца "freedom" для текущей выбранной ячейки
            if (e.RowIndex >= 0 && freedom == 1) // если выбранная ячейка не является заголовком таблицы и значение столбца "freedom" равно 1 (т.е. место свободно)
            {
                k = true; // установка флага, что выбрано конкретное место
                int place = Convert.ToInt32(dataGridView.CurrentRow.Cells["place"].Value); // получаем номер места для текущей выбранной ячейки
                string req2 = "`place`"; // задаем имя столбца таблицы, который будет использоваться для фильтрации данных
                requests.notAllWithFilter(condition, req, id, req2, place, s, dataGridView); // запрашиваем данные из таблицы и загружаем информацию о конкретном месте в dataGridView

                dataGridView.ClearSelection(); // очищаем выделение ячеек в таблице
            }
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            k = false; // установка флага, что выбрана опция "Показать все места"
            requests.notAllWithFilter(condition, req, id, s, dataGridView); // запрашиваем и загружаем все места в dataGridView

            dataGridView.ClearSelection(); // очищаем выделение ячеек в таблице
        }

        private void cb_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = "";
            birth = DateTime.Now;
            doc = cb_doc.Text.ToString(); // получаем выбранный документ из ComboBox

            DB db = new DB();
            db.OpenConnection();

            string sql = "SELECT full_name, birth FROM people WHERE document = @doc";
            MySqlCommand command = new MySqlCommand(sql, db.GetConnection());
            command.Parameters.AddWithValue("@doc", doc);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            name = Convert.ToString(dataTable.Rows[0]["full_name"]); // получаем имя пассажира из таблицы people
            birth = Convert.ToDateTime(dataTable.Rows[0]["birth"]); // получаем дату рождения пассажира из таблицы people

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
            doc = cb_doc.Text.ToString();
            tb_name.ReadOnly = false;
            dateTimePicker.Enabled = true;
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            name = "";
            birth = DateTime.Now;
            if (!k)
            {
                MessageBox.Show("Выберете место"); // выводим сообщение об ошибке, если не выбрано место
            }
            else if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(cb_doc.Text))
            {
                MessageBox.Show("Заполните данные о пассажире"); // выводим сообщение об ошибке, если не заполнены данные о пассажире
            }
            else
            {
                if (!documents.Contains(doc))
                {
                    if (chB_exemption.Checked)
                    {
                        b = 1;
                    }
                    else
                    {
                        b = 0;
                    }
                    name = tb_name.Text;
                    birth = dateTimePicker.Value;
                    doc = cb_doc.Text;
                    string birthDateString = birth.ToString("yyyy-MM-dd");

                    string req1 = "full_name";
                    string req2 = "document";
                    string req3 = "birth";
                    string req4 = "exemption";
                    requests.insertInto(req1, name, req2, doc, req3, birthDateString, req4, b, s_people); // добавляем данные о новом пассажире в таблицу people
                }

                int place = Convert.ToInt32(dataGridView.Rows[0].Cells["place"].Value); // получаем номер места для выбранной ячейки в dataGridView
                string req_f = "freedom";
                string req_2 = "place";

                requests.updete(req_f, req, id, req_2, place, s); // обновляем информацию о выбранном месте в таблице flights

                string sql = "UPDATE all_flights SET free_places = free_places - 1 WHERE id = @value";
                requests.updete(id, sql); // обновляем информацию о количестве свободных мест в таблице flights

                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}

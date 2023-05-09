using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kukersach
{
    public partial class LoginForm : Form
    {
        Point lastPoint; // определяем переменную для хранения последней позиции курсора мыши

        public LoginForm()
        {
            InitializeComponent();
            FormUtils.CenterFormOnScreen(this); // центрируем форму по центру экрана
        }

        private void CloseClick_Click(object sender, EventArgs e)
        {
            Application.Exit(); // закрываем приложение при нажатии на крестик
        }

        private void panel_moved_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // сохраняем текущую позицию курсора мыши при нажатии на панель с заголовком формы
        }

        private void panel_moved_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // если зажата левая кнопка мыши
            {
                Left += e.X - lastPoint.X; // перемещаем форму по горизонтали
                Top += e.Y - lastPoint.Y; // перемещаем форму по вертикали
            }
        }

        private void Close_btn_MouseEnter(object sender, EventArgs e)
        {
            Close_btn.BackColor = Color.FromArgb(179, 117, 128); // при наведении на кнопку закрытия меняем ее цвет на светло-красный
        }

        private void Close_btn_MouseLeave(object sender, EventArgs e)
        {
            Close_btn.BackColor = panel_moved.BackColor; // при уходе курсора мыши с кнопки закрытия возвращаем ее цвет на цвет панели с заголовком формы
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            // получаем логин и пароль пользователя
            string loginUser = text_login.Text;
            string passwordUser = text_pass.Text;

            DB dB = new DB(); // создаем экземпляр класса DB для взаимодействия с базой данных
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", dB.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) // если найдена хотя бы одна запись в таблице users соответствующая введенному логину и паролю
            {
                Hide(); // скрываем текущую форму
                MainForm mainForm = new MainForm(); // создаем экземпляр класса MainForm
                mainForm.Show(); // отображаем форму MainForm
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!"); // выводим сообщение об ошибке при неверном логине или пароле
            }
        }


    }
}

namespace kukersach
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainPenal = new Panel();
            btn_Log = new Button();
            text_pass = new TextBox();
            text_login = new TextBox();
            picture_pass = new PictureBox();
            picture_login = new PictureBox();
            panel2 = new Panel();
            panel_moved = new Panel();
            Close_btn = new Label();
            label1 = new Label();
            MainPenal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_pass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_login).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPenal
            // 
            MainPenal.BackColor = Color.FromArgb(114, 181, 172);
            MainPenal.Controls.Add(btn_Log);
            MainPenal.Controls.Add(text_pass);
            MainPenal.Controls.Add(text_login);
            MainPenal.Controls.Add(picture_pass);
            MainPenal.Controls.Add(picture_login);
            MainPenal.Controls.Add(panel2);
            MainPenal.Dock = DockStyle.Fill;
            MainPenal.Location = new Point(0, 0);
            MainPenal.Name = "MainPenal";
            MainPenal.Size = new Size(400, 450);
            MainPenal.TabIndex = 0;
            // 
            // btn_Log
            // 
            btn_Log.AutoSize = true;
            btn_Log.Cursor = Cursors.Hand;
            btn_Log.FlatAppearance.BorderColor = Color.FromArgb(89, 137, 128);
            btn_Log.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 137, 128);
            btn_Log.FlatStyle = FlatStyle.Flat;
            btn_Log.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Log.ForeColor = Color.FromArgb(34, 51, 48);
            btn_Log.Location = new Point(158, 334);
            btn_Log.Name = "btn_Log";
            btn_Log.Size = new Size(96, 46);
            btn_Log.TabIndex = 5;
            btn_Log.Text = "Войти";
            btn_Log.UseVisualStyleBackColor = true;
            btn_Log.Click += btn_Log_Click;
            // 
            // text_pass
            // 
            text_pass.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_pass.Location = new Point(145, 220);
            text_pass.Name = "text_pass";
            text_pass.Size = new Size(153, 30);
            text_pass.TabIndex = 4;
            text_pass.Text = "123";
            text_pass.UseSystemPasswordChar = true;
            // 
            // text_login
            // 
            text_login.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(145, 182);
            text_login.Name = "text_login";
            text_login.Size = new Size(153, 30);
            text_login.TabIndex = 3;
            text_login.Text = "admin";
            // 
            // picture_pass
            // 
            picture_pass.Image = Properties.Resources._lock;
            picture_pass.Location = new Point(107, 220);
            picture_pass.Name = "picture_pass";
            picture_pass.Size = new Size(32, 32);
            picture_pass.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_pass.TabIndex = 2;
            picture_pass.TabStop = false;
            // 
            // picture_login
            // 
            picture_login.Image = Properties.Resources.user;
            picture_login.Location = new Point(107, 182);
            picture_login.Name = "picture_login";
            picture_login.Size = new Size(32, 32);
            picture_login.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_login.TabIndex = 1;
            picture_login.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(138, 114, 181);
            panel2.Controls.Add(panel_moved);
            panel2.Controls.Add(Close_btn);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 98);
            panel2.TabIndex = 0;
            // 
            // panel_moved
            // 
            panel_moved.BackColor = Color.FromArgb(104, 89, 136);
            panel_moved.Dock = DockStyle.Top;
            panel_moved.Location = new Point(0, 0);
            panel_moved.Name = "panel_moved";
            panel_moved.Size = new Size(372, 32);
            panel_moved.TabIndex = 6;
            panel_moved.MouseDown += panel_moved_MouseDown;
            panel_moved.MouseMove += panel_moved_MouseMove;
            // 
            // Close_btn
            // 
            Close_btn.AutoSize = true;
            Close_btn.BackColor = Color.FromArgb(104, 89, 136);
            Close_btn.Cursor = Cursors.Hand;
            Close_btn.Dock = DockStyle.Right;
            Close_btn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Close_btn.ForeColor = Color.FromArgb(40, 34, 53);
            Close_btn.Location = new Point(372, 0);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(28, 32);
            Close_btn.TabIndex = 1;
            Close_btn.Text = "х";
            Close_btn.Click += CloseClick_Click;
            Close_btn.MouseEnter += Close_btn_MouseEnter;
            Close_btn.MouseLeave += Close_btn_MouseLeave;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(40, 34, 53);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(400, 98);
            label1.TabIndex = 0;
            label1.Text = "Войдите в систему";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(MainPenal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            MainPenal.ResumeLayout(false);
            MainPenal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_pass).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_login).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPenal;
        private Panel panel2;
        private Label label1;
        private Label Close_btn;
        private Button btn_Log;
        private TextBox text_pass;
        private TextBox text_login;
        private PictureBox picture_pass;
        private PictureBox picture_login;
        private Panel panel_moved;
    }
}
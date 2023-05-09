namespace kukersach
{
    partial class PlacesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            MainPenal = new Panel();
            btn_Buy = new Button();
            tb_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            chB_exemption = new CheckBox();
            dateTimePicker = new DateTimePicker();
            cb_doc = new ComboBox();
            btn_ShowAll = new Button();
            btn_Freedom = new Button();
            dataGridView = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel_moved = new Panel();
            Back_btn = new Label();
            Close_btn = new Label();
            MainPenal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            panel_moved.SuspendLayout();
            SuspendLayout();
            // 
            // MainPenal
            // 
            MainPenal.BackColor = Color.FromArgb(114, 181, 172);
            MainPenal.Controls.Add(btn_Buy);
            MainPenal.Controls.Add(tb_name);
            MainPenal.Controls.Add(label4);
            MainPenal.Controls.Add(label3);
            MainPenal.Controls.Add(label2);
            MainPenal.Controls.Add(chB_exemption);
            MainPenal.Controls.Add(dateTimePicker);
            MainPenal.Controls.Add(cb_doc);
            MainPenal.Controls.Add(btn_ShowAll);
            MainPenal.Controls.Add(btn_Freedom);
            MainPenal.Controls.Add(dataGridView);
            MainPenal.Controls.Add(panel2);
            MainPenal.Dock = DockStyle.Fill;
            MainPenal.Location = new Point(0, 0);
            MainPenal.Name = "MainPenal";
            MainPenal.Size = new Size(900, 500);
            MainPenal.TabIndex = 2;
            // 
            // btn_Buy
            // 
            btn_Buy.AutoSize = true;
            btn_Buy.Cursor = Cursors.Hand;
            btn_Buy.FlatAppearance.BorderColor = Color.FromArgb(89, 137, 128);
            btn_Buy.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 137, 128);
            btn_Buy.FlatStyle = FlatStyle.Flat;
            btn_Buy.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Buy.ForeColor = Color.FromArgb(34, 51, 48);
            btn_Buy.Location = new Point(559, 240);
            btn_Buy.Name = "btn_Buy";
            btn_Buy.Size = new Size(269, 37);
            btn_Buy.TabIndex = 26;
            btn_Buy.Text = "Купить";
            btn_Buy.UseVisualStyleBackColor = true;
            btn_Buy.Click += btn_Buy_Click;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(585, 138);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(303, 27);
            tb_name.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(34, 51, 48);
            label4.Location = new Point(517, 171);
            label4.Name = "label4";
            label4.Size = new Size(162, 28);
            label4.TabIndex = 24;
            label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(34, 51, 48);
            label3.Location = new Point(517, 138);
            label3.Name = "label3";
            label3.Size = new Size(62, 28);
            label3.TabIndex = 23;
            label3.Text = "ФИО:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(34, 51, 48);
            label2.Location = new Point(517, 104);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 22;
            label2.Text = "Паспорт:";
            // 
            // chB_exemption
            // 
            chB_exemption.AutoSize = true;
            chB_exemption.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chB_exemption.ForeColor = Color.FromArgb(34, 51, 48);
            chB_exemption.Location = new Point(517, 202);
            chB_exemption.Name = "chB_exemption";
            chB_exemption.RightToLeft = RightToLeft.Yes;
            chB_exemption.Size = new Size(105, 32);
            chB_exemption.TabIndex = 21;
            chB_exemption.Text = ":Льгота";
            chB_exemption.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(685, 172);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(203, 27);
            dateTimePicker.TabIndex = 20;
            // 
            // cb_doc
            // 
            cb_doc.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_doc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_doc.FormattingEnabled = true;
            cb_doc.Location = new Point(624, 104);
            cb_doc.Name = "cb_doc";
            cb_doc.Size = new Size(120, 28);
            cb_doc.TabIndex = 18;
            cb_doc.SelectedIndexChanged += cb_doc_SelectedIndexChanged;
            cb_doc.TextChanged += cb_doc_TextChanged;
            // 
            // btn_ShowAll
            // 
            btn_ShowAll.AutoSize = true;
            btn_ShowAll.Cursor = Cursors.Hand;
            btn_ShowAll.FlatAppearance.BorderColor = Color.FromArgb(89, 137, 128);
            btn_ShowAll.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 137, 128);
            btn_ShowAll.FlatStyle = FlatStyle.Flat;
            btn_ShowAll.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ShowAll.ForeColor = Color.FromArgb(34, 51, 48);
            btn_ShowAll.Location = new Point(12, 190);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(269, 37);
            btn_ShowAll.TabIndex = 17;
            btn_ShowAll.Text = "Все места";
            btn_ShowAll.UseVisualStyleBackColor = true;
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // btn_Freedom
            // 
            btn_Freedom.AutoSize = true;
            btn_Freedom.Cursor = Cursors.Hand;
            btn_Freedom.FlatAppearance.BorderColor = Color.FromArgb(89, 137, 128);
            btn_Freedom.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 137, 128);
            btn_Freedom.FlatStyle = FlatStyle.Flat;
            btn_Freedom.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Freedom.ForeColor = Color.FromArgb(34, 51, 48);
            btn_Freedom.Location = new Point(12, 104);
            btn_Freedom.Name = "btn_Freedom";
            btn_Freedom.Size = new Size(269, 37);
            btn_Freedom.TabIndex = 15;
            btn_Freedom.Text = "Отобразить свободные места";
            btn_Freedom.UseVisualStyleBackColor = true;
            btn_Freedom.Click += btn_Freedom_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(114, 181, 172);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(89, 137, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(89, 137, 128);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(287, 98);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(224, 402);
            dataGridView.TabIndex = 2;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(138, 114, 181);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel_moved);
            panel2.Controls.Add(Close_btn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 98);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(40, 34, 53);
            label1.Location = new Point(0, 32);
            label1.Name = "label1";
            label1.Size = new Size(872, 66);
            label1.TabIndex = 8;
            label1.Text = "   Места: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_moved
            // 
            panel_moved.BackColor = Color.FromArgb(104, 89, 136);
            panel_moved.Controls.Add(Back_btn);
            panel_moved.Dock = DockStyle.Top;
            panel_moved.Location = new Point(0, 0);
            panel_moved.Name = "panel_moved";
            panel_moved.Size = new Size(872, 32);
            panel_moved.TabIndex = 6;
            panel_moved.MouseDown += panel_moved_MouseDown;
            panel_moved.MouseMove += panel_moved_MouseMove;
            // 
            // Back_btn
            // 
            Back_btn.AutoSize = true;
            Back_btn.BackColor = Color.FromArgb(104, 89, 136);
            Back_btn.Cursor = Cursors.Hand;
            Back_btn.Dock = DockStyle.Left;
            Back_btn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Back_btn.ForeColor = Color.FromArgb(40, 34, 53);
            Back_btn.Location = new Point(0, 0);
            Back_btn.Name = "Back_btn";
            Back_btn.Size = new Size(35, 32);
            Back_btn.TabIndex = 2;
            Back_btn.Text = "←";
            Back_btn.Click += Back_Click;
            Back_btn.MouseEnter += Back_MouseEnter;
            Back_btn.MouseLeave += Back_MouseLeave;
            // 
            // Close_btn
            // 
            Close_btn.AutoSize = true;
            Close_btn.BackColor = Color.FromArgb(104, 89, 136);
            Close_btn.Cursor = Cursors.Hand;
            Close_btn.Dock = DockStyle.Right;
            Close_btn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Close_btn.ForeColor = Color.FromArgb(40, 34, 53);
            Close_btn.Location = new Point(872, 0);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(28, 32);
            Close_btn.TabIndex = 1;
            Close_btn.Text = "х";
            Close_btn.Click += Close_btn_Click;
            Close_btn.MouseEnter += Close_btn_MouseEnter;
            Close_btn.MouseLeave += Close_btn_MouseLeave;
            // 
            // PlacesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 500);
            Controls.Add(MainPenal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlacesForm";
            Text = "FlightForm";
            Load += PlacesForm_Load;
            MainPenal.ResumeLayout(false);
            MainPenal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_moved.ResumeLayout(false);
            panel_moved.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPenal;
        private Panel panel2;
        private Panel panel_moved;
        private Label Close_btn;
        private DataGridView dataGridView;
        private Label label1;
        private Label Back_btn;
        private Button btn_Freedom;
        private Button btn_ShowAll;
        private ComboBox cb_doc;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox chB_exemption;
        private TextBox tb_name;
        private Button btn_Buy;
    }
}
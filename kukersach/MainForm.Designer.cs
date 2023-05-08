namespace kukersach
{
    partial class MainForm
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
            btn_Open = new Button();
            cb_arrival = new ComboBox();
            btn_ShowAll = new Button();
            dateTimePicker = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            dataGridView = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel_moved = new Panel();
            Close_btn = new Label();
            MainPenal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPenal
            // 
            MainPenal.BackColor = Color.FromArgb(114, 181, 172);
            MainPenal.Controls.Add(btn_Open);
            MainPenal.Controls.Add(cb_arrival);
            MainPenal.Controls.Add(btn_ShowAll);
            MainPenal.Controls.Add(dateTimePicker);
            MainPenal.Controls.Add(label3);
            MainPenal.Controls.Add(label2);
            MainPenal.Controls.Add(dataGridView);
            MainPenal.Controls.Add(panel2);
            MainPenal.Dock = DockStyle.Fill;
            MainPenal.Location = new Point(0, 0);
            MainPenal.Name = "MainPenal";
            MainPenal.Size = new Size(850, 500);
            MainPenal.TabIndex = 1;
            // 
            // btn_Open
            // 
            btn_Open.AutoSize = true;
            btn_Open.Cursor = Cursors.Hand;
            btn_Open.FlatAppearance.BorderColor = Color.FromArgb(89, 137, 128);
            btn_Open.FlatAppearance.MouseDownBackColor = Color.FromArgb(89, 137, 128);
            btn_Open.FlatStyle = FlatStyle.Flat;
            btn_Open.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Open.ForeColor = Color.FromArgb(34, 51, 48);
            btn_Open.Location = new Point(606, 430);
            btn_Open.Name = "btn_Open";
            btn_Open.Size = new Size(113, 37);
            btn_Open.TabIndex = 14;
            btn_Open.Text = "Открыть";
            btn_Open.UseVisualStyleBackColor = true;
            btn_Open.Click += btn_Open_Click;
            // 
            // cb_arrival
            // 
            cb_arrival.AutoCompleteMode = AutoCompleteMode.Suggest;
            cb_arrival.AutoCompleteSource = AutoCompleteSource.ListItems;
            cb_arrival.FormattingEnabled = true;
            cb_arrival.Location = new Point(92, 432);
            cb_arrival.Name = "cb_arrival";
            cb_arrival.Size = new Size(179, 28);
            cb_arrival.TabIndex = 13;
            cb_arrival.SelectedIndexChanged += cb_arrival_SelectedIndexChanged;
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
            btn_ShowAll.Location = new Point(725, 430);
            btn_ShowAll.Name = "btn_ShowAll";
            btn_ShowAll.Size = new Size(113, 37);
            btn_ShowAll.TabIndex = 12;
            btn_ShowAll.Text = "Все рейсы";
            btn_ShowAll.UseVisualStyleBackColor = true;
            btn_ShowAll.Click += btn_ShowAll_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(92, 465);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(179, 27);
            dateTimePicker.TabIndex = 11;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(34, 51, 48);
            label3.Location = new Point(12, 460);
            label3.Name = "label3";
            label3.Size = new Size(74, 31);
            label3.TabIndex = 10;
            label3.Text = "Дата:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(34, 51, 48);
            label2.Location = new Point(12, 427);
            label2.Name = "label2";
            label2.Size = new Size(74, 31);
            label2.TabIndex = 8;
            label2.Text = "Куда:";
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(114, 181, 172);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(89, 137, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(89, 137, 128);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(89, 137, 128);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Top;
            dataGridView.Location = new Point(0, 98);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(850, 326);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView_CellClick;
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
            panel2.Size = new Size(850, 98);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(40, 34, 53);
            label1.Location = new Point(0, 32);
            label1.Name = "label1";
            label1.Size = new Size(822, 66);
            label1.TabIndex = 7;
            label1.Text = "   Рейсы:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel_moved
            // 
            panel_moved.BackColor = Color.FromArgb(104, 89, 136);
            panel_moved.Dock = DockStyle.Top;
            panel_moved.Location = new Point(0, 0);
            panel_moved.Name = "panel_moved";
            panel_moved.Size = new Size(822, 32);
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
            Close_btn.Location = new Point(822, 0);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(28, 32);
            Close_btn.TabIndex = 1;
            Close_btn.Text = "х";
            Close_btn.Click += Close_btn_Click;
            Close_btn.MouseEnter += Close_btn_MouseEnter;
            Close_btn.MouseLeave += Close_btn_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 500);
            Controls.Add(MainPenal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            MainPenal.ResumeLayout(false);
            MainPenal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPenal;
        private Panel panel2;
        private Panel panel_moved;
        private Label Close_btn;
        private DataGridView dataGridView;
        private DateTimePicker dateTimePicker;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_ShowAll;
        private ComboBox cb_arrival;
        private Button btn_Open;
    }
}
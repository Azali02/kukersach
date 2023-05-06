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
            MainPenal = new Panel();
            panel2 = new Panel();
            panel_moved = new Panel();
            Close_btn = new Label();
            MainPenal.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // MainPenal
            // 
            MainPenal.BackColor = Color.FromArgb(114, 181, 172);
            MainPenal.Controls.Add(panel2);
            MainPenal.Dock = DockStyle.Fill;
            MainPenal.Location = new Point(0, 0);
            MainPenal.Name = "MainPenal";
            MainPenal.Size = new Size(800, 450);
            MainPenal.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(138, 114, 181);
            panel2.Controls.Add(panel_moved);
            panel2.Controls.Add(Close_btn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 98);
            panel2.TabIndex = 0;
            // 
            // panel_moved
            // 
            panel_moved.BackColor = Color.FromArgb(104, 89, 136);
            panel_moved.Dock = DockStyle.Top;
            panel_moved.Location = new Point(0, 0);
            panel_moved.Name = "panel_moved";
            panel_moved.Size = new Size(772, 32);
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
            Close_btn.Location = new Point(772, 0);
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
            ClientSize = new Size(800, 450);
            Controls.Add(MainPenal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            MainPenal.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPenal;
        private Panel panel2;
        private Panel panel_moved;
        private Label Close_btn;
    }
}
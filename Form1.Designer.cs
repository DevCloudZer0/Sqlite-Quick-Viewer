namespace SqliteQuickViewer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            lblFileMessage = new Label();
            comboTables = new ComboBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            label8 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(639, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(297, 46);
            label2.TabIndex = 2;
            label2.Text = "Sqlite Quick Viewer";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(11, 50);
            label1.Name = "label1";
            label1.Size = new Size(139, 30);
            label1.TabIndex = 3;
            label1.Text = "Version 2024.1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 163);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(14, 124);
            label4.Name = "label4";
            label4.Size = new Size(850, 2);
            label4.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(12, 142);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 6;
            button1.Text = "Load Sqlite File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblFileMessage
            // 
            lblFileMessage.Location = new Point(133, 142);
            lblFileMessage.Name = "lblFileMessage";
            lblFileMessage.Size = new Size(731, 23);
            lblFileMessage.TabIndex = 7;
            lblFileMessage.Visible = false;
            // 
            // comboTables
            // 
            comboTables.FormattingEnabled = true;
            comboTables.Location = new Point(14, 171);
            comboTables.Name = "comboTables";
            comboTables.Size = new Size(603, 23);
            comboTables.TabIndex = 8;
            comboTables.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(852, 440);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(628, 171);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 10;
            button2.Text = "View Table";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(11, 653);
            label5.Name = "label5";
            label5.Size = new Size(850, 2);
            label5.TabIndex = 11;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(14, 661);
            label6.Name = "label6";
            label6.Size = new Size(204, 30);
            label6.TabIndex = 12;
            label6.Text = "Developed by:  CloudZer0 ";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(11, 76);
            label7.Name = "label7";
            label7.Size = new Size(616, 31);
            label7.TabIndex = 13;
            label7.Text = "Checks if a file is a valid Sqlite database file. View and Exports data.";
            // 
            // button3
            // 
            button3.Location = new Point(749, 170);
            button3.Name = "button3";
            button3.Size = new Size(115, 23);
            button3.TabIndex = 14;
            button3.Text = "Export CSV";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(713, 667);
            label8.Name = "label8";
            label8.Size = new Size(143, 15);
            label8.TabIndex = 15;
            label8.Text = "About, License and Usage";
            toolTip1.SetToolTip(label8, resources.GetString("label8.ToolTip"));
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 707);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(comboTables);
            Controls.Add(lblFileMessage);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Sqlite Quick Viewer ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label lblFileMessage;
        private ComboBox comboTables;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
        private Label label8;
        private ToolTip toolTip1;
    }
}

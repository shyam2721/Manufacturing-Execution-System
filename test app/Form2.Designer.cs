using System.Windows.Forms;

namespace test_app
{
    partial class Form2
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            btnSave = new Button();
            cmbstatus = new ComboBox();
            dtpDOJ = new DateTimePicker();
            cmbstream = new ComboBox();
            txtStudentName = new TextBox();
            txtStudentId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 2);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6236553F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80.37634F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 380F));
            tableLayoutPanel2.Size = new Size(1182, 753);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 375);
            panel3.Name = "panel3";
            panel3.Size = new Size(1176, 375);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(cmbstatus);
            panel2.Controls.Add(dtpDOJ);
            panel2.Controls.Add(cmbstream);
            panel2.Controls.Add(txtStudentName);
            panel2.Controls.Add(txtStudentId);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(1176, 293);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(470, 256);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SpringGreen;
            btnSave.Location = new Point(370, 256);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbstatus.Location = new Point(352, 201);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(151, 28);
            cmbstatus.TabIndex = 9;
            cmbstatus.Text = "-Select-";
            // 
            // dtpDOJ
            // 
            dtpDOJ.Format = DateTimePickerFormat.Custom;
            dtpDOJ.Location = new Point(352, 157);
            dtpDOJ.Name = "dtpDOJ";
            dtpDOJ.Size = new Size(151, 27);
            dtpDOJ.TabIndex = 8;
            // 
            // cmbstream
            // 
            cmbstream.FormattingEnabled = true;
            cmbstream.Items.AddRange(new object[] { "Computer Science and Engineering", "Mechanical Engineering", "Electrical Engineering", "Electronics Engineering" });
            cmbstream.Location = new Point(352, 116);
            cmbstream.Name = "cmbstream";
            cmbstream.Size = new Size(445, 28);
            cmbstream.TabIndex = 7;
            cmbstream.Text = "-Select-";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(352, 76);
            txtStudentName.MaxLength = 30;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(445, 27);
            txtStudentName.TabIndex = 6;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(352, 36);
            txtStudentId.MaxLength = 8;
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(125, 27);
            txtStudentId.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(241, 204);
            label6.Name = "label6";
            label6.Size = new Size(63, 23);
            label6.TabIndex = 4;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(178, 157);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 3;
            label5.Text = "Date Of Joining";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 119);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 2;
            label4.Text = "Stream";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(186, 76);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 1;
            label3.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(213, 36);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Text = "Student Id";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(537, 17);
            label1.Name = "label1";
            label1.Size = new Size(224, 37);
            label1.TabIndex = 0;
            label1.Text = "Student Master";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1176, 375);
            dataGridView1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(tableLayoutPanel2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "my first app";
            Load += Form2_Load;
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpDOJ;
        private ComboBox cmbstream;
        private TextBox txtStudentName;
        private TextBox txtStudentId;
        private Button btnSave;
        private ComboBox cmbstatus;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
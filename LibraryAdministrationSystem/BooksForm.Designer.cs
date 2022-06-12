namespace LibraryAdministrationSystem
{
    partial class BooksForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.BookTypeCodeTextBox = new System.Windows.Forms.TextBox();
            this.ISBNTextBox = new System.Windows.Forms.TextBox();
            this.WriterSurnameTextBox = new System.Windows.Forms.TextBox();
            this.writerNameTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.borrowButton = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BorrowDatePicker = new System.Windows.Forms.DateTimePicker();
            this.borrowerTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.penaltyFeeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.borrowButton.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Controls.Add(this.BookTypeCodeTextBox);
            this.groupBox1.Controls.Add(this.ISBNTextBox);
            this.groupBox1.Controls.Add(this.WriterSurnameTextBox);
            this.groupBox1.Controls.Add(this.writerNameTextBox);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(248, 237);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Book";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(142, 237);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(86, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update Book";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // BookTypeCodeTextBox
            // 
            this.BookTypeCodeTextBox.Location = new System.Drawing.Point(142, 180);
            this.BookTypeCodeTextBox.Name = "BookTypeCodeTextBox";
            this.BookTypeCodeTextBox.Size = new System.Drawing.Size(194, 23);
            this.BookTypeCodeTextBox.TabIndex = 10;
            // 
            // ISBNTextBox
            // 
            this.ISBNTextBox.Location = new System.Drawing.Point(142, 147);
            this.ISBNTextBox.Name = "ISBNTextBox";
            this.ISBNTextBox.Size = new System.Drawing.Size(194, 23);
            this.ISBNTextBox.TabIndex = 9;
            // 
            // WriterSurnameTextBox
            // 
            this.WriterSurnameTextBox.Location = new System.Drawing.Point(142, 109);
            this.WriterSurnameTextBox.Name = "WriterSurnameTextBox";
            this.WriterSurnameTextBox.Size = new System.Drawing.Size(326, 23);
            this.WriterSurnameTextBox.TabIndex = 8;
            // 
            // writerNameTextBox
            // 
            this.writerNameTextBox.Location = new System.Drawing.Point(142, 74);
            this.writerNameTextBox.Name = "writerNameTextBox";
            this.writerNameTextBox.Size = new System.Drawing.Size(326, 23);
            this.writerNameTextBox.TabIndex = 7;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(142, 39);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(326, 23);
            this.bookNameTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Book ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Book Type Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Writer Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Writer Name:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(125, 217);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(12, 15);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name:";
            // 
            // borrowButton
            // 
            this.borrowButton.Controls.Add(this.button1);
            this.borrowButton.Controls.Add(this.BorrowDatePicker);
            this.borrowButton.Controls.Add(this.borrowerTextBox);
            this.borrowButton.Controls.Add(this.label9);
            this.borrowButton.Controls.Add(this.label8);
            this.borrowButton.Location = new System.Drawing.Point(492, 12);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(426, 266);
            this.borrowButton.TabIndex = 1;
            this.borrowButton.TabStop = false;
            this.borrowButton.Text = "Book Borrow";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Borrow Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrowDatePicker
            // 
            this.BorrowDatePicker.Location = new System.Drawing.Point(82, 82);
            this.BorrowDatePicker.Name = "BorrowDatePicker";
            this.BorrowDatePicker.Size = new System.Drawing.Size(207, 23);
            this.BorrowDatePicker.TabIndex = 8;
            // 
            // borrowerTextBox
            // 
            this.borrowerTextBox.Location = new System.Drawing.Point(82, 39);
            this.borrowerTextBox.Name = "borrowerTextBox";
            this.borrowerTextBox.Size = new System.Drawing.Size(207, 23);
            this.borrowerTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Borrower:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.returnButton);
            this.groupBox3.Controls.Add(this.penaltyFeeLabel);
            this.groupBox3.Controls.Add(this.calculateButton);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(924, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(6, 237);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(238, 23);
            this.returnButton.TabIndex = 7;
            this.returnButton.Text = "Book Return";
            this.returnButton.UseVisualStyleBackColor = true;
            // 
            // penaltyFeeLabel
            // 
            this.penaltyFeeLabel.AutoSize = true;
            this.penaltyFeeLabel.Location = new System.Drawing.Point(91, 42);
            this.penaltyFeeLabel.Name = "penaltyFeeLabel";
            this.penaltyFeeLabel.Size = new System.Drawing.Size(13, 15);
            this.penaltyFeeLabel.TabIndex = 6;
            this.penaltyFeeLabel.Text = "0";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(91, 82);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(88, 45);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate Penalty Fee";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "Penalty Fee:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 284);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1162, 299);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1186, 595);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "BooksForm";
            this.Text = "Book Administration System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BooksForm_FormClosed);
            this.Load += new System.EventHandler(this.BooksForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.borrowButton.ResumeLayout(false);
            this.borrowButton.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button addButton;
        private Button updateButton;
        private TextBox BookTypeCodeTextBox;
        private TextBox ISBNTextBox;
        private TextBox WriterSurnameTextBox;
        private TextBox writerNameTextBox;
        private TextBox bookNameTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelID;
        private Label label1;
        private GroupBox borrowButton;
        private DateTimePicker BorrowDatePicker;
        private TextBox borrowerTextBox;
        private Label label9;
        private Label label8;
        private GroupBox groupBox3;
        private Label penaltyFeeLabel;
        private Button calculateButton;
        private Label label10;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button returnButton;
        private Button button1;
    }
}
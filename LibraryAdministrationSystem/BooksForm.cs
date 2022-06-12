using LibraryAdministrationSystem.Services;
using System.Data;
using System.Data.SqlClient;

namespace LibraryAdministrationSystem
{
    public partial class BooksForm : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbLibrary;Integrated Security=True");

        DbController dbController = new DbController();

        public BooksForm()
        {
            InitializeComponent();
        }

        private void getBooksAndShow()
        {
            string query = "SELECT * FROM Books";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dataTable;
            }
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            getBooksAndShow();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dbController.addBook(bookNameTextBox.Text,
                                 writerNameTextBox.Text,
                                 WriterSurnameTextBox.Text,
                                 ISBNTextBox.Text,
                                 "True",
                                 BookTypeCodeTextBox.Text
                                 );

            getBooksAndShow();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            penaltyFeeLabel.Text = "0";

            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            labelID.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            bookNameTextBox.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            writerNameTextBox.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            WriterSurnameTextBox.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
            ISBNTextBox.Text = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
            BookTypeCodeTextBox.Text = dataGridView1.Rows[selectedRow].Cells[8].Value.ToString();
            borrowerTextBox.Text = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();

            if (dataGridView1.Rows[selectedRow].Cells[7].Value != DBNull.Value)
            {
                BorrowDatePicker.Value = (DateTime)dataGridView1.Rows[selectedRow].Cells[7].Value;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dbController.updateBook(labelID.Text, bookNameTextBox.Text, writerNameTextBox.Text, WriterSurnameTextBox.Text, ISBNTextBox.Text, BookTypeCodeTextBox.Text);


            getBooksAndShow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Books SET Borrower=@p1, BorrowDate=@p2, Status=@p3 WHERE ID = @p4", connection
                    );
                    cmd.Parameters.AddWithValue("@p1", borrowerTextBox.Text);
                    cmd.Parameters.Add("@p2", SqlDbType.Date).Value = BorrowDatePicker.Value.Date;
                    cmd.Parameters.AddWithValue("@p3", "False");
                    cmd.Parameters.AddWithValue("@p4", labelID.Text);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }

                getBooksAndShow();
            }
            else
            {
                MessageBox.Show("Please choose a book");
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime now = DateTime.Now;
                int dateDiff = (int)(now - BorrowDatePicker.Value.Date).TotalDays;
                if (dateDiff > 10)
                {
                    int penaltyFee = (dateDiff - 10) * 5;
                    penaltyFeeLabel.Text = penaltyFee.ToString();
                }
                else
                {

                }
            }
        }

        private void BooksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
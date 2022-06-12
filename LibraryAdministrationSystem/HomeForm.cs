using System.Data.SqlClient;

namespace LibraryAdministrationSystem
{
    public partial class HomeForm : Form
    {
        BooksForm booksForm;
        public HomeForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DbLibrary;Integrated Security=True");
        private void loginButton_Click(object sender, EventArgs e)
        {
            String password = "";

            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT Password FROM users WHERE userName = @p1", connection);
                sqlCommand.Parameters.AddWithValue("@p1", userNameTextBox.Text);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    password = reader[0].ToString();
                }

                if (password.Equals(passwordTextBox.Text))
                {
                    label3.Text = "Correct";

                    booksForm = new BooksForm();
                    this.Hide();
                    booksForm.Show();
                }
                else
                {
                    MessageBox.Show("False");
                    userNameTextBox.Text = "";
                    passwordTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
        }
    }
}
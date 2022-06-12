using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAdministrationSystem.Services
{
    internal class DbController
    {
        string dbString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DbLibrary;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(dbString);

        public DbController()
        {
        }

        public void addBook(string bookName, string writerName, string writerSurname, string isbn, string status, string bookTypeCode)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Books (BookName, WriterName, WriterSurname, ISBN, Status, BookTypeCode) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", connection
                );
                cmd.Parameters.AddWithValue("@p1", bookName);
                cmd.Parameters.AddWithValue("@p2", writerName);
                cmd.Parameters.AddWithValue("@p3", writerSurname);
                cmd.Parameters.AddWithValue("@p4", isbn);
                cmd.Parameters.AddWithValue("@p5", "True");
                cmd.Parameters.AddWithValue("@p6", bookTypeCode);

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
        }

        public void updateBook(string id,string bookName, string writerName, string writerSurname, string isbn, string bookTypeCode)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookName=@p1, WriterName=@p2, WriterSurname=@p3, ISBN=@p4, BookTypeCode=@p5 WHERE ID = @p6", connection
                );
                cmd.Parameters.AddWithValue("@p1", bookName);
                cmd.Parameters.AddWithValue("@p2", writerName);
                cmd.Parameters.AddWithValue("@p3", writerSurname);
                cmd.Parameters.AddWithValue("@p4", isbn);
                cmd.Parameters.AddWithValue("@p5", bookTypeCode);
                cmd.Parameters.AddWithValue("@p6", id);

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
        }
    }
}

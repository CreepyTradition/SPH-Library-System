using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class manageBooks : Form
    {

        public manageBooks()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DOJ7F78\\SQLEXPRESS01;Initial Catalog=librarySystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM bookTable", con);
            SqlDataAdapter bro = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            bro.Fill(dataTable);
            bookGrid.DataSource = dataTable;
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            LibrarySystem f2 = new LibrarySystem();
            f2.Show();
            Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(titleBox.Text) || string.IsNullOrWhiteSpace(authorBox.Text))
                {
                    MessageBox.Show("Please enter valid Title and Author.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-DOJ7F78\\SQLEXPRESS01;Initial Catalog=librarySystem;Integrated Security=True;Encrypt=False");
                    con.Open();

                    // Check if the book exists before deleting
                    SqlCommand existsCmd = new SqlCommand("SELECT COUNT(*) FROM bookTable WHERE Title=@Title AND Author=@Author AND Available=1", con);
                    existsCmd.Parameters.AddWithValue("@Title", titleBox.Text);
                    existsCmd.Parameters.AddWithValue("@Author", authorBox.Text);
                    int bookCount = (int)existsCmd.ExecuteScalar();

                    if (bookCount == 0)
                    {
                        MessageBox.Show("This book does not exist in the database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Delete the book
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM bookTable WHERE Title=@Title AND Author=@Author", con);
                    deleteCmd.Parameters.AddWithValue("@Title", titleBox.Text);
                    deleteCmd.Parameters.AddWithValue("@Author", authorBox.Text);
                    deleteCmd.ExecuteNonQuery();

                    con.Close();

                    titleBox.Text = "";
                    authorBox.Text = "";

                    UpdateBookGrid();

                    MessageBox.Show("Book deleted successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // User clicked "No" or closed the dialog
                // Do nothing or handle cancellation gracefully
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text) || string.IsNullOrWhiteSpace(authorBox.Text))
            {
                MessageBox.Show("Please enter valid Title and Author.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-DOJ7F78\\SQLEXPRESS01;Initial Catalog=librarySystem;Integrated Security=True;Encrypt=False");
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT into bookTable(Title, Author, Available, Borrower) VALUES(@Title, @Author, @Available, @Borrower)", con);
                cmd.Parameters.AddWithValue("@Title", titleBox.Text);
                cmd.Parameters.AddWithValue("@Author", authorBox.Text);
                cmd.Parameters.AddWithValue("@Borrower", "N/A");
                cmd.Parameters.AddWithValue("@Available", true);
                cmd.ExecuteNonQuery();
                con.Close();

                titleBox.Text = "";
                authorBox.Text = "";

                UpdateBookGrid();

                MessageBox.Show("Book added successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void manageBooks_Resize(object sender, EventArgs e)
        {

        }

        private void UpdateBookGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-DOJ7F78\\SQLEXPRESS01;Initial Catalog=librarySystem;Integrated Security=True;Encrypt=False");
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM bookTable", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                bookGrid.DataSource = dataTable;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the book grid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bookGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bookGrid.Rows[e.RowIndex];

                titleBox.Text = row.Cells["Title"].Value.ToString();
                authorBox.Text = row.Cells["Author"].Value.ToString();

            }
        }
    }
}

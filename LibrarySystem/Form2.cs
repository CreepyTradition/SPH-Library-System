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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;


namespace LibrarySystem
{
    public partial class borrowBooks : Form
    {
        SqlConnection con;
        //private Rectangle buttonOriginalRectangle;
        //private Rectangle originalFormSize;
        //private Rectangle theTableRectangle;

        public borrowBooks()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            LibrarySystem f2 = new LibrarySystem();
            f2.Show();
            Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DOJ7F78\\SQLEXPRESS01;Initial Catalog=librarySystem;Integrated Security=True;Encrypt=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM bookTable", con);
            SqlDataAdapter bro = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            bro.Fill(dataTable);
            bookGrid.DataSource = dataTable;
        }

        private void Form2_Resize(object sender, EventArgs e)
        {

        }

        private void bookTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text) || string.IsNullOrWhiteSpace(authorBox.Text) || string.IsNullOrWhiteSpace(borrowBox.Text))
            {
                MessageBox.Show("Please enter valid Title, Author, and borrower information.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-DOJ7F78\\SQLEXPRESS01;Initial Catalog=librarySystem;Integrated Security=True;Encrypt=False");
                con.Open();

                SqlCommand availabilityCmd = new SqlCommand("SELECT Available FROM bookTable WHERE Title=@Title AND Author=@Author", con);
                availabilityCmd.Parameters.AddWithValue("@Title", titleBox.Text);
                availabilityCmd.Parameters.AddWithValue("@Author", authorBox.Text);
                bool isAvailable = (bool)availabilityCmd.ExecuteScalar();

                if (!isAvailable)
                {
                    MessageBox.Show("This book is not available for borrowing.", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SqlCommand cmd = new SqlCommand("UPDATE bookTable SET Title=@Title, Author=@Author, Available=@Available, Borrower=@Borrower", con);
                cmd.Parameters.AddWithValue("@Title", titleBox.Text);
                cmd.Parameters.AddWithValue("@Author", authorBox.Text);
                cmd.Parameters.AddWithValue("@Borrower", borrowBox.Text);
                cmd.Parameters.AddWithValue("@Available", false);
                cmd.ExecuteNonQuery();
                con.Close();

                titleBox.Text = "";
                authorBox.Text = "";
                borrowBox.Text = "";

                UpdateBookGrid();

                MessageBox.Show("Book borrowed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleBox.Text) || string.IsNullOrWhiteSpace(authorBox.Text) || string.IsNullOrWhiteSpace(borrowBox.Text))
            {
                MessageBox.Show("Please enter valid Title, Author, and borrower information.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-DOJ7F78\\SQLEXPRESS01;Initial Catalog=librarySystem;Integrated Security=True;Encrypt=False");
                con.Open();

                // Check if the book is currently borrowed
                SqlCommand availabilityCmd = new SqlCommand("SELECT Available FROM bookTable WHERE Title=@Title AND Author=@Author AND Borrower=@Borrower", con);
                availabilityCmd.Parameters.AddWithValue("@Title", titleBox.Text);
                availabilityCmd.Parameters.AddWithValue("@Author", authorBox.Text);
                availabilityCmd.Parameters.AddWithValue("@Borrower", borrowBox.Text);
                bool isAvailable = (bool)availabilityCmd.ExecuteScalar();

                if (isAvailable)
                {
                    MessageBox.Show("This book is not currently borrowed.", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Update the book to mark it as available
                SqlCommand updateCmd = new SqlCommand("UPDATE bookTable SET Available=@Available, Borrower=@Borrower WHERE Title=@Title", con);
                updateCmd.Parameters.AddWithValue("@Title", titleBox.Text);
                updateCmd.Parameters.AddWithValue("@Available", true);
                updateCmd.Parameters.AddWithValue("@Borrower", "N/A");
                updateCmd.ExecuteNonQuery();

                con.Close();

                titleBox.Text = "";
                authorBox.Text = "";

                UpdateBookGrid();

                MessageBox.Show("Book returned successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // You can log the exception details or handle it as needed
            }
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
            if(e.RowIndex >=0)
            {
                DataGridViewRow row = this.bookGrid.Rows[e.RowIndex];

                titleBox.Text = row.Cells["Title"].Value.ToString();
                authorBox.Text = row.Cells["Author"].Value.ToString();

            }
        }
    }
}

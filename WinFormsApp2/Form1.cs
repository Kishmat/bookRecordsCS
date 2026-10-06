using System.Data;
using System.Data.OleDb;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\..\..\..\BookCSharp.accdb;";
        string selectedBookKey;
        string selectedTitle;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadBooks()
        {
            DataSet ds = new DataSet();

            string dbcommand = "SELECT BookKey, Title, Pages FROM Books;";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand comm = new OleDbCommand(dbcommand, conn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(comm))
            {
                adapter.Fill(ds);
            }

            listBox1.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBox1.Items.Add(
                    row["BookKey"] + "-" +
                    row["Title"] + "-" +
                    row["Pages"] + "-"
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void updateTitleName(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if(listBox != null && listBox.SelectedIndex != -1)
            {
                string selectedItemText = listBox.SelectedItem.ToString();
                string[] selectedItemParts = selectedItemText.Split('-');

                selectedBookKey = selectedItemParts[0];
                selectedTitle = selectedItemParts[1];
                textBox1.Text = selectedTitle;


            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string bookkey = textBox2.Text;
            string title = textBox3.Text;
            string pages = textBox4.Text;

            OleDbConnection oleDbConnection = new OleDbConnection(this.connectionString);
            string query = "INSERT INTO Books (BookKey, Title, Pages) VALUES (?,?,?)";


            OleDbCommand oleDbCommand = new OleDbCommand(query, oleDbConnection);
            oleDbCommand.Parameters.AddWithValue("@BookKey", bookkey);
            oleDbCommand.Parameters.AddWithValue("@Title", title);
            oleDbCommand.Parameters.AddWithValue("@Pages", pages);


            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();

            MessageBox.Show("Record Inserted Successfully");
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            LoadBooks();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string conn = "Data Source=.;Initial Catalog=Spotify;Integrated Security=True";

        private void Connection_Click(object sender, EventArgs e)
        {

            TestConnection();

        }

        private void Execution_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectAll() == true)

                // selectAll().GetType== true;    
                {
                    string[] files = openFileDialog.FileNames;

                    foreach (string file in files)
                    {
                        string sqlContent = File.ReadAllText(file);

                        using (SqlConnection connection = new SqlConnection(conn))
                        {
                            connection.Open();
                            SqlCommand command = connection.CreateCommand();
                            command.CommandText = sqlContent;
                            command.ExecuteNonQuery();
                            connection.Close();

                        }
                    }

                }
                else
                {
                    MessageBox.Show("You haven't selected the files  ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }



        public bool TestConnection()
        {

            try
            {

                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                MessageBox.Show("Database Connection Succesful");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return false;
        }



        private void UploadFiles_Click(object sender, EventArgs e)
        {


            openFileDialog.Multiselect = true;
            this.openFileDialog.Filter = "SQL | *.sql";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] files = openFileDialog.FileNames;

                foreach (string file in files)
                {

                    string filename = Path.Combine("Files", Path.GetFileName(file));
                    UpLoadFilesToDatabase(Path.GetFileName(file), filename);
                    checkedListBox1.Items.Add(file);
                }
            }

        }

        private void SelectAll_Click(object sender, EventArgs e)
        {

            selectAll();
        }

        public bool selectAll()
        {
            for (int i = 0; i< checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
            return true;
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {

            string[] files = openFileDialog.FileNames;

            foreach (string file in files)
            {
                string filename = Path.Combine("files", Path.GetFileName(file));
                DeleteFileFromDatabase(Path.GetFileName(file), filename);
                checkedListBox1.Items.Remove(file);
            }


        }
        public void UpLoadFilesToDatabase(string filename, string filepath)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                string query = "Insert into Files (filename, filepath) values (@filename,@filepath)";
                using (SqlCommand com = new SqlCommand(query, sqlConnection))
                {
                    com.Parameters.AddWithValue("@filename", filename);
                    com.Parameters.AddWithValue("@filepath", filepath);
                    com.ExecuteNonQuery();
                }

            }
        }




        private void DeleteFileFromDatabase(string fileName, string filepath)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();

                string query = "DELETE FROM Files";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@Filepath", filepath);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}

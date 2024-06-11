using Microsoft.Data.Sqlite;
using System.Data;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SqliteQuickViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static class Globals
        {
            // global int
            public static string dbFile = "";


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            List<string> list = new List<string>();
            List<string> list0 = new List<string>();
            List<string> list1 = new List<string>();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;

                string text = File.ReadAllText(file);
                size = text.Length;
                lblFileMessage.Visible = true;
                lblFileMessage.Text = file + " loaded.";
                Globals.dbFile = file;


                try
                {
                    using (var connection = new SqliteConnection("Data Source=" + file + ";Mode=ReadOnly"))
                    {
                        connection.Open();

                        var command = connection.CreateCommand();
                        // command.CommandText = @"SELECT name FROM birthday WHERE id = $id";
                        // command.Parameters.AddWithValue("$id", id);
                        command.CommandText = @"SELECT name FROM sqlite_schema WHERE type ='table' AND name NOT LIKE 'sqlite_%';";
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var name = reader.GetString(0);
                                list.Add(name);

                            }
                        }

                        lblFileMessage.Text = file + " is a valid Sqlite file. Please select a table below" + string.Join(",", list0);
                        comboTables.Visible = true;
                        comboTables.DataSource = list;
                        button2.Visible = true;
                        button3.Visible = true;

                        connection.Close();

                    }




                    // create a new database connection:








                }
                catch (Exception ex)
                {
                    lblFileMessage.Text = "Invalid File. " + ex.Message.ToString(); // ex.Message;
                }




            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

            string con = "Data Source=" + Globals.dbFile + ";Mode=ReadOnly";
            using (var connection = new SqliteConnection("Data Source=" + Globals.dbFile + ";Mode=ReadOnly"))
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "select * from " + comboTables.SelectedValue + ";";
                var sqliteAdapter = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqliteAdapter);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_save(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "data.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Error writing data to file :-( " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "data.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Error writing data to file :-( " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            // Choose whether to write header. Use EnableWithoutHeaderText instead to omit header.
                            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                            // Select all the cells
                            dataGridView1.SelectAll();
                            // Copy selected cells to DataObject
                            DataObject dataObject = dataGridView1.GetClipboardContent();
                            // Get the text of the DataObject, and serialize it to a file
                            File.WriteAllText(sfd.FileName, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}

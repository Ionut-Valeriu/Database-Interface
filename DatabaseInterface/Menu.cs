using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC.Multiplier;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DatabaseInterface
{
    public partial class Menu : Form
    {
        MySqlConnection con = new MySqlConnection("SERVER=localhost; DATABASE=proiectbd; UID=root; PASSWORD=123456;");
        List<String> tables = new List<string>();
        List<String> views = new List<string>();
        DataTable dataTable = new DataTable();
        MySqlDataAdapter adapter;
        int heightMultiplier = 50;
        int defaultWidth = 150;
        bool isSelectExpand = false;
        bool isViewExpand = false;

        public Menu()
        {
            InitializeComponent();
            con.Open();

            // tables
            string query = "select table_name from information_schema.tables where table_schema = 'proiectbd' and table_type = 'BASE TABLE'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tableName = reader.GetString(0);
                tables.Add(tableName);

                Item table = new Item(buttonSelect.BackColor);
                table.itemName(tableName);
                containerSelect.Controls.Add(table);
            }
            reader.Close();

            int defaultMaxHeight = heightMultiplier * (tables.Count + 1);
            containerSelect.MaximumSize = new Size(defaultWidth, defaultMaxHeight);

            // views
            query = "select table_name from information_schema.tables where table_schema = 'proiectbd' and table_type = 'VIEW';";
            cmd = new MySqlCommand(query, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string viewName = reader.GetString(0);
                views.Add(viewName);

                Item view = new Item(buttonViews.BackColor);
                view.itemName(viewName);
                containerViews.Controls.Add(view);
            }
            reader.Close();

            defaultMaxHeight = heightMultiplier * (views.Count + 1);
            containerViews.MaximumSize = new Size(defaultWidth, defaultMaxHeight);

            con.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            timerSelectDropDown.Start();
        }
        private void buttonFetch_Click(object sender, EventArgs e)
        {
            if (buttonSelect.Text == "SELECT") { return; }

            string query = "SELECT * FROM " + buttonSelect.Text;
            adapter = new MySqlDataAdapter(query, con);

            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

            dataTable.Clear();
            dataTable.Columns.Clear();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a row is selected
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.");
                    return;
                }

                if (buttonSelect.Text == "fabrici_modele")
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    string wmi = selectedRow.Cells["wmi"]?.Value?.ToString() ?? "";
                    string vds = selectedRow.Cells["vds"]?.Value?.ToString() ?? "";

                    con.Open();
                    //string query = "CALL delete_from_view('" + wmi + "', '" + vds + "');";
                    string query = "CALL delete_from_view(@wmi, @vds);";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@wmi", wmi);
                    cmd.Parameters.AddWithValue("@vds", vds);

                    cmd.ExecuteNonQuery();

                    con.Close();
                }
                else // is table
                {
                    // Get the selected row
                    DataRowView selectedRowView = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                    DataRow selectedRow = selectedRowView.Row;

                    // Mark the row as deleted in the DataTable
                    selectedRow.Delete();

                    MessageBox.Show("Row marked for deletion. Commit changes to apply.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while marking row for deletion: {ex.Message}");
            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No data to commit.");
                    return;
                }

                // Save changes from DataTable to the database
                adapter.Update(dataTable);
                MessageBox.Show("Changes committed to the database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while committing changes: " + ex.Message);
            }
        }

        private void buttonSQL_Click(object sender, EventArgs e)
        {
            SQLPage sqlPage = new SQLPage(con);
            sqlPage.Show();
        }

        private void buttonViews_Click(object sender, EventArgs e)
        {
            timerViewsDropDown.Start();
        }

        private void timerSelectDropDown_Tick(object sender, EventArgs e)
        {
            if (isSelectExpand == false)
            {
                containerSelect.Height += 10;
                if (containerSelect.Height >= containerSelect.MaximumSize.Height)
                {
                    isSelectExpand = true;
                    timerSelectDropDown.Stop();
                }
            }
            else
            {
                containerSelect.Height -= 10;
                if (containerSelect.Height <= containerSelect.MinimumSize.Height)
                {
                    isSelectExpand = false;
                    timerSelectDropDown.Stop();
                }
            }
        }

        private void timerViewsDropDown_Tick(object sender, EventArgs e)
        {
            if (isViewExpand == false)
            {
                containerViews.Height += 10;
                if (containerViews.Height >= containerViews.MaximumSize.Height)
                {
                    isViewExpand = true;
                    timerViewsDropDown.Stop();
                }
            }
            else
            {
                containerViews.Height -= 10;
                if (containerViews.Height <= containerViews.MinimumSize.Height)
                {
                    isViewExpand = false;
                    timerViewsDropDown.Stop();
                }
            }
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            if (Item.isSelected == true)
            {
                buttonSelect.Text = Item.valueSelected;

                //if (isSelectExpand) 
                    timerSelectDropDown.Start();
                if (isViewExpand) timerViewsDropDown.Start();

                Item.isSelected = false;
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseInterface
{
    public partial class SQLPage : Form
    {
        MySqlConnection con;

        public SQLPage(MySqlConnection otherCon)
        {
            InitializeComponent();
            con = otherCon;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            sqlTextBox.Text = "select f.wmi, m.vds, e.cod_motor, m.greutate, e.norma_poluare\n" +
                "from fabrici f left join modele m on (f.wmi = m.wmi)\n" +
                "left join motoare e on (m.wmi = e.wmi and m.vds = e.vds)\n" +
                "where m.greutate < 2000 and e.norma_poluare >= 'Euro4';";
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            sqlTextBox.Text = "select wmi, vds, count(cnp)\n" +
                "from aprecieri\n" +
                "group by wmi, vds\n" +
                "having count(cnp) > 3;";
        }

        private void buttonRunScript_Click(object sender, EventArgs e)
        {
            try
            {
                string query = sqlTextBox.Text;

                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("SQL query cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);
                sqlDataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

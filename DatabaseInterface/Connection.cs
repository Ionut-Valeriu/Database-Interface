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
    public partial class Connection : Form
    {
        public static string query = "SERVER=localhost; DATABASE=proiectbd; UID=root; PASSWORD=123456;";
        private static string server = "localhost";
        private static string db = "proiectbd";
        private static string uid = "root";
        private static string pass = "123456";

        public Connection()
        {
            InitializeComponent();
        }

        public static string getQuery()
        {
            return query;
        }

        private  void composeQuery()
        {
            server = ServerTextBox.Text;
            db = DatabaseTextBox.Text;
            uid = UidTextBox.Text;
            pass = PasswordTextBox.Text;
            query = "SERVER=" + server + "; DATABASE=" + db + "; UID=" + uid + "; PASSWORD=" + pass + ";";
        }

        private void buttonSERVER_Click(object sender, EventArgs e)
        {
            ServerTextBox.Text = server;
        }

        private void buttonDATABASE_Click(object sender, EventArgs e)
        {
            DatabaseTextBox.Text = db;
        }

        private void buttonUID_Click(object sender, EventArgs e)
        {
            UidTextBox.Text = uid;
        }

        private void buttonPASSWORD_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = pass;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            composeQuery();
            this.Close();
        }
    }
}

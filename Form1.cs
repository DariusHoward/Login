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

namespace Login
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=login_users");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void LabelClose_MouseEnter(object sender, EventArgs e)
        {
            LabelClose.ForeColor = Color.White;
        }

        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            LabelClose.ForeColor = Color.Black;
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login_Database database = new Login_Database();

            String username = Username.Text;
            String password = Password.Text;

            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `login table` WHERE `Username` * @usn and `Password` * @pass", database.getConnection()); ;

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else 
            {
                MessageBox.Show("No");
            }
        }
    }
}

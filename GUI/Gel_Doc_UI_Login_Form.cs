using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class Gel_Doc_UI_Login_Form : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd;
        public Gel_Doc_UI_Login_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "server=localhost; database=gel_documentation_system; user Id=root; password= ";
            cmd = con.CreateCommand();
            //cmd.CommandText = "select Name from login where Name ='" + userName.Text + "'";
            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT COUNT(*) FROM user_detail WHERE User_Name='" + userName.Text 
                + "' AND Passward='" + password.Text + "'", con);
            con.Open();

            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {                
                this.Hide();                
                Gel_Doc_UI_Main_Form frm = new Gel_Doc_UI_Main_Form();
                frm.Show();
            }
            else
                MessageBox.Show("Invalid Username or Password");             

            Console.ReadLine();
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void CancelFunction_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

       

        private void userName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                if (userName.Text == "")
                {
                    MessageBox.Show("Enter User Name ");
                    
                }

                else
                {
                    password.Focus();
                }
                
            }
        }

        private void Gel_Doc_UI_Login_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = userName;
        }

        private void password_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (password.Text == "")
                {
                    MessageBox.Show("Enter Password ");

                }

                else
                {                    
                    this.ActiveControl = LoginFunction;
                }

            }
        }

        private void userName_KeyUp(object sender, KeyEventArgs e)
        { 

            if (userName.Text == "\\" || userName.Text == "@" || userName.Text == "#" || userName.Text == "#" || userName.Text == "%" || userName.Text == "^" || userName.Text == "&" || userName.Text == "[" || userName.Text =="]" || userName.Text =="," || userName.Text =="'" ||userName.Text ==";" || userName.Text =="/" || userName.Text =="=" || userName.Text ==".")
            {
                MessageBox.Show("Enter valid User Name");
                userName.Clear();
            }
        }

        private void Gel_Doc_UI_Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginTitle_Click(object sender, EventArgs e)
        {

        }

       
    }
}

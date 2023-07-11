using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HardwareRentalApp
{
    public partial class Login : Form
    {
        private readonly HardwareRentalEntities hardwareRentalEntities;
        public Login()
        {
            InitializeComponent();
            hardwareRentalEntities = new HardwareRentalEntities();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();
                var username = txtUsername.Text;
                var password = txtPassword.Text;

                //hash password
                byte[] passToHash = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                //Create instance of string builder to convert bytes to string
                StringBuilder sb = new StringBuilder();

                //convert hash to string
                for(int i=0;i<passToHash.Length;i++)
                {
                    sb.Append(passToHash[i].ToString("x2")); //x2 = hex
                }

                var hashedPass = sb.ToString();

                //query if credentials match, inc hashed password
                var user =  hardwareRentalEntities.Users.FirstOrDefault(query => query.username == username && query.password == hashedPass);
                if(user == null)
                {
                    MessageBox.Show("User was not recognised.");
                }
                else
                {
                    MessageBox.Show("Success logging in as " + username);
                    var MainWindow = new MainWindow(this);
                    MainWindow.Show();
                    Hide();                    
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("An error occurred logging in");
            }
        }
    }
}

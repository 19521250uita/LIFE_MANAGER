using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Register : Form
    {

        public frm_Register()
        {
            InitializeComponent();
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
            LoadTheme();

        }
      

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
           // label5.ForeColor = ThemeColor.PrimaryColor;
        }
        private void btn_Register_Click(object sender, EventArgs e)
        {
            string strName = tb_Name.Text;
            string strUsername = tb_Username.Text;
            string strPassword = tb_Password.Text;
            string strBiography = rtb_Biography.Text;
            string strDate = tb_Date.Text;
            string savedPasswordHash = HashPassword(strPassword);
            if (strUsername != "" && strPassword != "" && strName != "")
            {
                try
                {
                    Models.User user = new Models.User()
                    {
                        Name = strName,
                        Username = strUsername,
                        Password = savedPasswordHash,
                        Biography = strBiography,
                        Date = strDate,
                    };
                    var options = new CreateIndexOptions { Unique = true };
#pragma warning disable CS0618 // Type or member is obsolete
                    frm_Login.Users.Indexes.CreateOne("{ Username : 1 }", options);
#pragma warning restore CS0618 // Type or member is obsolete
                    frm_Login.Users.InsertOne(user);
                    Thread a = new Thread(() => new frm_Login().ShowDialog());
                    a.SetApartmentState(ApartmentState.STA);
                    a.Start();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter Username, Password and Name");
            }
        }
        private string HashPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }
        
    }
}

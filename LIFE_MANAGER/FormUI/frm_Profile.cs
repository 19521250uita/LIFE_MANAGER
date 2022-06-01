using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFE_MANAGER.FormUI
{
    public partial class frm_Profile : Form
    {
        private string OriginalName = frm_Login.User.Name;
        private string OriginalDate = frm_Login.User.Date;
        private string OriginalBiography = frm_Login.User.Biography;
        public frm_Profile()
        {
            InitializeComponent();
            tb_Name.Text = OriginalName;
            tb_Date.Text = OriginalDate;
            rtb_Bio.Text = OriginalBiography;
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "")
            {
                if (tb_Name.Text != OriginalName || tb_Date.Text != OriginalDate
                    || rtb_Bio.Text != OriginalBiography)
                {
                    Models.User UserChanges = new Models.User()
                    {
                        //_id = frm_Login.User._id,
                        Name = tb_Name.Text,
                        Date = tb_Date.Text,
                        Biography = rtb_Bio.Text,
                        updatedAt = DateTime.Now,
                    };
                    try
                    {
                        var update = Builders<Models.User>.Update
                            .Set("Name", tb_Name.Text)
                            .Set("Date", tb_Date.Text)
                            .Set("Biography", rtb_Bio.Text);
                        var query = frm_Login.Users.UpdateOne(user => user._id == frm_Login.User._id, update);
                        MessageBox.Show("Your changes is successfully saved");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                else
                {
                    MessageBox.Show("No changes made");
                }
            }
            else
            {
                MessageBox.Show("Name cannot be null");
            }
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
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void frm_Profile_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Project
{
    public partial class Menu_Form : Form
    {
        private Form childForm;
        private string playerName;
        public Menu_Form()
        {
            InitializeComponent();
        }
        public Menu_Form(string playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
        }

        private void choice_label1_Click(object sender, EventArgs e)
        {

        }

        private void choice_label_Click(object sender, EventArgs e)
        {

        }

        private void player_name_Click(object sender, EventArgs e)
        {

        }
        private void openForm(Form form)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.Controls.Add(form);
            this.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            openForm(new Login_Form());
        }
        // perform form transition:

        private void create_btn_Click(object sender, EventArgs e)
        {
            openForm(new Create_Room_Form());
            DataContainer.room = new Room();
        }

        private void join_rand_btn_Click(object sender, EventArgs e)
        {
            openForm(new Join_Room_2());
        }

        private void join_code_btn_Click(object sender, EventArgs e)
        {
            openForm(new Join_Room_1());
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {
            player_name_label.Text = DataContainer.player.PlayerName;
            //MessageBox.Show(DataContainer.player.PlayerId);
            
        }

        private void player_name_label_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

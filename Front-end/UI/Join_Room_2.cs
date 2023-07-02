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
    public partial class Join_Room_2 : Form
    {
        private Form childForm;
        public Join_Room_2()
        {
            InitializeComponent();
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
            openForm(new Menu_Form());
        }

        private void standard_mode_btn_Click(object sender, EventArgs e)
        {
            standard_mode_btn.BorderSize = 3;
            wild_mode_btn.BorderSize = 0;
            standard_mode_btn.BorderColor = Color.BlueViolet;
        }

        private void wild_mode_btn_Click(object sender, EventArgs e)
        {
            standard_mode_btn.BorderSize = 0;
            wild_mode_btn.BorderSize = 3;
            wild_mode_btn.BorderColor = Color.BlueViolet;
        }

        private void Join_Room_2_Load(object sender, EventArgs e)
        {
            player_name_label.Text = DataContainer.player.PlayerName;
        }
    }
}

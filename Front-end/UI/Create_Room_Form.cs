using Microsoft.VisualBasic;
using Newtonsoft.Json;
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
    public partial class Create_Room_Form : Form
    {
        private Form childForm;
        public Create_Room_Form()
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
            DataContainer.room.Mode = "standard";
        }

        private void wild_mode_btn_Click(object sender, EventArgs e)
        {
            standard_mode_btn.BorderSize = 0;
            wild_mode_btn.BorderSize = 3;
            wild_mode_btn.BorderColor = Color.BlueViolet;
            DataContainer.room.Mode = "wild";
        }

        private void increase_player_btn_Click(object sender, EventArgs e)
        {
            if (DataContainer.room.NumberOfPlayer < 6)
            {
                DataContainer.room.NumberOfPlayer++;
                num_player_label.Text = "Number of players: " + DataContainer.room.NumberOfPlayer.ToString();
            }
        }

        private void decrease_player_btn_Click(object sender, EventArgs e)
        {
            if (DataContainer.room.NumberOfPlayer > 3)
            {
                DataContainer.room.NumberOfPlayer--;
                num_player_label.Text = "Number of players: " + DataContainer.room.NumberOfPlayer.ToString();
            }
        }

        private void decrease_time_btn_Click(object sender, EventArgs e)
        {
            if (DataContainer.room.TimePerRound > 1)
            {
                DataContainer.room.TimePerRound--;
                round_time_label.Text = "Round time: " + DataContainer.room.TimePerRound.ToString() + "s";
            }
        }

        private void increase_time_btn_Click(object sender, EventArgs e)
        {
            if (DataContainer.room.TimePerRound < 30)
            {
                DataContainer.room.TimePerRound++;
                round_time_label.Text = "Round time: " + DataContainer.room.TimePerRound.ToString() + "s";
            }
        }

        private void decrease_round_btn_Click(object sender, EventArgs e)
        {
            if (DataContainer.room.NumberOfRound > 3)
            {
                DataContainer.room.NumberOfRound--;
                num_round_label.Text = "Number of rounds: " + DataContainer.room.NumberOfRound.ToString();
            }
        }

        private void increase_round_btn_Click(object sender, EventArgs e)
        {
            if (DataContainer.room.NumberOfRound < 10)
            {
                DataContainer.room.NumberOfRound++;
                num_round_label.Text = "Number of rounds: " + DataContainer.room.NumberOfRound.ToString();
            }
        }

        private void create_room_btn_Click(object sender, EventArgs e)
        {
            if (DataContainer.room.Mode != "")
            {
                DataContainer.room.PlayerList = new List<Player>();
                DataContainer.room.PlayerList.Add(DataContainer.player);
                string room_info = JsonConvert.SerializeObject(DataContainer.room);
                string data = "create_room, " + room_info;
                byte[] send_data = Encoding.UTF8.GetBytes(data);
                DataContainer.ns.Write(send_data, 0, send_data.Length);
                while (DataContainer.respone_msg == "") { }
                DataContainer.room.RoomId = DataContainer.respone_msg;
                DataContainer.player.RoomId = DataContainer.respone_msg;

                MessageBox.Show(DataContainer.room.RoomId);
                DataContainer.respone_msg = "";
                openForm(new Waiting_Room());
            }
            else
            {
                MessageBox.Show("Please choose your game mode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Create_Room_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

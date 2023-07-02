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
    public partial class Endgame_screen : Form
    {
        public Endgame_screen()
        {
            InitializeComponent();
        }

        private void player_icon1_Click(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {

        }
        public static int CompareByValue(Player x, Player y)
        {
            return y.Point.CompareTo(x.Point);
        }
        private void Endgame_screen_Load(object sender, EventArgs e)
        {
            string data = "endgame, " + DataContainer.room.RoomId + ", ";
            Byte[] send_data = new Byte[data.Length];
            send_data = Encoding.UTF8.GetBytes(data);
            DataContainer.ns.Write(send_data, 0, send_data.Length);
            DataContainer.flush();

            while (DataContainer.respone_msg == "") { }

            Room roomInfo = JsonConvert.DeserializeObject<Room>(DataContainer.respone_msg);
            List<Player> playerList = roomInfo.PlayerList;
            playerList.Sort(CompareByValue);
            
            player1_pt.Text = playerList[0].Point.ToString();
            player2_pt.Text = playerList[1].Point.ToString();
            player3_pt.Text = playerList[2].Point.ToString();

            Player1_name.Text = playerList[0].PlayerName;
            Player2_name.Text = playerList[1].PlayerName;
            Player3_name.Text = playerList[2].PlayerName;
        }
    }
}

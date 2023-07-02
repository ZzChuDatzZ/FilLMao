using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Demo_Project
{
    public partial class Waiting_Room : Form
    {
        private Form childForm;
        private Byte[] send_data = new Byte[2048];
        private List<Player> receivePlayerList = new List<Player>();
        List<Label> playerLabel = new List<Label>();

        public Waiting_Room()
        {
            InitializeComponent();
            playerLabel.Add(player1);
            playerLabel.Add(player2);
            playerLabel.Add(player3);
            playerLabel.Add(player4);
            playerLabel.Add(player5);
            playerLabel.Add(player6);
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
            this.Invoke(new Action(() =>
            {
                this.Controls.Add(form);
                this.Tag = form;
                form.BringToFront();
                form.Show();
            }));
        }
        void update()
        {
            while (DataContainer.room.PlayerList.Count <= DataContainer.room.NumberOfPlayer)
            {
                while (DataContainer.respone_msg == "") { }
                //MessageBox.Show( DataContainer.respone_msg);
                //string strPlayerInfo = Encoding.UTF8.GetString(DataContainer.recv_data, 0, bytesRead);
                Room joined_player;
                joined_player = JsonConvert.DeserializeObject<Room>(DataContainer.respone_msg);
                //MessageBox.Show(DataContainer.respone_msg);
                //DataContainer.room.PlayerList.Add(joined_player);
                DataContainer.room.PlayerList = joined_player.PlayerList;
                for (int i = 0; i < playerLabel.Count; ++i)
                {
                    //playerLabel[i].Text = DataContainer.room.PlayerList[i].PlayerName;
                    if (i <= DataContainer.room.PlayerList.Count - 1)
                    {
                        playerLabel[i].Invoke((MethodInvoker)delegate
                        {
                            playerLabel[i].Text = DataContainer.room.PlayerList[i].PlayerName;
                        });
                    }

                    else
                    {
                        playerLabel[i].Invoke((MethodInvoker)delegate
                        {
                            playerLabel[i].Text = "None";
                        });

                    }
                }

                //if(DataContainer.player.PlayerId == DataContainer.room.PlayerList[0].PlayerId)
                //{
                //    int check = 1;
                //    foreach(Player p in  DataContainer.room.PlayerList)
                //    {
                //        if(p.IsReady == false)
                //        {
                //            check = 0; break;
                //        }  
                //    }

                //    if(check == 1)
                //    {
                //        string msg = "start";

                //    }
                //}
                int check = 0;
                foreach (Player p in DataContainer.room.PlayerList)
                {
                    if (p.IsReady == "true")
                    {
                        check++;
                    }
                }
                if (check == DataContainer.room.NumberOfPlayer)
                {
                    break;
                }
                DataContainer.flush();
            }
            DataContainer.flush();
            openForm(new Standard_Gameplay_Screen());
        }
        //void adding_player()
        //{

        //    int cnt = 0;
        //    playerLabel[0].Invoke((MethodInvoker)delegate {
        //        playerLabel[0].Text = DataContainer.player.PlayerName;
        //    });

        //    while (true)
        //    {
        //        if (cnt < DataContainer.room.PlayerList.Count)
        //        {
        //            playerLabel[cnt].Invoke((MethodInvoker)delegate {
        //                playerLabel[cnt].Text = DataContainer.room.PlayerList[cnt].PlayerName;
        //            });

        //            cnt++;
        //        }
        //        else if(cnt > DataContainer.room.PlayerList.Count)
        //        {
        //            foreach(Label l in playerLabel)
        //            {
        //                l.Text = "None";
        //            }
        //            for (int i = 0; i < DataContainer.room.NumberOfPlayer; ++i)
        //            {
        //                playerLabel[i].Invoke((MethodInvoker)delegate
        //                {
        //                    playerLabel[i].Text = DataContainer.room.PlayerList[i].PlayerName;
        //                });
        //            }

        //            cnt--;
        //        }
        //        else if (cnt ==  DataContainer.room.NumberOfPlayer)
        //        {

        //            break;
        //        }
        //    }
        //}
        private void Waiting_Room_Load(object sender, EventArgs e)
        {
            //player1.Text = DataContainer.room.PlayerList.Count >= 1 ? DataContainer.room.PlayerList[0].PlayerName : "None";

            Thread waiting = new Thread(update);
            //waiting.IsBackground = true;
            waiting.Start();
            //waiting.Join();

            //MessageBox.Show(DataContainer.room.PlayerList.Count.ToString());

            time_label.Text = DataContainer.room.TimePerRound.ToString() + "s";
            //waiting.Join();

            //playerLabel[0].Invoke((MethodInvoker)delegate {
            //        playerLabel[0].Text = DataContainer.player.PlayerName;
            //});
            for (int i = 0; i < DataContainer.room.PlayerList.Count; ++i)
                playerLabel[i].Text = DataContainer.room.PlayerList[i].PlayerName;
            //Thread adding = new Thread(adding_player);
            //adding.IsBackground = true;
            //adding.Start();
            //adding.Join();
        }

        private void title_label_Click(object sender, EventArgs e)
        {

        }

        private void leave_btn_Click(object sender, EventArgs e)
        {
            string strPlayerInfo = JsonConvert.SerializeObject(DataContainer.player);
            string data = "leave_room, " + DataContainer.player.RoomId + ", " + strPlayerInfo;

            send_data = Encoding.UTF8.GetBytes(data);
            DataContainer.ns.Write(send_data, 0, send_data.Length);
            DataContainer.flush();
            openForm(new Menu_Form());
        }

        private void ready_btn_Click(object sender, EventArgs e)
        {
            if (DataContainer.player.IsReady == "false")
            {
                DataContainer.player.IsReady = "true";
                ready_btn.BorderSize = 3;
                ready_btn.BorderColor = Color.Violet;

                string strPlayerInfo = JsonConvert.SerializeObject(DataContainer.player);
                string data = "ready, " + strPlayerInfo;

                send_data = Encoding.UTF8.GetBytes(data);
                DataContainer.ns.Write(send_data, 0, send_data.Length);
                DataContainer.flush();
            }


        }

        private void player1_Click(object sender, EventArgs e)
        {

        }

        private void rPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

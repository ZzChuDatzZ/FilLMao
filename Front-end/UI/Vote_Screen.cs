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
    public partial class Vote_Screen : Form
    {
        private Form childForm;
        private List<RJButton> voteList = new List<RJButton>();
        private string[] answers;

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
        public Vote_Screen()
        {
            InitializeComponent();
            voteList.Add(vote_ans1);
            voteList.Add(vote_ans2);
            voteList.Add(vote_ans3);
            voteList.Add(vote_ans4);
            voteList.Add(vote_ans5);
        }
        void receive()
        {
            Byte[] send_data_ques;
            if (DataContainer.player.PlayerId == DataContainer.room.PlayerList[0].PlayerId)
            {
                string get_question = "recv_ans, ";

                send_data_ques = Encoding.UTF8.GetBytes(get_question);
                DataContainer.ns.Write(send_data_ques, 0, send_data_ques.Length);

            }
            while (DataContainer.respone_msg == "") { }
            MessageBox.Show(DataContainer.respone_msg);
            answers = DataContainer.respone_msg.Split(", ");
            foreach(string answer in answers)
            {
                if(answer == DataContainer.player.Answer)
                {
                    answers = answers.Where(val => val != DataContainer.player.Answer).ToArray();
                }
            }
            for (int i = 0; i < answers.Length - 1; i++)
            {
                voteList[i].Invoke((MethodInvoker)delegate
                {
                    voteList[i].Text = answers[i];
                });
            }
            DataContainer.flush();
        }
        private void Vote_Screen_Load(object sender, EventArgs e)
        {
            Thread receiving_answers = new Thread(receive);
            //receiving_answers.IsBackground = true;
            receiving_answers.Start();
            //receiving_answers.Join();

            //receive();
        }

        private void vote_ans1_Click(object sender, EventArgs e)
        {

            string data = "voting, " + vote_ans1.Text + ", ";
            Byte[] send_data = new Byte[data.Length];
            send_data = Encoding.UTF8.GetBytes(data);
            DataContainer.ns.Write(send_data, 0, send_data.Length);

            while (DataContainer.respone_msg == "") { }
            if (DataContainer.respone_msg == "done")
            {
                DataContainer.flush();

                if (DataContainer.currentRound <= DataContainer.room.NumberOfRound)
                    openForm(new Standard_Gameplay_Screen());
                else
                    openForm(new Endgame_screen());
            }
        }

        private void vote_ans2_Click(object sender, EventArgs e)
        {
            string data = "voting, " + vote_ans2.Text + ", ";
            Byte[] send_data = new Byte[data.Length];
            send_data = Encoding.UTF8.GetBytes(data);
            DataContainer.ns.Write(send_data, 0, send_data.Length);

            while (DataContainer.respone_msg == "") { }
            if (DataContainer.respone_msg == "done")
            {
                DataContainer.flush();

                if (DataContainer.currentRound <= DataContainer.room.NumberOfRound)
                    openForm(new Standard_Gameplay_Screen());
                else
                    openForm(new Endgame_screen());
            }
        }

        private void vote_ans3_Click(object sender, EventArgs e)
        {
            string data = "voting, " + vote_ans3.Text + ", ";
            Byte[] send_data = new Byte[data.Length];
            send_data = Encoding.UTF8.GetBytes(data);
            DataContainer.ns.Write(send_data, 0, send_data.Length);

            while (DataContainer.respone_msg == "") { }
            if (DataContainer.respone_msg == "done")
            {
                DataContainer.flush();

                if (DataContainer.currentRound <= DataContainer.room.NumberOfRound)
                    openForm(new Standard_Gameplay_Screen());
                else
                    openForm(new Endgame_screen());
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string data = "voting, " + vote_ans4.Text + ", ";
            Byte[] send_data = new Byte[data.Length];
            send_data = Encoding.UTF8.GetBytes(data);
            DataContainer.ns.Write(send_data, 0, send_data.Length);

            while (DataContainer.respone_msg == "") { }
            if (DataContainer.respone_msg == "done")
            {
                DataContainer.flush();

                if (DataContainer.currentRound <= DataContainer.room.NumberOfRound)
                    openForm(new Standard_Gameplay_Screen());
                else
                    openForm(new Endgame_screen());
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            string data = "voting, " + vote_ans5.Text + ", ";
            Byte[] send_data = new Byte[data.Length];
            send_data = Encoding.UTF8.GetBytes(data);
            DataContainer.ns.Write(send_data, 0, send_data.Length);

            while (DataContainer.respone_msg == "") { }
            if (DataContainer.respone_msg == "done")
            {
                DataContainer.flush();
                if (DataContainer.currentRound <= DataContainer.room.NumberOfRound)
                    openForm(new Standard_Gameplay_Screen());
                else
                    openForm(new Endgame_screen());
            }
        }
    }
}

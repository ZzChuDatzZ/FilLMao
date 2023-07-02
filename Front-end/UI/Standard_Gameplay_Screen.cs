using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Demo_Project
{
    public partial class Standard_Gameplay_Screen : Form
    {
        private Form childForm;
        private string[] answers;
        private int seconds = DataContainer.room.TimePerRound;
        //private int seconds = 5;
        private System.Windows.Forms.Timer countdownTimer;
        private bool isButtonClicked = false;

        public Standard_Gameplay_Screen()
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
        private void send_answer(string answer)
        {
            DataContainer.player.Answer = answer;
            string send_data = "answer_selected, " + DataContainer.player.PlayerId + ", " + answer + ", " + DataContainer.room.RoomId + ", ";
            Byte[] answerBytes = Encoding.UTF8.GetBytes(send_data);
            DataContainer.ns.Write(answerBytes, 0, answerBytes.Length);
            DataContainer.ns.Flush();
        }
        private void ans1_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
                send_answer(ans1.Text);

                // Change the border color of the clicked button
                RJButton clickedButton = (RJButton)sender;
                clickedButton.BorderSize = 3;
                clickedButton.BorderColor = Color.Violet;

                // Disable all other buttons on the form
                foreach (Control control in this.Controls)
                {
                    if (control is RJButton && control != clickedButton)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        private void ans2_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
                send_answer(ans2.Text);

                // Change the border color of the clicked button
                RJButton clickedButton = (RJButton)sender;
                clickedButton.BorderSize = 3;
                clickedButton.BorderColor = Color.Violet;

                // Disable all other buttons on the form
                foreach (Control control in this.Controls)
                {
                    if (control is RJButton && control != clickedButton)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        private void ans3_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
                send_answer(ans3.Text);

                // Change the border color of the clicked button
                RJButton clickedButton = (RJButton)sender;
                clickedButton.BorderSize = 3;
                clickedButton.BorderColor = Color.Violet;

                // Disable all other buttons on the form
                foreach (Control control in this.Controls)
                {
                    if (control is RJButton && control != clickedButton)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        private void ans4_Click(object sender, EventArgs e)
        {
            if (!isButtonClicked)
            {
                isButtonClicked = true;
                send_answer(ans4.Text);

                // Change the border color of the clicked button
                RJButton clickedButton = (RJButton)sender;
                clickedButton.BorderSize = 3;
                clickedButton.BorderColor = Color.Violet;

                // Disable all other buttons on the form
                foreach (Control control in this.Controls)
                {
                    if (control is RJButton && control != clickedButton)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }

        private void count_Down()
        {
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 second
            countdownTimer.Tick += new EventHandler(countDownTimer_Tick);
            countdownTimer.Start();
        }

        private void start()
        {
            //while (DataContainer.currentRound <= DataContainer.room.TimePerRound)
            //{
                Byte[] send_data_ques;
                if (DataContainer.player.PlayerId == DataContainer.room.PlayerList[0].PlayerId)
                {
                    string get_question = "get_question, ";
                    
                    send_data_ques = Encoding.UTF8.GetBytes(get_question);
                    DataContainer.ns.Write(send_data_ques, 0, send_data_ques.Length);

                }
                DataContainer.flush();
                while(DataContainer.respone_msg == "") 
                {
                } 
                question ques = JsonConvert.DeserializeObject<question>(DataContainer.respone_msg);
                choice_label.Text = ques.Ch;
                if (DataContainer.player.PlayerId == DataContainer.room.PlayerList[0].PlayerId)
                {
                    string get_answer = "get_answer, " + ques.Id + ", ";
                    Byte[] send_data_ans;
                    send_data_ans = Encoding.UTF8.GetBytes(get_answer);
                    DataContainer.ns.Write(send_data_ans, 0, send_data_ans.Length);
                   
                }
                DataContainer.flush();
                while (DataContainer.respone_msg == "")
                {
                }

                List<answer> answers = new List<answer>();
                answers = JsonConvert.DeserializeObject<List<answer>>(DataContainer.respone_msg);
                ans1.Text = answers[0].Cautl;
                ans2.Text = answers[1].Cautl;
                ans3.Text = answers[2].Cautl;
                ans4.Text = answers[3].Cautl;
                Thread.Sleep(1000*seconds);
            DataContainer.flush();
            //}
            
            //MessageBox.Show("out");
        }

        private void Standard_Gameplay_Screen_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(DataContainer.currentRound.ToString());
            //if (DataContainer.currentRound <= DataContainer.room.NumberOfRound) {

            seconds = DataContainer.room.TimePerRound;
            Thread playing = new Thread(start);
            playing.IsBackground = true;
            playing.Start();
            //start();

            //}

            count_Down();
        }

        private void countDownTimer_Tick(object sender, EventArgs e)
        {
            time_label.BeginInvoke((MethodInvoker)delegate () {
                time_label.Text = (seconds--).ToString() + "s";
                if (seconds < 0)
                {
                    countdownTimer.Stop();
                    DataContainer.currentRound++;
                    //MessageBox.Show(DataContainer.currentRound.ToString());
                    seconds = DataContainer.room.TimePerRound; // Reset timer for next turn
                    time_label.Text = seconds.ToString()+"s";
                    DataContainer.flush();
                    openForm(new Vote_Screen());
                }
            });
        }
    }
}

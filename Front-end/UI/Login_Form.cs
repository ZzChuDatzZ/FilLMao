
using Newtonsoft.Json;
using System.Text;

namespace Demo_Project
{
    public partial class Login_Form : Form
    {
        // next from property: used for form transition
        private Form childForm;

        public Login_Form()
        {
            InitializeComponent();
            //this.next_form = new Menu_Form();
            //HideForm(next_form);
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
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void name_btn_Click(object sender, EventArgs e)
        {
            if (input_name_box.Text != String.Empty)
            {
                Byte[] send_data;
                DataContainer.player.PlayerName = input_name_box.Text;
                DataContainer.connect();
                //data = System.Text.Encoding.ASCII.GetBytes(DataContainer.player.PlayerName);
                //DataContainer.ns.Write(data, 0, DataContainer.player.PlayerName.Length);

                string strPlayerInfo = JsonConvert.SerializeObject(DataContainer.player);
                string data = "login, " + strPlayerInfo;
                
                send_data = Encoding.UTF8.GetBytes(data);
                DataContainer.ns.Write(send_data, 0, send_data.Length);

                while (DataContainer.respone_msg == "") { }
                DataContainer.player.PlayerId = DataContainer.respone_msg;
                MessageBox.Show(DataContainer.player.PlayerId);
                DataContainer.flush();
                openForm(new Menu_Form());
                
            }
            else
            {
                MessageBox.Show("Your name must not be empty!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // perform form transition:
        //private void ShowForm(Form form)
        //{
        //    form.Visible = true;
        //    form.FormBorderStyle = FormBorderStyle.FixedSingle;
        //    form.Height = this.Height;
        //    form.Width = this.Width;
        //}
        //private void HideForm(Form form)
        //{
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Height = 0;
        //    form.Width = 0;
        //    form.Visible = false;
        //}

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }
    }
}
using System;
using System.Runtime.InteropServices;

namespace Demo_Project
{
    partial class Login_Form
    {
        float firstWidth;
        float firstHeight;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            login_label = new Label();
            login_info = new TextBox();
            login_btn = new Button();
            title = new Label();
            decorate_panel = new RPanel();
            input_panel = new RPanel();
            input_name_box = new TextBox();
            confirm_name_btn = new RJButton();
            name_label = new Label();
            exit_btn = new RJButton();
            decorate_panel.SuspendLayout();
            input_panel.SuspendLayout();
            SuspendLayout();
            // 
            // login_label
            // 
            login_label.Enabled = false;
            login_label.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            login_label.Image = (Image)resources.GetObject("login_label.Image");
            login_label.ImageAlign = ContentAlignment.MiddleRight;
            login_label.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            login_label.Location = new Point(145, 61);
            login_label.Name = "login_label";
            login_label.Size = new Size(377, 85);
            login_label.TabIndex = 2;
            login_label.Text = "Create A Cool Name";
            login_label.TextAlign = ContentAlignment.MiddleLeft;
            login_label.Click += login_label_Click;
            // 
            // login_info
            // 
            login_info.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            login_info.Location = new Point(145, 170);
            login_info.Multiline = true;
            login_info.Name = "login_info";
            login_info.PlaceholderText = "Put words in me";
            login_info.Size = new Size(349, 65);
            login_info.TabIndex = 1;
            login_info.TextAlign = HorizontalAlignment.Center;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(25, 1, 82);
            login_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(145, 279);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(349, 78);
            login_btn.TabIndex = 0;
            login_btn.Text = "Yeah! I'm in";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Image = (Image)resources.GetObject("title.Image");
            title.ImageAlign = ContentAlignment.MiddleLeft;
            title.Location = new Point(475, 9);
            title.Name = "title";
            title.Size = new Size(331, 117);
            title.TabIndex = 1;
            title.Text = "FilLmao";
            title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // decorate_panel
            // 
            decorate_panel.BackColor = Color.FromArgb(231, 231, 231);
            decorate_panel.BorderRadius = 30;
            decorate_panel.Controls.Add(input_panel);
            decorate_panel.Controls.Add(confirm_name_btn);
            decorate_panel.Controls.Add(name_label);
            decorate_panel.Location = new Point(314, 151);
            decorate_panel.Name = "decorate_panel";
            decorate_panel.Size = new Size(650, 405);
            decorate_panel.TabIndex = 22;
            // 
            // input_panel
            // 
            input_panel.BackColor = SystemColors.Window;
            input_panel.BorderRadius = 20;
            input_panel.Controls.Add(input_name_box);
            input_panel.Location = new Point(102, 160);
            input_panel.Name = "input_panel";
            input_panel.Size = new Size(447, 74);
            input_panel.TabIndex = 37;
            // 
            // input_name_box
            // 
            input_name_box.BorderStyle = BorderStyle.None;
            input_name_box.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            input_name_box.Location = new Point(29, 20);
            input_name_box.Name = "input_name_box";
            input_name_box.PlaceholderText = "Put Words Inside Me";
            input_name_box.Size = new Size(400, 31);
            input_name_box.TabIndex = 0;
            input_name_box.TextAlign = HorizontalAlignment.Center;
            // 
            // confirm_name_btn
            // 
            confirm_name_btn.BackColor = Color.FromArgb(25, 1, 82);
            confirm_name_btn.BackgroundColor = Color.FromArgb(25, 1, 82);
            confirm_name_btn.BorderColor = Color.PaleVioletRed;
            confirm_name_btn.BorderRadius = 40;
            confirm_name_btn.BorderSize = 0;
            confirm_name_btn.FlatAppearance.BorderSize = 0;
            confirm_name_btn.FlatStyle = FlatStyle.Flat;
            confirm_name_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            confirm_name_btn.ForeColor = Color.White;
            confirm_name_btn.Location = new Point(102, 271);
            confirm_name_btn.Name = "confirm_name_btn";
            confirm_name_btn.Size = new Size(447, 78);
            confirm_name_btn.TabIndex = 36;
            confirm_name_btn.Text = "Yeah! I'm In!";
            confirm_name_btn.TextColor = Color.White;
            confirm_name_btn.UseVisualStyleBackColor = false;
            confirm_name_btn.Click += name_btn_Click;
            // 
            // name_label
            // 
            name_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            name_label.Image = (Image)resources.GetObject("name_label.Image");
            name_label.ImageAlign = ContentAlignment.MiddleRight;
            name_label.Location = new Point(131, 55);
            name_label.Name = "name_label";
            name_label.Size = new Size(400, 77);
            name_label.TabIndex = 34;
            name_label.Text = "Create A Cool Name";
            name_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.Transparent;
            exit_btn.BackgroundColor = Color.Transparent;
            exit_btn.BorderColor = Color.PaleVioletRed;
            exit_btn.BorderRadius = 40;
            exit_btn.BorderSize = 0;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exit_btn.ForeColor = Color.Black;
            exit_btn.Image = (Image)resources.GetObject("exit_btn.Image");
            exit_btn.ImageAlign = ContentAlignment.MiddleRight;
            exit_btn.Location = new Point(1045, 12);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(205, 50);
            exit_btn.TabIndex = 23;
            exit_btn.Text = "Exit game";
            exit_btn.TextAlign = ContentAlignment.MiddleLeft;
            exit_btn.TextColor = Color.Black;
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // Login_Form
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(exit_btn);
            Controls.Add(decorate_panel);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login_Form";
            Text = "Login";
            FormClosed += Login_Form_FormClosed;
            Load += Form1_Load;
            decorate_panel.ResumeLayout(false);
            input_panel.ResumeLayout(false);
            input_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel login_form;
        private Label login_label;
        private TextBox login_info;
        private Button login_btn;
        private Label title;
        private RPanel decorate_panel;
        private RJButton confirm_name_btn;
        private Label name_label;
        private RPanel input_panel;
        private TextBox input_name_box;
        private RJButton exit_btn;
    }
}
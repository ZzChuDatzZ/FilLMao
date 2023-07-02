namespace Demo_Project
{
    partial class Waiting_Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waiting_Room));
            title = new Label();
            img2 = new Label();
            img3 = new Label();
            img1 = new Label();
            title_label = new Label();
            game_mode_label = new Label();
            time_label = new Label();
            rPanel1 = new RPanel();
            rPanel7 = new RPanel();
            player6 = new Label();
            rPanel6 = new RPanel();
            player5 = new Label();
            rPanel5 = new RPanel();
            player4 = new Label();
            rPanel4 = new RPanel();
            player3 = new Label();
            rPanel3 = new RPanel();
            player2 = new Label();
            rPanel2 = new RPanel();
            player1 = new Label();
            leave_btn = new RJButton();
            ready_btn = new RJButton();
            rPanel1.SuspendLayout();
            rPanel7.SuspendLayout();
            rPanel6.SuspendLayout();
            rPanel5.SuspendLayout();
            rPanel4.SuspendLayout();
            rPanel3.SuspendLayout();
            rPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Image = (Image)resources.GetObject("title.Image");
            title.ImageAlign = ContentAlignment.MiddleLeft;
            title.Location = new Point(-10, -9);
            title.Name = "title";
            title.Size = new Size(253, 112);
            title.TabIndex = 26;
            title.Text = "FilLmao";
            title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // img2
            // 
            img2.BackColor = Color.FromArgb(144, 200, 255);
            img2.Image = (Image)resources.GetObject("img2.Image");
            img2.Location = new Point(365, 16);
            img2.Name = "img2";
            img2.Size = new Size(51, 73);
            img2.TabIndex = 28;
            // 
            // img3
            // 
            img3.BackColor = Color.FromArgb(144, 200, 255);
            img3.Image = (Image)resources.GetObject("img3.Image");
            img3.Location = new Point(408, 16);
            img3.Name = "img3";
            img3.Size = new Size(55, 73);
            img3.TabIndex = 29;
            // 
            // img1
            // 
            img1.BackColor = Color.FromArgb(144, 200, 255);
            img1.Image = (Image)resources.GetObject("img1.Image");
            img1.Location = new Point(312, 16);
            img1.Name = "img1";
            img1.Size = new Size(62, 73);
            img1.TabIndex = 27;
            // 
            // title_label
            // 
            title_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            title_label.Location = new Point(459, 34);
            title_label.Name = "title_label";
            title_label.Size = new Size(273, 55);
            title_label.TabIndex = 31;
            title_label.Text = "Waiting Room";
            title_label.Click += title_label_Click;
            // 
            // game_mode_label
            // 
            game_mode_label.AutoSize = true;
            game_mode_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            game_mode_label.Location = new Point(983, 139);
            game_mode_label.Name = "game_mode_label";
            game_mode_label.Size = new Size(213, 45);
            game_mode_label.TabIndex = 34;
            game_mode_label.Text = "Game Mode:";
            game_mode_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // time_label
            // 
            time_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            time_label.Image = (Image)resources.GetObject("time_label.Image");
            time_label.ImageAlign = ContentAlignment.MiddleLeft;
            time_label.Location = new Point(972, 267);
            time_label.Name = "time_label";
            time_label.Size = new Size(264, 88);
            time_label.TabIndex = 35;
            time_label.Text = "30s";
            time_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel1
            // 
            rPanel1.BackColor = Color.FromArgb(79, 83, 103);
            rPanel1.BorderRadius = 30;
            rPanel1.Controls.Add(rPanel7);
            rPanel1.Controls.Add(rPanel6);
            rPanel1.Controls.Add(rPanel5);
            rPanel1.Controls.Add(rPanel4);
            rPanel1.Controls.Add(rPanel3);
            rPanel1.Controls.Add(rPanel2);
            rPanel1.Location = new Point(40, 120);
            rPanel1.Name = "rPanel1";
            rPanel1.Size = new Size(850, 505);
            rPanel1.TabIndex = 36;
            rPanel1.Paint += rPanel1_Paint;
            // 
            // rPanel7
            // 
            rPanel7.BackColor = SystemColors.Window;
            rPanel7.BorderRadius = 20;
            rPanel7.Controls.Add(player6);
            rPanel7.Location = new Point(612, 284);
            rPanel7.Name = "rPanel7";
            rPanel7.Size = new Size(170, 200);
            rPanel7.TabIndex = 5;
            // 
            // player6
            // 
            player6.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            player6.Location = new Point(0, 0);
            player6.Name = "player6";
            player6.Size = new Size(170, 200);
            player6.TabIndex = 44;
            player6.Text = "None";
            player6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel6
            // 
            rPanel6.BackColor = SystemColors.Window;
            rPanel6.BorderRadius = 20;
            rPanel6.Controls.Add(player5);
            rPanel6.Location = new Point(336, 284);
            rPanel6.Name = "rPanel6";
            rPanel6.Size = new Size(170, 200);
            rPanel6.TabIndex = 4;
            // 
            // player5
            // 
            player5.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            player5.Location = new Point(0, 0);
            player5.Name = "player5";
            player5.Size = new Size(170, 200);
            player5.TabIndex = 44;
            player5.Text = "None";
            player5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel5
            // 
            rPanel5.BackColor = SystemColors.Window;
            rPanel5.BorderRadius = 20;
            rPanel5.Controls.Add(player4);
            rPanel5.Location = new Point(64, 284);
            rPanel5.Name = "rPanel5";
            rPanel5.Size = new Size(170, 200);
            rPanel5.TabIndex = 3;
            // 
            // player4
            // 
            player4.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            player4.Location = new Point(0, 0);
            player4.Name = "player4";
            player4.Size = new Size(170, 200);
            player4.TabIndex = 44;
            player4.Text = "None";
            player4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel4
            // 
            rPanel4.BackColor = SystemColors.Window;
            rPanel4.BorderRadius = 20;
            rPanel4.Controls.Add(player3);
            rPanel4.Location = new Point(612, 35);
            rPanel4.Name = "rPanel4";
            rPanel4.Size = new Size(170, 200);
            rPanel4.TabIndex = 2;
            // 
            // player3
            // 
            player3.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            player3.Location = new Point(0, 0);
            player3.Name = "player3";
            player3.Size = new Size(170, 200);
            player3.TabIndex = 44;
            player3.Text = "None";
            player3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel3
            // 
            rPanel3.BackColor = SystemColors.Window;
            rPanel3.BorderRadius = 20;
            rPanel3.Controls.Add(player2);
            rPanel3.Location = new Point(336, 35);
            rPanel3.Name = "rPanel3";
            rPanel3.Size = new Size(170, 200);
            rPanel3.TabIndex = 1;
            // 
            // player2
            // 
            player2.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            player2.Location = new Point(0, 0);
            player2.Name = "player2";
            player2.Size = new Size(170, 200);
            player2.TabIndex = 44;
            player2.Text = "None";
            player2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel2
            // 
            rPanel2.BackColor = SystemColors.Window;
            rPanel2.BorderRadius = 20;
            rPanel2.Controls.Add(player1);
            rPanel2.Location = new Point(64, 35);
            rPanel2.Name = "rPanel2";
            rPanel2.Size = new Size(170, 200);
            rPanel2.TabIndex = 0;
            // 
            // player1
            // 
            player1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            player1.Location = new Point(0, 0);
            player1.Name = "player1";
            player1.Size = new Size(170, 200);
            player1.TabIndex = 44;
            player1.Text = "None";
            player1.TextAlign = ContentAlignment.MiddleCenter;
            player1.Click += player1_Click;
            // 
            // leave_btn
            // 
            leave_btn.BackColor = Color.FromArgb(25, 1, 82);
            leave_btn.BackgroundColor = Color.FromArgb(25, 1, 82);
            leave_btn.BorderColor = Color.PaleVioletRed;
            leave_btn.BorderRadius = 40;
            leave_btn.BorderSize = 0;
            leave_btn.FlatAppearance.BorderSize = 0;
            leave_btn.FlatStyle = FlatStyle.Flat;
            leave_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            leave_btn.ForeColor = Color.White;
            leave_btn.Location = new Point(972, 526);
            leave_btn.Name = "leave_btn";
            leave_btn.Size = new Size(224, 78);
            leave_btn.TabIndex = 42;
            leave_btn.Text = "Leave Room";
            leave_btn.TextColor = Color.White;
            leave_btn.UseVisualStyleBackColor = false;
            leave_btn.Click += leave_btn_Click;
            // 
            // ready_btn
            // 
            ready_btn.BackColor = Color.FromArgb(25, 1, 82);
            ready_btn.BackgroundColor = Color.FromArgb(25, 1, 82);
            ready_btn.BorderColor = Color.PaleVioletRed;
            ready_btn.BorderRadius = 40;
            ready_btn.BorderSize = 0;
            ready_btn.FlatAppearance.BorderSize = 0;
            ready_btn.FlatStyle = FlatStyle.Flat;
            ready_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ready_btn.ForeColor = Color.White;
            ready_btn.Location = new Point(972, 418);
            ready_btn.Name = "ready_btn";
            ready_btn.Size = new Size(224, 78);
            ready_btn.TabIndex = 43;
            ready_btn.Text = "Ready";
            ready_btn.TextColor = Color.White;
            ready_btn.UseVisualStyleBackColor = false;
            ready_btn.Click += ready_btn_Click;
            // 
            // Waiting_Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(ready_btn);
            Controls.Add(leave_btn);
            Controls.Add(rPanel1);
            Controls.Add(time_label);
            Controls.Add(game_mode_label);
            Controls.Add(img2);
            Controls.Add(img1);
            Controls.Add(title);
            Controls.Add(img3);
            Controls.Add(title_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Waiting_Room";
            Text = "Waiting_Room";
            Load += Waiting_Room_Load;
            rPanel1.ResumeLayout(false);
            rPanel7.ResumeLayout(false);
            rPanel6.ResumeLayout(false);
            rPanel5.ResumeLayout(false);
            rPanel4.ResumeLayout(false);
            rPanel3.ResumeLayout(false);
            rPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label img2;
        private Label img3;
        private Label img1;
        private Label title_label;
        private Label game_mode_label;
        private Label time_label;
        private RPanel rPanel1;
        private RJButton leave_btn;
        private RJButton ready_btn;
        private RPanel rPanel2;
        private RPanel rPanel7;
        private RPanel rPanel6;
        private RPanel rPanel5;
        private Label player4;
        private RPanel rPanel4;
        private RPanel rPanel3;
        private Label player6;
        private Label player5;
        private Label player3;
        private Label player2;
        private Label player1;
    }
}
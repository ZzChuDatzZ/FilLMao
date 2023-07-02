namespace Demo_Project
{
    partial class Join_Room_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Join_Room_2));
            player_name_label = new Label();
            Game_Name = new Label();
            img2 = new Label();
            img3 = new Label();
            img1 = new Label();
            title_panel = new RPanel();
            title_label = new Label();
            standard_mode_btn = new RJButton();
            wild_mode_btn = new RJButton();
            join_room_btn = new RJButton();
            back_btn = new RJButton();
            title_panel.SuspendLayout();
            SuspendLayout();
            // 
            // player_name_label
            // 
            player_name_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            player_name_label.Image = (Image)resources.GetObject("player_name_label.Image");
            player_name_label.ImageAlign = ContentAlignment.MiddleRight;
            player_name_label.Location = new Point(530, 145);
            player_name_label.Name = "player_name_label";
            player_name_label.Size = new Size(224, 68);
            player_name_label.TabIndex = 32;
            player_name_label.Text = "Player";
            player_name_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Game_Name
            // 
            Game_Name.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            Game_Name.Image = (Image)resources.GetObject("Game_Name.Image");
            Game_Name.ImageAlign = ContentAlignment.MiddleLeft;
            Game_Name.Location = new Point(449, 24);
            Game_Name.Name = "Game_Name";
            Game_Name.Size = new Size(339, 121);
            Game_Name.TabIndex = 25;
            Game_Name.Text = "FilLmao";
            Game_Name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // img2
            // 
            img2.BackColor = Color.FromArgb(231, 231, 231);
            img2.Image = (Image)resources.GetObject("img2.Image");
            img2.Location = new Point(745, 229);
            img2.Name = "img2";
            img2.Size = new Size(51, 73);
            img2.TabIndex = 36;
            // 
            // img3
            // 
            img3.BackColor = Color.FromArgb(231, 231, 231);
            img3.Image = (Image)resources.GetObject("img3.Image");
            img3.Location = new Point(790, 229);
            img3.Name = "img3";
            img3.Size = new Size(53, 68);
            img3.TabIndex = 37;
            // 
            // img1
            // 
            img1.BackColor = Color.FromArgb(231, 231, 231);
            img1.Image = (Image)resources.GetObject("img1.Image");
            img1.Location = new Point(692, 229);
            img1.Name = "img1";
            img1.Size = new Size(62, 73);
            img1.TabIndex = 35;
            // 
            // title_panel
            // 
            title_panel.BackColor = Color.FromArgb(231, 231, 231);
            title_panel.BorderRadius = 30;
            title_panel.Controls.Add(title_label);
            title_panel.Location = new Point(396, 216);
            title_panel.Name = "title_panel";
            title_panel.Size = new Size(469, 98);
            title_panel.TabIndex = 38;
            // 
            // title_label
            // 
            title_label.BackColor = Color.FromArgb(231, 231, 231);
            title_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            title_label.ImageAlign = ContentAlignment.MiddleRight;
            title_label.Location = new Point(0, 8);
            title_label.Name = "title_label";
            title_label.Size = new Size(447, 78);
            title_label.TabIndex = 18;
            title_label.Text = "     Join Your Gang";
            title_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // standard_mode_btn
            // 
            standard_mode_btn.BackColor = SystemColors.Window;
            standard_mode_btn.BackgroundColor = SystemColors.Window;
            standard_mode_btn.BorderColor = Color.PaleVioletRed;
            standard_mode_btn.BorderRadius = 40;
            standard_mode_btn.BorderSize = 0;
            standard_mode_btn.FlatAppearance.BorderSize = 0;
            standard_mode_btn.FlatStyle = FlatStyle.Flat;
            standard_mode_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            standard_mode_btn.ForeColor = Color.Black;
            standard_mode_btn.Location = new Point(408, 334);
            standard_mode_btn.Name = "standard_mode_btn";
            standard_mode_btn.Size = new Size(162, 177);
            standard_mode_btn.TabIndex = 40;
            standard_mode_btn.Text = "Standard Mode";
            standard_mode_btn.TextColor = Color.Black;
            standard_mode_btn.UseVisualStyleBackColor = false;
            standard_mode_btn.Click += standard_mode_btn_Click;
            // 
            // wild_mode_btn
            // 
            wild_mode_btn.BackColor = SystemColors.Window;
            wild_mode_btn.BackgroundColor = SystemColors.Window;
            wild_mode_btn.BorderColor = Color.PaleVioletRed;
            wild_mode_btn.BorderRadius = 40;
            wild_mode_btn.BorderSize = 0;
            wild_mode_btn.FlatAppearance.BorderSize = 0;
            wild_mode_btn.FlatStyle = FlatStyle.Flat;
            wild_mode_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            wild_mode_btn.ForeColor = Color.Black;
            wild_mode_btn.Location = new Point(692, 334);
            wild_mode_btn.Name = "wild_mode_btn";
            wild_mode_btn.Size = new Size(162, 177);
            wild_mode_btn.TabIndex = 39;
            wild_mode_btn.Text = "Wild Mode";
            wild_mode_btn.TextColor = Color.Black;
            wild_mode_btn.UseVisualStyleBackColor = false;
            wild_mode_btn.Click += wild_mode_btn_Click;
            // 
            // join_room_btn
            // 
            join_room_btn.BackColor = Color.FromArgb(25, 1, 82);
            join_room_btn.BackgroundColor = Color.FromArgb(25, 1, 82);
            join_room_btn.BorderColor = Color.PaleVioletRed;
            join_room_btn.BorderRadius = 40;
            join_room_btn.BorderSize = 0;
            join_room_btn.FlatAppearance.BorderSize = 0;
            join_room_btn.FlatStyle = FlatStyle.Flat;
            join_room_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            join_room_btn.ForeColor = Color.White;
            join_room_btn.Location = new Point(408, 537);
            join_room_btn.Name = "join_room_btn";
            join_room_btn.Size = new Size(447, 78);
            join_room_btn.TabIndex = 41;
            join_room_btn.Text = "Have Fun!";
            join_room_btn.TextColor = Color.White;
            join_room_btn.UseVisualStyleBackColor = false;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.Transparent;
            back_btn.BackgroundColor = Color.Transparent;
            back_btn.BorderColor = Color.PaleVioletRed;
            back_btn.BorderRadius = 40;
            back_btn.BorderSize = 0;
            back_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatStyle = FlatStyle.Flat;
            back_btn.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            back_btn.ForeColor = Color.Black;
            back_btn.Image = (Image)resources.GetObject("back_btn.Image");
            back_btn.ImageAlign = ContentAlignment.MiddleLeft;
            back_btn.Location = new Point(12, 12);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(145, 50);
            back_btn.TabIndex = 42;
            back_btn.Text = "Back";
            back_btn.TextAlign = ContentAlignment.MiddleRight;
            back_btn.TextColor = Color.Black;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Join_Room_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(back_btn);
            Controls.Add(join_room_btn);
            Controls.Add(standard_mode_btn);
            Controls.Add(wild_mode_btn);
            Controls.Add(img2);
            Controls.Add(img3);
            Controls.Add(img1);
            Controls.Add(title_panel);
            Controls.Add(player_name_label);
            Controls.Add(Game_Name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Join_Room_2";
            Text = "Join_Room_2";
            Load += Join_Room_2_Load;
            title_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label player_name_label;
        private Label Game_Name;
        private Label img2;
        private Label img3;
        private Label img1;
        private RPanel title_panel;
        private Label title_label;
        private RJButton standard_mode_btn;
        private RJButton wild_mode_btn;
        private RJButton join_room_btn;
        private RJButton back_btn;
    }
}
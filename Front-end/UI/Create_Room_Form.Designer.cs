namespace Demo_Project
{
    partial class Create_Room_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Room_Form));
            title = new Label();
            rPanel1 = new RPanel();
            img2 = new Label();
            img3 = new Label();
            img1 = new Label();
            title_label = new Label();
            num_player_panel = new RPanel();
            decrease_player_btn = new Button();
            increase_player_btn = new Button();
            label4 = new Label();
            num_player_label = new Label();
            round_time_panel = new RPanel();
            label1 = new Label();
            decrease_time_btn = new Button();
            increase_time_btn = new Button();
            round_time_label = new Label();
            num_round_panel = new RPanel();
            decrease_round_btn = new Button();
            num_round_label = new Label();
            increase_round_btn = new Button();
            label2 = new Label();
            create_room_btn = new RJButton();
            wild_mode_btn = new RJButton();
            standard_mode_btn = new RJButton();
            back_btn = new RJButton();
            rPanel1.SuspendLayout();
            num_player_panel.SuspendLayout();
            round_time_panel.SuspendLayout();
            num_round_panel.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Image = (Image)resources.GetObject("title.Image");
            title.ImageAlign = ContentAlignment.MiddleLeft;
            title.Location = new Point(467, 24);
            title.Name = "title";
            title.Size = new Size(339, 121);
            title.TabIndex = 3;
            title.Text = "FilLmao";
            title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rPanel1
            // 
            rPanel1.BackColor = Color.FromArgb(231, 231, 231);
            rPanel1.BorderRadius = 30;
            rPanel1.Controls.Add(img2);
            rPanel1.Controls.Add(img3);
            rPanel1.Controls.Add(img1);
            rPanel1.Controls.Add(title_label);
            rPanel1.Location = new Point(376, 161);
            rPanel1.Name = "rPanel1";
            rPanel1.Size = new Size(517, 98);
            rPanel1.TabIndex = 21;
            // 
            // img2
            // 
            img2.BackColor = Color.FromArgb(231, 231, 231);
            img2.Image = (Image)resources.GetObject("img2.Image");
            img2.Location = new Point(398, 17);
            img2.Name = "img2";
            img2.Size = new Size(51, 73);
            img2.TabIndex = 19;
            // 
            // img3
            // 
            img3.BackColor = Color.FromArgb(231, 231, 231);
            img3.Image = (Image)resources.GetObject("img3.Image");
            img3.Location = new Point(442, 22);
            img3.Name = "img3";
            img3.Size = new Size(53, 68);
            img3.TabIndex = 20;
            // 
            // img1
            // 
            img1.BackColor = Color.FromArgb(231, 231, 231);
            img1.Image = (Image)resources.GetObject("img1.Image");
            img1.Location = new Point(344, 17);
            img1.Name = "img1";
            img1.Size = new Size(62, 73);
            img1.TabIndex = 18;
            // 
            // title_label
            // 
            title_label.BackColor = Color.FromArgb(231, 231, 231);
            title_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            title_label.ImageAlign = ContentAlignment.MiddleRight;
            title_label.Location = new Point(12, 4);
            title_label.Name = "title_label";
            title_label.Size = new Size(492, 91);
            title_label.TabIndex = 17;
            title_label.Text = "Create A New Room";
            title_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // num_player_panel
            // 
            num_player_panel.BackColor = Color.White;
            num_player_panel.BorderRadius = 20;
            num_player_panel.Controls.Add(decrease_player_btn);
            num_player_panel.Controls.Add(increase_player_btn);
            num_player_panel.Controls.Add(label4);
            num_player_panel.Controls.Add(num_player_label);
            num_player_panel.Location = new Point(239, 278);
            num_player_panel.Name = "num_player_panel";
            num_player_panel.Size = new Size(379, 65);
            num_player_panel.TabIndex = 22;
            // 
            // decrease_player_btn
            // 
            decrease_player_btn.BackColor = Color.White;
            decrease_player_btn.FlatAppearance.BorderSize = 0;
            decrease_player_btn.FlatStyle = FlatStyle.Flat;
            decrease_player_btn.Image = (Image)resources.GetObject("decrease_player_btn.Image");
            decrease_player_btn.Location = new Point(303, 20);
            decrease_player_btn.Name = "decrease_player_btn";
            decrease_player_btn.Size = new Size(36, 35);
            decrease_player_btn.TabIndex = 24;
            decrease_player_btn.UseVisualStyleBackColor = false;
            decrease_player_btn.Click += decrease_player_btn_Click;
            // 
            // increase_player_btn
            // 
            increase_player_btn.BackColor = Color.White;
            increase_player_btn.FlatAppearance.BorderSize = 0;
            increase_player_btn.FlatStyle = FlatStyle.Flat;
            increase_player_btn.Image = (Image)resources.GetObject("increase_player_btn.Image");
            increase_player_btn.Location = new Point(335, 20);
            increase_player_btn.Name = "increase_player_btn";
            increase_player_btn.Size = new Size(36, 35);
            increase_player_btn.TabIndex = 22;
            increase_player_btn.UseVisualStyleBackColor = false;
            increase_player_btn.Click += increase_player_btn_Click;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(8, 10);
            label4.Name = "label4";
            label4.Size = new Size(56, 45);
            label4.TabIndex = 23;
            // 
            // num_player_label
            // 
            num_player_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            num_player_label.Location = new Point(60, 14);
            num_player_label.Name = "num_player_label";
            num_player_label.Size = new Size(237, 38);
            num_player_label.TabIndex = 25;
            num_player_label.Text = "Number of players: 3";
            num_player_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // round_time_panel
            // 
            round_time_panel.BackColor = Color.White;
            round_time_panel.BorderRadius = 20;
            round_time_panel.Controls.Add(label1);
            round_time_panel.Controls.Add(decrease_time_btn);
            round_time_panel.Controls.Add(increase_time_btn);
            round_time_panel.Controls.Add(round_time_label);
            round_time_panel.Location = new Point(671, 278);
            round_time_panel.Name = "round_time_panel";
            round_time_panel.Size = new Size(379, 65);
            round_time_panel.TabIndex = 23;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(56, 45);
            label1.TabIndex = 23;
            // 
            // decrease_time_btn
            // 
            decrease_time_btn.BackColor = Color.White;
            decrease_time_btn.FlatAppearance.BorderSize = 0;
            decrease_time_btn.FlatStyle = FlatStyle.Flat;
            decrease_time_btn.Image = (Image)resources.GetObject("decrease_time_btn.Image");
            decrease_time_btn.Location = new Point(296, 20);
            decrease_time_btn.Name = "decrease_time_btn";
            decrease_time_btn.Size = new Size(36, 35);
            decrease_time_btn.TabIndex = 25;
            decrease_time_btn.UseVisualStyleBackColor = false;
            decrease_time_btn.Click += decrease_time_btn_Click;
            // 
            // increase_time_btn
            // 
            increase_time_btn.BackColor = Color.White;
            increase_time_btn.FlatAppearance.BorderSize = 0;
            increase_time_btn.FlatStyle = FlatStyle.Flat;
            increase_time_btn.Image = (Image)resources.GetObject("increase_time_btn.Image");
            increase_time_btn.Location = new Point(328, 20);
            increase_time_btn.Name = "increase_time_btn";
            increase_time_btn.Size = new Size(36, 35);
            increase_time_btn.TabIndex = 24;
            increase_time_btn.UseVisualStyleBackColor = false;
            increase_time_btn.Click += increase_time_btn_Click;
            // 
            // round_time_label
            // 
            round_time_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            round_time_label.Location = new Point(66, 14);
            round_time_label.Name = "round_time_label";
            round_time_label.Size = new Size(237, 38);
            round_time_label.TabIndex = 26;
            round_time_label.Text = "Round time: 30s";
            round_time_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // num_round_panel
            // 
            num_round_panel.BackColor = SystemColors.Window;
            num_round_panel.BorderRadius = 20;
            num_round_panel.Controls.Add(decrease_round_btn);
            num_round_panel.Controls.Add(num_round_label);
            num_round_panel.Controls.Add(increase_round_btn);
            num_round_panel.Controls.Add(label2);
            num_round_panel.Location = new Point(671, 376);
            num_round_panel.Name = "num_round_panel";
            num_round_panel.Size = new Size(379, 65);
            num_round_panel.TabIndex = 24;
            // 
            // decrease_round_btn
            // 
            decrease_round_btn.BackColor = Color.White;
            decrease_round_btn.FlatAppearance.BorderSize = 0;
            decrease_round_btn.FlatStyle = FlatStyle.Flat;
            decrease_round_btn.Image = (Image)resources.GetObject("decrease_round_btn.Image");
            decrease_round_btn.Location = new Point(296, 19);
            decrease_round_btn.Name = "decrease_round_btn";
            decrease_round_btn.Size = new Size(36, 35);
            decrease_round_btn.TabIndex = 27;
            decrease_round_btn.UseVisualStyleBackColor = false;
            decrease_round_btn.Click += decrease_round_btn_Click;
            // 
            // num_round_label
            // 
            num_round_label.BackColor = Color.White;
            num_round_label.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            num_round_label.Location = new Point(62, 10);
            num_round_label.Name = "num_round_label";
            num_round_label.Size = new Size(241, 45);
            num_round_label.TabIndex = 25;
            num_round_label.Text = "Number of rounds: 3";
            num_round_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // increase_round_btn
            // 
            increase_round_btn.BackColor = Color.White;
            increase_round_btn.FlatAppearance.BorderSize = 0;
            increase_round_btn.FlatStyle = FlatStyle.Flat;
            increase_round_btn.Image = (Image)resources.GetObject("increase_round_btn.Image");
            increase_round_btn.Location = new Point(328, 19);
            increase_round_btn.Name = "increase_round_btn";
            increase_round_btn.Size = new Size(36, 35);
            increase_round_btn.TabIndex = 28;
            increase_round_btn.UseVisualStyleBackColor = false;
            increase_round_btn.Click += increase_round_btn_Click;
            // 
            // label2
            // 
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(10, 4);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(65, 60);
            label2.TabIndex = 26;
            // 
            // create_room_btn
            // 
            create_room_btn.BackColor = Color.FromArgb(25, 1, 82);
            create_room_btn.BackgroundColor = Color.FromArgb(25, 1, 82);
            create_room_btn.BorderColor = Color.PaleVioletRed;
            create_room_btn.BorderRadius = 40;
            create_room_btn.BorderSize = 0;
            create_room_btn.FlatAppearance.BorderSize = 0;
            create_room_btn.FlatStyle = FlatStyle.Flat;
            create_room_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            create_room_btn.ForeColor = Color.White;
            create_room_btn.Location = new Point(671, 475);
            create_room_btn.Name = "create_room_btn";
            create_room_btn.Size = new Size(379, 78);
            create_room_btn.TabIndex = 25;
            create_room_btn.Text = "Create Room";
            create_room_btn.TextColor = Color.White;
            create_room_btn.UseVisualStyleBackColor = false;
            create_room_btn.Click += create_room_btn_Click;
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
            wild_mode_btn.ImageAlign = ContentAlignment.BottomCenter;
            wild_mode_btn.Location = new Point(456, 376);
            wild_mode_btn.Name = "wild_mode_btn";
            wild_mode_btn.Size = new Size(162, 177);
            wild_mode_btn.TabIndex = 26;
            wild_mode_btn.Text = "Wild Mode";
            wild_mode_btn.TextColor = Color.Black;
            wild_mode_btn.UseVisualStyleBackColor = false;
            wild_mode_btn.Click += wild_mode_btn_Click;
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
            standard_mode_btn.ImageAlign = ContentAlignment.BottomCenter;
            standard_mode_btn.Location = new Point(239, 376);
            standard_mode_btn.Name = "standard_mode_btn";
            standard_mode_btn.Size = new Size(162, 177);
            standard_mode_btn.TabIndex = 27;
            standard_mode_btn.Text = "Standard Mode";
            standard_mode_btn.TextColor = Color.Black;
            standard_mode_btn.UseVisualStyleBackColor = false;
            standard_mode_btn.Click += standard_mode_btn_Click;
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
            back_btn.TabIndex = 28;
            back_btn.Text = "Back";
            back_btn.TextAlign = ContentAlignment.MiddleRight;
            back_btn.TextColor = Color.Black;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Create_Room_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(back_btn);
            Controls.Add(standard_mode_btn);
            Controls.Add(wild_mode_btn);
            Controls.Add(create_room_btn);
            Controls.Add(num_round_panel);
            Controls.Add(round_time_panel);
            Controls.Add(num_player_panel);
            Controls.Add(rPanel1);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Create_Room_Form";
            Text = "Create Room";
            Load += Create_Room_Form_Load;
            rPanel1.ResumeLayout(false);
            num_player_panel.ResumeLayout(false);
            round_time_panel.ResumeLayout(false);
            num_round_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private RPanel rPanel1;
        private Label img2;
        private Label img3;
        private Label img1;
        private Label title_label;
        private RPanel num_player_panel;
        private Button decrease_player_btn;
        private Button increase_player_btn;
        private Label label4;
        private Label num_player_label;
        private RPanel round_time_panel;
        private Label label1;
        private Button decrease_time_btn;
        private Button increase_time_btn;
        private Label round_time_label;
        private RPanel num_round_panel;
        private Button decrease_round_btn;
        private Label num_round_label;
        private Button increase_round_btn;
        private Label label2;
        private RJButton create_room_btn;
        private RJButton wild_mode_btn;
        private RJButton standard_mode_btn;
        private RJButton back_btn;
    }
}
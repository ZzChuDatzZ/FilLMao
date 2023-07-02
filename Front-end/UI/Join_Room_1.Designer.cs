namespace Demo_Project
{
    partial class Join_Room_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Join_Room_1));
            img2 = new Label();
            img3 = new Label();
            img1 = new Label();
            title_label = new Label();
            title = new Label();
            player_name_label = new Label();
            rPanel2 = new RPanel();
            join_room_btn = new RJButton();
            input_code_panel = new RPanel();
            input_code_box = new TextBox();
            back_btn = new RJButton();
            rPanel2.SuspendLayout();
            input_code_panel.SuspendLayout();
            SuspendLayout();
            // 
            // img2
            // 
            img2.BackColor = Color.FromArgb(231, 231, 231);
            img2.Image = (Image)resources.GetObject("img2.Image");
            img2.Location = new Point(764, 278);
            img2.Name = "img2";
            img2.Size = new Size(51, 73);
            img2.TabIndex = 20;
            // 
            // img3
            // 
            img3.BackColor = Color.FromArgb(231, 231, 231);
            img3.Image = (Image)resources.GetObject("img3.Image");
            img3.Location = new Point(809, 278);
            img3.Name = "img3";
            img3.Size = new Size(53, 68);
            img3.TabIndex = 21;
            // 
            // img1
            // 
            img1.BackColor = Color.FromArgb(231, 231, 231);
            img1.Image = (Image)resources.GetObject("img1.Image");
            img1.Location = new Point(711, 278);
            img1.Name = "img1";
            img1.Size = new Size(62, 73);
            img1.TabIndex = 19;
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
            // title
            // 
            title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Image = (Image)resources.GetObject("title.Image");
            title.ImageAlign = ContentAlignment.MiddleLeft;
            title.Location = new Point(458, 9);
            title.Name = "title";
            title.Size = new Size(339, 121);
            title.TabIndex = 17;
            title.Text = "FilLmao";
            title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // player_name_label
            // 
            player_name_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            player_name_label.Image = (Image)resources.GetObject("player_name_label.Image");
            player_name_label.ImageAlign = ContentAlignment.MiddleRight;
            player_name_label.Location = new Point(549, 168);
            player_name_label.Name = "player_name_label";
            player_name_label.Size = new Size(224, 68);
            player_name_label.TabIndex = 24;
            player_name_label.Text = "Player";
            player_name_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rPanel2
            // 
            rPanel2.BackColor = Color.FromArgb(231, 231, 231);
            rPanel2.BorderRadius = 30;
            rPanel2.Controls.Add(title_label);
            rPanel2.Location = new Point(418, 265);
            rPanel2.Name = "rPanel2";
            rPanel2.Size = new Size(466, 98);
            rPanel2.TabIndex = 30;
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
            join_room_btn.Location = new Point(428, 513);
            join_room_btn.Name = "join_room_btn";
            join_room_btn.Size = new Size(447, 78);
            join_room_btn.TabIndex = 31;
            join_room_btn.Text = "Have Fun!";
            join_room_btn.TextColor = Color.White;
            join_room_btn.UseVisualStyleBackColor = false;
            join_room_btn.Click += join_room_btn_Click;
            // 
            // input_code_panel
            // 
            input_code_panel.BackColor = SystemColors.Window;
            input_code_panel.BorderRadius = 20;
            input_code_panel.Controls.Add(input_code_box);
            input_code_panel.Location = new Point(428, 399);
            input_code_panel.Name = "input_code_panel";
            input_code_panel.Size = new Size(447, 74);
            input_code_panel.TabIndex = 38;
            input_code_panel.Paint += input_code_panel_Paint;
            // 
            // input_code_box
            // 
            input_code_box.BorderStyle = BorderStyle.None;
            input_code_box.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            input_code_box.Location = new Point(29, 20);
            input_code_box.Name = "input_code_box";
            input_code_box.PlaceholderText = "Enter room's code";
            input_code_box.Size = new Size(400, 31);
            input_code_box.TabIndex = 0;
            input_code_box.TextAlign = HorizontalAlignment.Center;
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
            back_btn.TabIndex = 39;
            back_btn.Text = "Back";
            back_btn.TextAlign = ContentAlignment.MiddleRight;
            back_btn.TextColor = Color.Black;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Join_Room_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(back_btn);
            Controls.Add(input_code_panel);
            Controls.Add(join_room_btn);
            Controls.Add(player_name_label);
            Controls.Add(img2);
            Controls.Add(img3);
            Controls.Add(img1);
            Controls.Add(title);
            Controls.Add(rPanel2);
            ForeColor = Color.FromArgb(0, 0, 0, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Join_Room_1";
            Text = "Join_Room_1";
            Load += Join_Room_1_Load;
            rPanel2.ResumeLayout(false);
            input_code_panel.ResumeLayout(false);
            input_code_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label img2;
        private Label img3;
        private Label img1;
        private Label title_label;
        private Label title;
        private Label player_name_label;
        private RPanel rPanel2;
        private RJButton join_room_btn;
        private RPanel input_code_panel;
        private TextBox input_code_box;
        private RJButton back_btn;
    }
}
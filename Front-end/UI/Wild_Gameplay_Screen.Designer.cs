namespace Demo_Project
{
    partial class Wild_Gameplay_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wild_Gameplay_Screen));
            question_panel = new RPanel();
            question_label = new Label();
            game_name = new Label();
            time_label = new Label();
            rPanel1 = new RPanel();
            label1 = new Label();
            salt_img = new Label();
            ans_box = new RJTextBox();
            ready_btn = new RJButton();
            title = new Label();
            scoreboard_panel = new RPanel();
            top_score_panel = new RPanel();
            top1_score = new Label();
            top3_score = new Label();
            top2_score = new Label();
            top_player_panel = new RPanel();
            top1 = new Label();
            top3 = new Label();
            top2 = new Label();
            scoreboard_label = new Label();
            question_panel.SuspendLayout();
            rPanel1.SuspendLayout();
            scoreboard_panel.SuspendLayout();
            top_score_panel.SuspendLayout();
            top_player_panel.SuspendLayout();
            SuspendLayout();
            // 
            // question_panel
            // 
            question_panel.BackColor = Color.Black;
            question_panel.BorderRadius = 20;
            question_panel.Controls.Add(question_label);
            question_panel.Location = new Point(455, 125);
            question_panel.Name = "question_panel";
            question_panel.Size = new Size(186, 234);
            question_panel.TabIndex = 41;
            // 
            // question_label
            // 
            question_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            question_label.ForeColor = Color.White;
            question_label.Location = new Point(0, 0);
            question_label.Name = "question_label";
            question_label.Size = new Size(186, 234);
            question_label.TabIndex = 16;
            question_label.Text = "fill me with _____________________";
            // 
            // game_name
            // 
            game_name.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            game_name.Image = (Image)resources.GetObject("game_name.Image");
            game_name.ImageAlign = ContentAlignment.MiddleLeft;
            game_name.Location = new Point(12, 9);
            game_name.Name = "game_name";
            game_name.Size = new Size(264, 112);
            game_name.TabIndex = 42;
            game_name.Text = "FilLmao";
            game_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // time_label
            // 
            time_label.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            time_label.Image = (Image)resources.GetObject("time_label.Image");
            time_label.ImageAlign = ContentAlignment.MiddleLeft;
            time_label.Location = new Point(420, 9);
            time_label.Name = "time_label";
            time_label.Size = new Size(301, 65);
            time_label.TabIndex = 43;
            time_label.Text = "5:00";
            time_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel1
            // 
            rPanel1.BackColor = SystemColors.Window;
            rPanel1.BorderRadius = 30;
            rPanel1.Controls.Add(label1);
            rPanel1.Controls.Add(salt_img);
            rPanel1.Controls.Add(ans_box);
            rPanel1.Controls.Add(ready_btn);
            rPanel1.Controls.Add(title);
            rPanel1.Location = new Point(115, 396);
            rPanel1.Name = "rPanel1";
            rPanel1.Size = new Size(1004, 265);
            rPanel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(0, 74);
            label1.Name = "label1";
            label1.Size = new Size(79, 94);
            label1.TabIndex = 47;
            // 
            // salt_img
            // 
            salt_img.Image = (Image)resources.GetObject("salt_img.Image");
            salt_img.Location = new Point(340, -10);
            salt_img.Name = "salt_img";
            salt_img.Size = new Size(79, 94);
            salt_img.TabIndex = 46;
            // 
            // ans_box
            // 
            ans_box.BackColor = SystemColors.Window;
            ans_box.BorderColor = SystemColors.Highlight;
            ans_box.BorderFocusColor = Color.HotPink;
            ans_box.BorderRadius = 0;
            ans_box.BorderSize = 2;
            ans_box.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            ans_box.Location = new Point(97, 107);
            ans_box.Margin = new Padding(4);
            ans_box.Multiline = false;
            ans_box.Name = "ans_box";
            ans_box.Padding = new Padding(7);
            ans_box.PasswordChar = false;
            ans_box.PlaceholderColor = Color.DarkGray;
            ans_box.PlaceholderText = "";
            ans_box.Size = new Size(859, 60);
            ans_box.TabIndex = 47;
            ans_box.Texts = "";
            ans_box.UnderlinedStyle = true;
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
            ready_btn.Location = new Point(776, 186);
            ready_btn.Name = "ready_btn";
            ready_btn.Size = new Size(192, 66);
            ready_btn.TabIndex = 45;
            ready_btn.Text = "Submit";
            ready_btn.TextColor = Color.White;
            ready_btn.UseVisualStyleBackColor = false;
            ready_btn.Click += ready_btn_Click;
            // 
            // title
            // 
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            title.ImageAlign = ContentAlignment.MiddleLeft;
            title.Location = new Point(0, -10);
            title.Name = "title";
            title.Size = new Size(526, 94);
            title.TabIndex = 46;
            title.Text = "Write some lmao idea           :";
            title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // scoreboard_panel
            // 
            scoreboard_panel.BackColor = Color.FromArgb(231, 231, 231);
            scoreboard_panel.BorderRadius = 20;
            scoreboard_panel.Controls.Add(top_score_panel);
            scoreboard_panel.Controls.Add(top_player_panel);
            scoreboard_panel.Controls.Add(scoreboard_label);
            scoreboard_panel.Location = new Point(782, 78);
            scoreboard_panel.Name = "scoreboard_panel";
            scoreboard_panel.Size = new Size(468, 296);
            scoreboard_panel.TabIndex = 45;
            // 
            // top_score_panel
            // 
            top_score_panel.BackColor = Color.FromArgb(25, 1, 82);
            top_score_panel.BorderRadius = 10;
            top_score_panel.Controls.Add(top1_score);
            top_score_panel.Controls.Add(top3_score);
            top_score_panel.Controls.Add(top2_score);
            top_score_panel.Location = new Point(327, 77);
            top_score_panel.Name = "top_score_panel";
            top_score_panel.Size = new Size(123, 200);
            top_score_panel.TabIndex = 47;
            // 
            // top1_score
            // 
            top1_score.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            top1_score.ForeColor = SystemColors.Window;
            top1_score.Location = new Point(28, 24);
            top1_score.Name = "top1_score";
            top1_score.Size = new Size(60, 38);
            top1_score.TabIndex = 43;
            top1_score.Text = "1st";
            top1_score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // top3_score
            // 
            top3_score.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            top3_score.ForeColor = SystemColors.Window;
            top3_score.Location = new Point(28, 137);
            top3_score.Name = "top3_score";
            top3_score.Size = new Size(60, 51);
            top3_score.TabIndex = 45;
            top3_score.Text = "3rd. Player3";
            top3_score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // top2_score
            // 
            top2_score.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            top2_score.ForeColor = SystemColors.Window;
            top2_score.Location = new Point(28, 80);
            top2_score.Name = "top2_score";
            top2_score.Size = new Size(67, 43);
            top2_score.TabIndex = 44;
            top2_score.Text = "2nd";
            top2_score.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // top_player_panel
            // 
            top_player_panel.BackColor = Color.FromArgb(25, 1, 82);
            top_player_panel.BorderRadius = 10;
            top_player_panel.Controls.Add(top1);
            top_player_panel.Controls.Add(top3);
            top_player_panel.Controls.Add(top2);
            top_player_panel.Location = new Point(39, 77);
            top_player_panel.Name = "top_player_panel";
            top_player_panel.Size = new Size(250, 200);
            top_player_panel.TabIndex = 46;
            // 
            // top1
            // 
            top1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            top1.ForeColor = SystemColors.Window;
            top1.Location = new Point(35, 24);
            top1.Name = "top1";
            top1.Size = new Size(164, 38);
            top1.TabIndex = 43;
            top1.Text = "1st. Player1";
            top1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // top3
            // 
            top3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            top3.ForeColor = SystemColors.Window;
            top3.Location = new Point(35, 137);
            top3.Name = "top3";
            top3.Size = new Size(164, 51);
            top3.TabIndex = 45;
            top3.Text = "3rd. Player3";
            top3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // top2
            // 
            top2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            top2.ForeColor = SystemColors.Window;
            top2.Location = new Point(35, 80);
            top2.Name = "top2";
            top2.Size = new Size(171, 43);
            top2.TabIndex = 44;
            top2.Text = "2nd. Player2";
            top2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scoreboard_label
            // 
            scoreboard_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scoreboard_label.Image = (Image)resources.GetObject("scoreboard_label.Image");
            scoreboard_label.ImageAlign = ContentAlignment.MiddleRight;
            scoreboard_label.Location = new Point(39, 10);
            scoreboard_label.Name = "scoreboard_label";
            scoreboard_label.Size = new Size(394, 64);
            scoreboard_label.TabIndex = 42;
            scoreboard_label.Text = "Leader Scoreboard ";
            scoreboard_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Wild_Gameplay_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(scoreboard_panel);
            Controls.Add(time_label);
            Controls.Add(game_name);
            Controls.Add(question_panel);
            Controls.Add(rPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Wild_Gameplay_Screen";
            Text = "Wild_Gameplay_Screen";
            Load += Wild_Gameplay_Screen_Load;
            question_panel.ResumeLayout(false);
            rPanel1.ResumeLayout(false);
            scoreboard_panel.ResumeLayout(false);
            top_score_panel.ResumeLayout(false);
            top_player_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RPanel question_panel;
        private Label question_label;
        private Label game_name;
        private Label time_label;
        private RPanel rPanel1;
        private RJButton ready_btn;
        private Label title;
        private RJTextBox ans_box;
        private RPanel scoreboard_panel;
        private RPanel top_score_panel;
        private Label top1_score;
        private Label top3_score;
        private Label top2_score;
        private RPanel top_player_panel;
        private Label top1;
        private Label top3;
        private Label top2;
        private Label scoreboard_label;
        private Label label1;
        private Label salt_img;
    }
}
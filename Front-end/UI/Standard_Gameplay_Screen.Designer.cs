namespace Demo_Project
{
    partial class Standard_Gameplay_Screen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Standard_Gameplay_Screen));
            rPanel1 = new RPanel();
            ans4 = new RJButton();
            ans2 = new RJButton();
            ans3 = new RJButton();
            ans1 = new RJButton();
            time_label = new Label();
            title = new Label();
            choice_panel = new RPanel();
            choice_label = new Label();
            scoreboard_panel = new RPanel();
            rPanel3 = new RPanel();
            top1_score = new Label();
            top3_score = new Label();
            top2_score = new Label();
            rPanel2 = new RPanel();
            top1 = new Label();
            top3 = new Label();
            top2 = new Label();
            scoreboard_label = new Label();
            countDownTimer = new System.Windows.Forms.Timer(components);
            rPanel1.SuspendLayout();
            choice_panel.SuspendLayout();
            scoreboard_panel.SuspendLayout();
            rPanel3.SuspendLayout();
            rPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // rPanel1
            // 
            rPanel1.BackColor = Color.FromArgb(79, 83, 103);
            rPanel1.BorderRadius = 30;
            rPanel1.Controls.Add(ans4);
            rPanel1.Controls.Add(ans2);
            rPanel1.Controls.Add(ans3);
            rPanel1.Controls.Add(ans1);
            rPanel1.Location = new Point(513, 112);
            rPanel1.Name = "rPanel1";
            rPanel1.Size = new Size(727, 536);
            rPanel1.TabIndex = 37;
            // 
            // ans4
            // 
            ans4.BackColor = SystemColors.Window;
            ans4.BackgroundColor = SystemColors.Window;
            ans4.BorderColor = Color.Black;
            ans4.BorderRadius = 45;
            ans4.BorderSize = 2;
            ans4.FlatAppearance.BorderSize = 0;
            ans4.FlatStyle = FlatStyle.Flat;
            ans4.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            ans4.ForeColor = Color.Black;
            ans4.Location = new Point(479, 283);
            ans4.Name = "ans4";
            ans4.Size = new Size(186, 234);
            ans4.TabIndex = 23;
            ans4.Text = "Answer4";
            ans4.TextAlign = ContentAlignment.TopLeft;
            ans4.TextColor = Color.Black;
            ans4.UseVisualStyleBackColor = false;
            ans4.Click += ans4_Click;
            // 
            // ans2
            // 
            ans2.BackColor = SystemColors.Window;
            ans2.BackgroundColor = SystemColors.Window;
            ans2.BorderColor = Color.Black;
            ans2.BorderRadius = 45;
            ans2.BorderSize = 2;
            ans2.FlatAppearance.BorderSize = 0;
            ans2.FlatStyle = FlatStyle.Flat;
            ans2.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            ans2.ForeColor = Color.Black;
            ans2.Location = new Point(484, 26);
            ans2.Name = "ans2";
            ans2.Size = new Size(181, 234);
            ans2.TabIndex = 21;
            ans2.Text = "Answer 2";
            ans2.TextAlign = ContentAlignment.TopLeft;
            ans2.TextColor = Color.Black;
            ans2.UseVisualStyleBackColor = false;
            ans2.Click += ans2_Click;
            // 
            // ans3
            // 
            ans3.BackColor = SystemColors.Window;
            ans3.BackgroundColor = SystemColors.Window;
            ans3.BorderColor = Color.Black;
            ans3.BorderRadius = 45;
            ans3.BorderSize = 2;
            ans3.FlatAppearance.BorderSize = 0;
            ans3.FlatStyle = FlatStyle.Flat;
            ans3.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            ans3.ForeColor = Color.Black;
            ans3.Location = new Point(122, 283);
            ans3.Name = "ans3";
            ans3.Size = new Size(186, 234);
            ans3.TabIndex = 20;
            ans3.Text = "Answer3";
            ans3.TextAlign = ContentAlignment.TopLeft;
            ans3.TextColor = Color.Black;
            ans3.UseVisualStyleBackColor = false;
            ans3.Click += ans3_Click;
            // 
            // ans1
            // 
            ans1.BackColor = SystemColors.Window;
            ans1.BackgroundColor = SystemColors.Window;
            ans1.BorderColor = Color.Black;
            ans1.BorderRadius = 45;
            ans1.BorderSize = 2;
            ans1.FlatAppearance.BorderSize = 0;
            ans1.FlatStyle = FlatStyle.Flat;
            ans1.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            ans1.ForeColor = Color.Black;
            ans1.Location = new Point(122, 26);
            ans1.Name = "ans1";
            ans1.Size = new Size(186, 234);
            ans1.TabIndex = 19;
            ans1.Text = "Answer 1";
            ans1.TextAlign = ContentAlignment.TopLeft;
            ans1.TextColor = Color.Black;
            ans1.UseVisualStyleBackColor = false;
            ans1.Click += ans1_Click;
            // 
            // time_label
            // 
            time_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            time_label.Image = (Image)resources.GetObject("time_label.Image");
            time_label.ImageAlign = ContentAlignment.MiddleLeft;
            time_label.Location = new Point(744, 21);
            time_label.Name = "time_label";
            time_label.Size = new Size(251, 88);
            time_label.TabIndex = 38;
            time_label.Text = "30s";
            time_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Image = (Image)resources.GetObject("title.Image");
            title.ImageAlign = ContentAlignment.MiddleLeft;
            title.Location = new Point(12, 9);
            title.Name = "title";
            title.Size = new Size(253, 112);
            title.TabIndex = 39;
            title.Text = "FilLmao";
            title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // choice_panel
            // 
            choice_panel.BackColor = Color.Black;
            choice_panel.BorderRadius = 20;
            choice_panel.Controls.Add(choice_label);
            choice_panel.Location = new Point(170, 112);
            choice_panel.Name = "choice_panel";
            choice_panel.Size = new Size(186, 234);
            choice_panel.TabIndex = 40;
            // 
            // choice_label
            // 
            choice_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            choice_label.ForeColor = Color.White;
            choice_label.Location = new Point(0, 0);
            choice_label.Name = "choice_label";
            choice_label.Size = new Size(186, 234);
            choice_label.TabIndex = 16;
            choice_label.Text = "fill me with _______________________";
            // 
            // scoreboard_panel
            // 
            scoreboard_panel.BackColor = Color.FromArgb(231, 231, 231);
            scoreboard_panel.BorderRadius = 20;
            scoreboard_panel.Controls.Add(rPanel3);
            scoreboard_panel.Controls.Add(rPanel2);
            scoreboard_panel.Controls.Add(scoreboard_label);
            scoreboard_panel.Location = new Point(12, 352);
            scoreboard_panel.Name = "scoreboard_panel";
            scoreboard_panel.Size = new Size(468, 296);
            scoreboard_panel.TabIndex = 41;
            // 
            // rPanel3
            // 
            rPanel3.BackColor = Color.FromArgb(25, 1, 82);
            rPanel3.BorderRadius = 10;
            rPanel3.Controls.Add(top1_score);
            rPanel3.Controls.Add(top3_score);
            rPanel3.Controls.Add(top2_score);
            rPanel3.Location = new Point(321, 77);
            rPanel3.Name = "rPanel3";
            rPanel3.Size = new Size(123, 200);
            rPanel3.TabIndex = 47;
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
            // rPanel2
            // 
            rPanel2.BackColor = Color.FromArgb(25, 1, 82);
            rPanel2.BorderRadius = 10;
            rPanel2.Controls.Add(top1);
            rPanel2.Controls.Add(top3);
            rPanel2.Controls.Add(top2);
            rPanel2.Location = new Point(39, 77);
            rPanel2.Name = "rPanel2";
            rPanel2.Size = new Size(250, 200);
            rPanel2.TabIndex = 46;
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
            // countDownTimer
            // 
            countDownTimer.Interval = 1000;
            countDownTimer.Tick += countDownTimer_Tick;
            // 
            // Standard_Gameplay_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(scoreboard_panel);
            Controls.Add(choice_panel);
            Controls.Add(title);
            Controls.Add(time_label);
            Controls.Add(rPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Standard_Gameplay_Screen";
            Text = "Game_Play_Screen";
            Load += Standard_Gameplay_Screen_Load;
            rPanel1.ResumeLayout(false);
            choice_panel.ResumeLayout(false);
            scoreboard_panel.ResumeLayout(false);
            rPanel3.ResumeLayout(false);
            rPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RPanel rPanel1;
        private Label time_label;
        private RJButton ans2;
        private RJButton ans3;
        private RJButton ans1;
        private Label title;
        private RJButton ans4;
        private RPanel choice_panel;
        private Label choice_label;
        private RPanel scoreboard_panel;
        private Label scoreboard_label;
        private RPanel rPanel2;
        private Label top1;
        private Label top3;
        private Label top2;
        private RPanel rPanel3;
        private Label top1_score;
        private Label top3_score;
        private Label top2_score;
        private System.Windows.Forms.Timer countDownTimer;
    }
}
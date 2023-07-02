namespace Demo_Project
{
    partial class Vote_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vote_Screen));
            img2 = new Label();
            img1 = new Label();
            game_name = new Label();
            img3 = new Label();
            title_label = new Label();
            vote_ans3 = new RJButton();
            vote_ans2 = new RJButton();
            vote_ans1 = new RJButton();
            choice_panel = new RPanel();
            choice_label = new Label();
            title_panel = new RPanel();
            vote_ans4 = new RJButton();
            vote_ans5 = new RJButton();
            choice_panel.SuspendLayout();
            title_panel.SuspendLayout();
            SuspendLayout();
            // 
            // img2
            // 
            img2.BackColor = Color.Transparent;
            img2.Image = (Image)resources.GetObject("img2.Image");
            img2.Location = new Point(82, 9);
            img2.Name = "img2";
            img2.Size = new Size(51, 73);
            img2.TabIndex = 34;
            // 
            // img1
            // 
            img1.BackColor = Color.Transparent;
            img1.Image = (Image)resources.GetObject("img1.Image");
            img1.Location = new Point(28, 9);
            img1.Name = "img1";
            img1.Size = new Size(62, 73);
            img1.TabIndex = 33;
            // 
            // game_name
            // 
            game_name.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            game_name.Image = (Image)resources.GetObject("game_name.Image");
            game_name.ImageAlign = ContentAlignment.MiddleLeft;
            game_name.Location = new Point(12, 9);
            game_name.Name = "game_name";
            game_name.Size = new Size(253, 112);
            game_name.TabIndex = 32;
            game_name.Text = "FilLmao";
            game_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // img3
            // 
            img3.BackColor = Color.Transparent;
            img3.Image = (Image)resources.GetObject("img3.Image");
            img3.Location = new Point(129, 9);
            img3.Name = "img3";
            img3.Size = new Size(55, 73);
            img3.TabIndex = 35;
            // 
            // title_label
            // 
            title_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            title_label.Location = new Point(190, 18);
            title_label.Name = "title_label";
            title_label.Size = new Size(500, 55);
            title_label.TabIndex = 36;
            title_label.Text = "Vote The Most \"Lmao\" Answer";
            // 
            // vote_ans3
            // 
            vote_ans3.BackColor = SystemColors.Window;
            vote_ans3.BackgroundColor = SystemColors.Window;
            vote_ans3.BorderColor = Color.Black;
            vote_ans3.BorderRadius = 45;
            vote_ans3.BorderSize = 2;
            vote_ans3.FlatAppearance.BorderSize = 0;
            vote_ans3.FlatStyle = FlatStyle.Flat;
            vote_ans3.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            vote_ans3.ForeColor = Color.Black;
            vote_ans3.Location = new Point(627, 277);
            vote_ans3.Name = "vote_ans3";
            vote_ans3.Size = new Size(189, 274);
            vote_ans3.TabIndex = 40;
            vote_ans3.Text = "None";
            vote_ans3.TextAlign = ContentAlignment.TopLeft;
            vote_ans3.TextColor = Color.Black;
            vote_ans3.UseVisualStyleBackColor = false;
            vote_ans3.Click += vote_ans3_Click;
            // 
            // vote_ans2
            // 
            vote_ans2.BackColor = SystemColors.Window;
            vote_ans2.BackgroundColor = SystemColors.Window;
            vote_ans2.BorderColor = Color.Black;
            vote_ans2.BorderRadius = 45;
            vote_ans2.BorderSize = 2;
            vote_ans2.FlatAppearance.BorderSize = 0;
            vote_ans2.FlatStyle = FlatStyle.Flat;
            vote_ans2.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            vote_ans2.ForeColor = Color.Black;
            vote_ans2.Location = new Point(422, 277);
            vote_ans2.Name = "vote_ans2";
            vote_ans2.Size = new Size(189, 274);
            vote_ans2.TabIndex = 39;
            vote_ans2.Text = "None";
            vote_ans2.TextAlign = ContentAlignment.TopLeft;
            vote_ans2.TextColor = Color.Black;
            vote_ans2.UseVisualStyleBackColor = false;
            vote_ans2.Click += vote_ans2_Click;
            // 
            // vote_ans1
            // 
            vote_ans1.BackColor = SystemColors.Window;
            vote_ans1.BackgroundColor = SystemColors.Window;
            vote_ans1.BorderColor = Color.Black;
            vote_ans1.BorderRadius = 45;
            vote_ans1.BorderSize = 2;
            vote_ans1.FlatAppearance.BorderSize = 0;
            vote_ans1.FlatStyle = FlatStyle.Flat;
            vote_ans1.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            vote_ans1.ForeColor = Color.Black;
            vote_ans1.Location = new Point(218, 274);
            vote_ans1.Name = "vote_ans1";
            vote_ans1.Size = new Size(189, 274);
            vote_ans1.TabIndex = 38;
            vote_ans1.Text = "None";
            vote_ans1.TextAlign = ContentAlignment.TopLeft;
            vote_ans1.TextColor = Color.Black;
            vote_ans1.UseVisualStyleBackColor = false;
            vote_ans1.Click += vote_ans1_Click;
            // 
            // choice_panel
            // 
            choice_panel.BackColor = Color.Black;
            choice_panel.BorderRadius = 20;
            choice_panel.Controls.Add(choice_label);
            choice_panel.Location = new Point(12, 274);
            choice_panel.Name = "choice_panel";
            choice_panel.Size = new Size(192, 274);
            choice_panel.TabIndex = 37;
            // 
            // choice_label
            // 
            choice_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            choice_label.ForeColor = Color.White;
            choice_label.Location = new Point(0, 0);
            choice_label.Name = "choice_label";
            choice_label.Size = new Size(192, 274);
            choice_label.TabIndex = 16;
            choice_label.Text = "fill me with _______________________";
            // 
            // title_panel
            // 
            title_panel.BackColor = Color.FromArgb(231, 231, 231);
            title_panel.BorderRadius = 30;
            title_panel.Controls.Add(img2);
            title_panel.Controls.Add(img3);
            title_panel.Controls.Add(title_label);
            title_panel.Controls.Add(img1);
            title_panel.Location = new Point(271, 114);
            title_panel.Name = "title_panel";
            title_panel.Size = new Size(720, 98);
            title_panel.TabIndex = 41;
            // 
            // vote_ans4
            // 
            vote_ans4.BackColor = SystemColors.Window;
            vote_ans4.BackgroundColor = SystemColors.Window;
            vote_ans4.BorderColor = Color.Black;
            vote_ans4.BorderRadius = 45;
            vote_ans4.BorderSize = 2;
            vote_ans4.FlatAppearance.BorderSize = 0;
            vote_ans4.FlatStyle = FlatStyle.Flat;
            vote_ans4.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            vote_ans4.ForeColor = Color.Black;
            vote_ans4.Location = new Point(828, 277);
            vote_ans4.Name = "vote_ans4";
            vote_ans4.Size = new Size(189, 274);
            vote_ans4.TabIndex = 42;
            vote_ans4.Text = "None";
            vote_ans4.TextAlign = ContentAlignment.TopLeft;
            vote_ans4.TextColor = Color.Black;
            vote_ans4.UseVisualStyleBackColor = false;
            vote_ans4.Click += rjButton1_Click;
            // 
            // vote_ans5
            // 
            vote_ans5.BackColor = SystemColors.Window;
            vote_ans5.BackgroundColor = SystemColors.Window;
            vote_ans5.BorderColor = Color.Black;
            vote_ans5.BorderRadius = 45;
            vote_ans5.BorderSize = 2;
            vote_ans5.FlatAppearance.BorderSize = 0;
            vote_ans5.FlatStyle = FlatStyle.Flat;
            vote_ans5.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            vote_ans5.ForeColor = Color.Black;
            vote_ans5.Location = new Point(1032, 277);
            vote_ans5.Name = "vote_ans5";
            vote_ans5.Size = new Size(189, 274);
            vote_ans5.TabIndex = 43;
            vote_ans5.Text = "None";
            vote_ans5.TextAlign = ContentAlignment.TopLeft;
            vote_ans5.TextColor = Color.Black;
            vote_ans5.UseVisualStyleBackColor = false;
            vote_ans5.Click += rjButton2_Click;
            // 
            // Vote_Screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(vote_ans5);
            Controls.Add(vote_ans4);
            Controls.Add(title_panel);
            Controls.Add(vote_ans3);
            Controls.Add(vote_ans2);
            Controls.Add(vote_ans1);
            Controls.Add(choice_panel);
            Controls.Add(game_name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Vote_Screen";
            Text = "Vote_Screen";
            Load += Vote_Screen_Load;
            choice_panel.ResumeLayout(false);
            title_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label img2;
        private Label img1;
        private Label game_name;
        private Label img3;
        private Label title_label;
        private RJButton vote_ans3;
        private RJButton vote_ans2;
        private RJButton vote_ans1;
        private RPanel choice_panel;
        private Label choice_label;
        private RPanel title_panel;
        private RJButton vote_ans4;
        private RJButton vote_ans5;
    }
}
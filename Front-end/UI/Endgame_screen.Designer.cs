namespace Demo_Project
{
    partial class Endgame_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Endgame_screen));
            game_name = new Label();
            rPanel1 = new RPanel();
            label1 = new Label();
            rPanel4 = new RPanel();
            rPanel8 = new RPanel();
            label7 = new Label();
            player3_pt = new Label();
            Player3_name = new Label();
            rPanel3 = new RPanel();
            rPanel7 = new RPanel();
            label6 = new Label();
            player2_pt = new Label();
            Player2_name = new Label();
            rPanel2 = new RPanel();
            rPanel6 = new RPanel();
            label5 = new Label();
            player1_pt = new Label();
            Player1_name = new Label();
            return_btn = new RJButton();
            exit_btn = new RJButton();
            rPanel1.SuspendLayout();
            rPanel4.SuspendLayout();
            rPanel8.SuspendLayout();
            rPanel3.SuspendLayout();
            rPanel7.SuspendLayout();
            rPanel2.SuspendLayout();
            rPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // game_name
            // 
            game_name.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            game_name.Image = (Image)resources.GetObject("game_name.Image");
            game_name.ImageAlign = ContentAlignment.MiddleLeft;
            game_name.Location = new Point(12, 9);
            game_name.Name = "game_name";
            game_name.Size = new Size(264, 112);
            game_name.TabIndex = 43;
            game_name.Text = "FilLmao";
            game_name.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rPanel1
            // 
            rPanel1.BackColor = SystemColors.Window;
            rPanel1.BorderRadius = 25;
            rPanel1.Controls.Add(label1);
            rPanel1.Controls.Add(rPanel4);
            rPanel1.Controls.Add(rPanel3);
            rPanel1.Controls.Add(rPanel2);
            rPanel1.Location = new Point(317, 83);
            rPanel1.Name = "rPanel1";
            rPanel1.Size = new Size(554, 559);
            rPanel1.TabIndex = 44;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Symbol", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 22);
            label1.Name = "label1";
            label1.Size = new Size(230, 51);
            label1.TabIndex = 48;
            label1.Text = "Scoreboard";
            // 
            // rPanel4
            // 
            rPanel4.BorderRadius = 5;
            rPanel4.Controls.Add(rPanel8);
            rPanel4.Controls.Add(player3_pt);
            rPanel4.Controls.Add(Player3_name);
            rPanel4.Location = new Point(56, 368);
            rPanel4.Name = "rPanel4";
            rPanel4.Size = new Size(450, 88);
            rPanel4.TabIndex = 2;
            // 
            // rPanel8
            // 
            rPanel8.BackColor = Color.FromArgb(231, 231, 231);
            rPanel8.BorderRadius = 10;
            rPanel8.Controls.Add(label7);
            rPanel8.Location = new Point(24, 14);
            rPanel8.Name = "rPanel8";
            rPanel8.Size = new Size(57, 52);
            rPanel8.TabIndex = 50;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 52);
            label7.TabIndex = 49;
            // 
            // player3_pt
            // 
            player3_pt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            player3_pt.Location = new Point(373, 14);
            player3_pt.Name = "player3_pt";
            player3_pt.Size = new Size(61, 52);
            player3_pt.TabIndex = 52;
            player3_pt.Text = "pt";
            player3_pt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Player3_name
            // 
            Player3_name.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Player3_name.Location = new Point(115, 14);
            Player3_name.Name = "Player3_name";
            Player3_name.Size = new Size(238, 52);
            Player3_name.TabIndex = 51;
            Player3_name.Text = "Player's name";
            Player3_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel3
            // 
            rPanel3.BorderRadius = 5;
            rPanel3.Controls.Add(rPanel7);
            rPanel3.Controls.Add(player2_pt);
            rPanel3.Controls.Add(Player2_name);
            rPanel3.Location = new Point(56, 254);
            rPanel3.Name = "rPanel3";
            rPanel3.Size = new Size(450, 88);
            rPanel3.TabIndex = 1;
            // 
            // rPanel7
            // 
            rPanel7.BackColor = Color.FromArgb(231, 231, 231);
            rPanel7.BorderRadius = 10;
            rPanel7.Controls.Add(label6);
            rPanel7.Location = new Point(24, 17);
            rPanel7.Name = "rPanel7";
            rPanel7.Size = new Size(57, 52);
            rPanel7.TabIndex = 49;
            // 
            // label6
            // 
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 52);
            label6.TabIndex = 49;
            // 
            // player2_pt
            // 
            player2_pt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            player2_pt.Location = new Point(373, 17);
            player2_pt.Name = "player2_pt";
            player2_pt.Size = new Size(61, 52);
            player2_pt.TabIndex = 51;
            player2_pt.Text = "pt";
            player2_pt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Player2_name
            // 
            Player2_name.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Player2_name.Location = new Point(115, 17);
            Player2_name.Name = "Player2_name";
            Player2_name.Size = new Size(238, 52);
            Player2_name.TabIndex = 50;
            Player2_name.Text = "Player's name";
            Player2_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rPanel2
            // 
            rPanel2.BorderRadius = 5;
            rPanel2.Controls.Add(rPanel6);
            rPanel2.Controls.Add(player1_pt);
            rPanel2.Controls.Add(Player1_name);
            rPanel2.Location = new Point(56, 139);
            rPanel2.Name = "rPanel2";
            rPanel2.Size = new Size(450, 88);
            rPanel2.TabIndex = 0;
            // 
            // rPanel6
            // 
            rPanel6.BackColor = Color.FromArgb(231, 231, 231);
            rPanel6.BorderRadius = 10;
            rPanel6.Controls.Add(label5);
            rPanel6.Location = new Point(24, 19);
            rPanel6.Name = "rPanel6";
            rPanel6.Size = new Size(57, 52);
            rPanel6.TabIndex = 48;
            // 
            // label5
            // 
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 52);
            label5.TabIndex = 49;
            // 
            // player1_pt
            // 
            player1_pt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            player1_pt.Location = new Point(373, 19);
            player1_pt.Name = "player1_pt";
            player1_pt.Size = new Size(61, 52);
            player1_pt.TabIndex = 49;
            player1_pt.Text = "pt";
            player1_pt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Player1_name
            // 
            Player1_name.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Player1_name.Location = new Point(115, 19);
            Player1_name.Name = "Player1_name";
            Player1_name.Size = new Size(238, 52);
            Player1_name.TabIndex = 48;
            Player1_name.Text = "Player's name";
            Player1_name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // return_btn
            // 
            return_btn.BackColor = Color.FromArgb(25, 1, 82);
            return_btn.BackgroundColor = Color.FromArgb(25, 1, 82);
            return_btn.BorderColor = Color.PaleVioletRed;
            return_btn.BorderRadius = 40;
            return_btn.BorderSize = 0;
            return_btn.FlatAppearance.BorderSize = 0;
            return_btn.FlatStyle = FlatStyle.Flat;
            return_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            return_btn.ForeColor = Color.White;
            return_btn.Location = new Point(972, 417);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(175, 92);
            return_btn.TabIndex = 46;
            return_btn.Text = "Play Again";
            return_btn.TextColor = Color.White;
            return_btn.UseVisualStyleBackColor = false;
            return_btn.Click += return_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.BackColor = Color.FromArgb(25, 1, 82);
            exit_btn.BackgroundColor = Color.FromArgb(25, 1, 82);
            exit_btn.BorderColor = Color.PaleVioletRed;
            exit_btn.BorderRadius = 40;
            exit_btn.BorderSize = 0;
            exit_btn.FlatAppearance.BorderSize = 0;
            exit_btn.FlatStyle = FlatStyle.Flat;
            exit_btn.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            exit_btn.ForeColor = Color.White;
            exit_btn.Location = new Point(972, 527);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(175, 92);
            exit_btn.TabIndex = 47;
            exit_btn.Text = "Exit Game";
            exit_btn.TextColor = Color.White;
            exit_btn.UseVisualStyleBackColor = false;
            exit_btn.Click += exit_btn_Click;
            // 
            // Endgame_screen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(exit_btn);
            Controls.Add(return_btn);
            Controls.Add(rPanel1);
            Controls.Add(game_name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Endgame_screen";
            Text = "Endgame_screen";
            Load += Endgame_screen_Load;
            rPanel1.ResumeLayout(false);
            rPanel4.ResumeLayout(false);
            rPanel8.ResumeLayout(false);
            rPanel3.ResumeLayout(false);
            rPanel7.ResumeLayout(false);
            rPanel2.ResumeLayout(false);
            rPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label game_name;
        private RPanel rPanel1;
        private RJButton return_btn;
        private RJButton exit_btn;
        private RPanel rPanel4;
        private RPanel rPanel3;
        private RPanel rPanel2;
        private Label label1;
        private Label Player1_name;
        private Label Player3_name;
        private Label Player2_name;
        private Label player1_pt;
        private Label player3_pt;
        private Label player2_pt;
        private RPanel rPanel6;
        private Label label5;
        private RPanel rPanel8;
        private Label label7;
        private RPanel rPanel7;
        private Label label6;
    }
}
namespace Demo_Project
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            title = new Label();
            player_name_label = new Label();
            choice_panel = new RPanel();
            choice_label = new Label();
            create_btn = new RJButton();
            join_rand_btn = new RJButton();
            join_code_btn = new RJButton();
            back_btn = new RJButton();
            choice_panel.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            title.Image = (Image)resources.GetObject("title.Image");
            title.ImageAlign = ContentAlignment.MiddleLeft;
            title.Location = new Point(462, 33);
            title.Name = "title";
            title.Size = new Size(339, 121);
            title.TabIndex = 2;
            title.Text = "FilLmao";
            title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // player_name_label
            // 
            player_name_label.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            player_name_label.Image = (Image)resources.GetObject("player_name_label.Image");
            player_name_label.ImageAlign = ContentAlignment.MiddleRight;
            player_name_label.Location = new Point(518, 180);
            player_name_label.Name = "player_name_label";
            player_name_label.Size = new Size(224, 68);
            player_name_label.TabIndex = 7;
            player_name_label.Text = "Player";
            player_name_label.TextAlign = ContentAlignment.MiddleLeft;
            player_name_label.TextChanged += player_name_label_TextChanged;
            player_name_label.Click += player_name_Click;
            // 
            // choice_panel
            // 
            choice_panel.BackColor = Color.Black;
            choice_panel.BorderRadius = 20;
            choice_panel.Controls.Add(choice_label);
            choice_panel.Location = new Point(61, 285);
            choice_panel.Name = "choice_panel";
            choice_panel.Size = new Size(236, 310);
            choice_panel.TabIndex = 15;
            // 
            // choice_label
            // 
            choice_label.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            choice_label.ForeColor = Color.White;
            choice_label.Location = new Point(0, 0);
            choice_label.Name = "choice_label";
            choice_label.Size = new Size(236, 310);
            choice_label.TabIndex = 16;
            choice_label.Text = "I want to _______________________";
            // 
            // create_btn
            // 
            create_btn.BackColor = SystemColors.Window;
            create_btn.BackgroundColor = SystemColors.Window;
            create_btn.BorderColor = Color.Black;
            create_btn.BorderRadius = 45;
            create_btn.BorderSize = 2;
            create_btn.FlatAppearance.BorderSize = 0;
            create_btn.FlatStyle = FlatStyle.Flat;
            create_btn.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            create_btn.ForeColor = Color.Black;
            create_btn.Location = new Point(348, 285);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(236, 310);
            create_btn.TabIndex = 16;
            create_btn.Text = "Create a new room";
            create_btn.TextAlign = ContentAlignment.TopLeft;
            create_btn.TextColor = Color.Black;
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // join_rand_btn
            // 
            join_rand_btn.BackColor = SystemColors.Window;
            join_rand_btn.BackgroundColor = SystemColors.Window;
            join_rand_btn.BorderColor = Color.Black;
            join_rand_btn.BorderRadius = 45;
            join_rand_btn.BorderSize = 2;
            join_rand_btn.FlatAppearance.BorderSize = 0;
            join_rand_btn.FlatStyle = FlatStyle.Flat;
            join_rand_btn.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            join_rand_btn.ForeColor = Color.Black;
            join_rand_btn.Location = new Point(634, 280);
            join_rand_btn.Name = "join_rand_btn";
            join_rand_btn.Size = new Size(236, 310);
            join_rand_btn.TabIndex = 17;
            join_rand_btn.Text = "Join a random room";
            join_rand_btn.TextAlign = ContentAlignment.TopLeft;
            join_rand_btn.TextColor = Color.Black;
            join_rand_btn.UseVisualStyleBackColor = false;
            join_rand_btn.Click += join_rand_btn_Click;
            // 
            // join_code_btn
            // 
            join_code_btn.BackColor = SystemColors.Window;
            join_code_btn.BackgroundColor = SystemColors.Window;
            join_code_btn.BorderColor = Color.Black;
            join_code_btn.BorderRadius = 45;
            join_code_btn.BorderSize = 2;
            join_code_btn.FlatAppearance.BorderSize = 0;
            join_code_btn.FlatStyle = FlatStyle.Flat;
            join_code_btn.Font = new Font("Segoe UI Emoji", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            join_code_btn.ForeColor = Color.Black;
            join_code_btn.Location = new Point(927, 285);
            join_code_btn.Name = "join_code_btn";
            join_code_btn.Size = new Size(236, 310);
            join_code_btn.TabIndex = 18;
            join_code_btn.Text = "Join room by code";
            join_code_btn.TextAlign = ContentAlignment.TopLeft;
            join_code_btn.TextColor = Color.Black;
            join_code_btn.UseVisualStyleBackColor = false;
            join_code_btn.Click += join_code_btn_Click;
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
            back_btn.TabIndex = 24;
            back_btn.Text = "Back";
            back_btn.TextAlign = ContentAlignment.MiddleRight;
            back_btn.TextColor = Color.Black;
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Menu_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(144, 200, 255);
            ClientSize = new Size(1262, 673);
            Controls.Add(back_btn);
            Controls.Add(join_code_btn);
            Controls.Add(join_rand_btn);
            Controls.Add(create_btn);
            Controls.Add(choice_panel);
            Controls.Add(player_name_label);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Menu_Form";
            Text = "Menu";
            Load += Menu_Form_Load;
            choice_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label title;
        private Label player_name_label;
        private RPanel choice_panel;
        private Label choice_label;
        private RJButton create_btn;
        private RJButton join_rand_btn;
        private RJButton join_code_btn;
        private RJButton back_btn;
    }
}
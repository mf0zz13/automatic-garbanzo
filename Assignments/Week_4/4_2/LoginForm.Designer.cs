namespace _4_2
{
    partial class LoginForm
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MSSALogo = new PictureBox();
            LoginTxt = new TextBox();
            Username_Box = new TextBox();
            Password_Box = new TextBox();
            UserNameIcon = new PictureBox();
            Password_Icon = new PictureBox();
            button1 = new Button();
            CreateNewAccountTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)MSSALogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserNameIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Password_Icon).BeginInit();
            SuspendLayout();
            // 
            // MSSALogo
            // 
            MSSALogo.Enabled = false;
            MSSALogo.Image = Properties.Resources.MSSA_Logo;
            MSSALogo.Location = new Point(12, 12);
            MSSALogo.Name = "MSSALogo";
            MSSALogo.Size = new Size(232, 116);
            MSSALogo.SizeMode = PictureBoxSizeMode.StretchImage;
            MSSALogo.TabIndex = 0;
            MSSALogo.TabStop = false;
            MSSALogo.UseWaitCursor = true;
            // 
            // LoginTxt
            // 
            LoginTxt.BackColor = Color.White;
            LoginTxt.BorderStyle = BorderStyle.None;
            LoginTxt.Enabled = false;
            LoginTxt.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTxt.ForeColor = Color.DimGray;
            LoginTxt.Location = new Point(125, 150);
            LoginTxt.Name = "LoginTxt";
            LoginTxt.Size = new Size(200, 40);
            LoginTxt.TabIndex = 1;
            LoginTxt.Text = "User Login";
            LoginTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // Username_Box
            // 
            Username_Box.BorderStyle = BorderStyle.FixedSingle;
            Username_Box.Cursor = Cursors.IBeam;
            Username_Box.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_Box.ForeColor = Color.DarkGray;
            Username_Box.Location = new Point(100, 200);
            Username_Box.Name = "Username_Box";
            Username_Box.Size = new Size(250, 41);
            Username_Box.TabIndex = 2;
            Username_Box.Text = "Username";
            Username_Box.TextAlign = HorizontalAlignment.Center;
            // 
            // Password_Box
            // 
            Password_Box.BorderStyle = BorderStyle.FixedSingle;
            Password_Box.Cursor = Cursors.IBeam;
            Password_Box.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_Box.ForeColor = Color.DarkGray;
            Password_Box.Location = new Point(100, 260);
            Password_Box.Name = "Password_Box";
            Password_Box.Size = new Size(250, 41);
            Password_Box.TabIndex = 4;
            Password_Box.Text = "Password";
            Password_Box.TextAlign = HorizontalAlignment.Center;
            // 
            // UserNameIcon
            // 
            UserNameIcon.Enabled = false;
            UserNameIcon.Image = Properties.Resources.Pngtree_user_icon_5097430;
            UserNameIcon.Location = new Point(103, 201);
            UserNameIcon.Name = "UserNameIcon";
            UserNameIcon.Size = new Size(39, 39);
            UserNameIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            UserNameIcon.TabIndex = 3;
            UserNameIcon.TabStop = false;
            // 
            // Password_Icon
            // 
            Password_Icon.Enabled = false;
            Password_Icon.Image = Properties.Resources.lockIcon;
            Password_Icon.Location = new Point(103, 261);
            Password_Icon.Name = "Password_Icon";
            Password_Icon.Size = new Size(39, 39);
            Password_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            Password_Icon.TabIndex = 5;
            Password_Icon.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(100, 320);
            button1.Name = "button1";
            button1.Size = new Size(250, 41);
            button1.TabIndex = 6;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // CreateNewAccountTxt
            // 
            CreateNewAccountTxt.BackColor = Color.White;
            CreateNewAccountTxt.BorderStyle = BorderStyle.None;
            CreateNewAccountTxt.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateNewAccountTxt.ForeColor = Color.DarkGray;
            CreateNewAccountTxt.Location = new Point(125, 367);
            CreateNewAccountTxt.Name = "CreateNewAccountTxt";
            CreateNewAccountTxt.Size = new Size(200, 16);
            CreateNewAccountTxt.TabIndex = 7;
            CreateNewAccountTxt.Text = "CREATE NEW ACCOUNT";
            CreateNewAccountTxt.TextAlign = HorizontalAlignment.Center;
            CreateNewAccountTxt.MouseClick += CreateNewAccountTxt_MouseClick;
            CreateNewAccountTxt.MouseLeave += CreateNewAccountTxt_MouseLeave;
            CreateNewAccountTxt.MouseHover += CreateNewAccountTxt_MouseHover;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 461);
            Controls.Add(CreateNewAccountTxt);
            Controls.Add(button1);
            Controls.Add(Password_Icon);
            Controls.Add(Password_Box);
            Controls.Add(UserNameIcon);
            Controls.Add(Username_Box);
            Controls.Add(LoginTxt);
            Controls.Add(MSSALogo);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)MSSALogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserNameIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Password_Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MSSALogo;
        private TextBox LoginTxt;
        private TextBox Username_Box;
        private TextBox Password_Box;
        private PictureBox UserNameIcon;
        private PictureBox Password_Icon;
        private Button button1;
        private TextBox CreateNewAccountTxt;
    }
}

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
            UserName_Icon = new PictureBox();
            Password_Icon = new PictureBox();
            Login_Button = new Button();
            CreateNewAccountTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)MSSALogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserName_Icon).BeginInit();
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
            Username_Box.TabIndex = 1;
            Username_Box.Text = "Username";
            Username_Box.TextAlign = HorizontalAlignment.Center;
            Username_Box.TextChanged += Username_Box_TextChanged;
            Username_Box.Enter += Username_Box_Enter;
            Username_Box.Leave += Username_Box_Leave;
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
            Password_Box.TabIndex = 2;
            Password_Box.Text = "Password";
            Password_Box.TextAlign = HorizontalAlignment.Center;
            Password_Box.TextChanged += Password_Box_TextChanged;
            Password_Box.Enter += Password_Box_Enter;
            Password_Box.Leave += Password_Box_Leave;
            // 
            // UserName_Icon
            // 
            UserName_Icon.Enabled = false;
            UserName_Icon.Image = Properties.Resources.Pngtree_user_icon_5097430;
            UserName_Icon.Location = new Point(103, 201);
            UserName_Icon.Name = "UserName_Icon";
            UserName_Icon.Size = new Size(39, 39);
            UserName_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            UserName_Icon.TabIndex = 3;
            UserName_Icon.TabStop = false;
            // 
            // Password_Icon
            // 
            Password_Icon.Enabled = false;
            Password_Icon.Image = Properties.Resources.lockIcon;
            Password_Icon.Location = new Point(105, 263);
            Password_Icon.Name = "Password_Icon";
            Password_Icon.Size = new Size(35, 35);
            Password_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            Password_Icon.TabIndex = 5;
            Password_Icon.TabStop = false;
            // 
            // Login_Button
            // 
            Login_Button.BackColor = Color.LightGray;
            Login_Button.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login_Button.ForeColor = Color.DimGray;
            Login_Button.Location = new Point(100, 320);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(250, 41);
            Login_Button.TabIndex = 0;
            Login_Button.Text = "LOGIN";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Button_Click;
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
            CreateNewAccountTxt.TabStop = false;
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
            Controls.Add(Login_Button);
            Controls.Add(Password_Icon);
            Controls.Add(Password_Box);
            Controls.Add(UserName_Icon);
            Controls.Add(Username_Box);
            Controls.Add(LoginTxt);
            Controls.Add(MSSALogo);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)MSSALogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserName_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)Password_Icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox MSSALogo;
        public TextBox LoginTxt;
        internal TextBox Username_Box;
        internal TextBox Password_Box;
        internal PictureBox UserName_Icon;
        internal PictureBox Password_Icon;
        internal Button Login_Button;
        internal TextBox CreateNewAccountTxt;
    }
}

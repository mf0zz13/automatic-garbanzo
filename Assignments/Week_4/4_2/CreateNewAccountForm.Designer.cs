namespace _4_2
{
    partial class LoginInstance
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
            FirstName_Box = new TextBox();
            LastName_Box = new TextBox();
            UserNameInput_Box = new TextBox();
            PasswordInput_Box = new TextBox();
            CreateAccountTitleTxt = new Label();
            SubjectsBox = new ComboBox();
            Create_Button = new Button();
            Cancel_Button = new Button();
            CharNotPermittedTxt = new Label();
            SuspendLayout();
            // 
            // FirstName_Box
            // 
            FirstName_Box.BackColor = Color.White;
            FirstName_Box.BorderStyle = BorderStyle.FixedSingle;
            FirstName_Box.Cursor = Cursors.IBeam;
            FirstName_Box.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstName_Box.ForeColor = Color.DarkGray;
            FirstName_Box.Location = new Point(75, 215);
            FirstName_Box.Name = "FirstName_Box";
            FirstName_Box.Size = new Size(130, 27);
            FirstName_Box.TabIndex = 2;
            FirstName_Box.Text = "First Name";
            FirstName_Box.TextAlign = HorizontalAlignment.Center;
            FirstName_Box.TextChanged += FirstName_Box_TextChanged;
            FirstName_Box.Enter += FirstName_Box_Enter;
            FirstName_Box.Leave += FirstName_Box_Leave;
            // 
            // LastName_Box
            // 
            LastName_Box.BackColor = Color.White;
            LastName_Box.BorderStyle = BorderStyle.FixedSingle;
            LastName_Box.Cursor = Cursors.IBeam;
            LastName_Box.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastName_Box.ForeColor = Color.DarkGray;
            LastName_Box.Location = new Point(245, 215);
            LastName_Box.Name = "LastName_Box";
            LastName_Box.Size = new Size(130, 27);
            LastName_Box.TabIndex = 3;
            LastName_Box.Text = "Last Name";
            LastName_Box.TextAlign = HorizontalAlignment.Center;
            LastName_Box.TextChanged += LastName_Box_TextChanged;
            LastName_Box.Enter += LastName_Box_Enter;
            LastName_Box.Leave += LastName_Box_Leave;
            // 
            // UserNameInput_Box
            // 
            UserNameInput_Box.BorderStyle = BorderStyle.FixedSingle;
            UserNameInput_Box.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameInput_Box.ForeColor = Color.DarkGray;
            UserNameInput_Box.Location = new Point(75, 304);
            UserNameInput_Box.Name = "UserNameInput_Box";
            UserNameInput_Box.Size = new Size(130, 27);
            UserNameInput_Box.TabIndex = 5;
            UserNameInput_Box.Text = "Username";
            UserNameInput_Box.TextAlign = HorizontalAlignment.Center;
            UserNameInput_Box.TextChanged += UserNameInput_Box_TextChanged;
            UserNameInput_Box.Enter += UserNameInput_Box_Enter;
            UserNameInput_Box.Leave += UserNameInput_Box_Leave;
            // 
            // PasswordInput_Box
            // 
            PasswordInput_Box.BorderStyle = BorderStyle.FixedSingle;
            PasswordInput_Box.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordInput_Box.ForeColor = Color.DarkGray;
            PasswordInput_Box.Location = new Point(245, 304);
            PasswordInput_Box.Name = "PasswordInput_Box";
            PasswordInput_Box.Size = new Size(130, 27);
            PasswordInput_Box.TabIndex = 6;
            PasswordInput_Box.Text = "Password";
            PasswordInput_Box.TextAlign = HorizontalAlignment.Center;
            PasswordInput_Box.TextChanged += PasswordInput_Box_TextChanged;
            PasswordInput_Box.Enter += PasswordInput_Box_Enter;
            PasswordInput_Box.Leave += PasswordInput_Box_Leave;
            // 
            // CreateAccountTitleTxt
            // 
            CreateAccountTitleTxt.AutoSize = true;
            CreateAccountTitleTxt.Enabled = false;
            CreateAccountTitleTxt.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateAccountTitleTxt.ForeColor = Color.DimGray;
            CreateAccountTitleTxt.Location = new Point(42, 150);
            CreateAccountTitleTxt.Name = "CreateAccountTitleTxt";
            CreateAccountTitleTxt.Size = new Size(343, 38);
            CreateAccountTitleTxt.TabIndex = 13;
            CreateAccountTitleTxt.Text = "Create New Account";
            // 
            // SubjectsBox
            // 
            SubjectsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SubjectsBox.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubjectsBox.ForeColor = Color.DarkGray;
            SubjectsBox.FormattingEnabled = true;
            SubjectsBox.Location = new Point(140, 258);
            SubjectsBox.Name = "SubjectsBox";
            SubjectsBox.Size = new Size(170, 27);
            SubjectsBox.TabIndex = 4;
            SubjectsBox.SelectedIndexChanged += SubjectsBox_SelectedIndexChanged;
            SubjectsBox.Enter += SubjectsBox_Enter;
            // 
            // Create_Button
            // 
            Create_Button.BackColor = Color.LightGray;
            Create_Button.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Create_Button.ForeColor = Color.DimGray;
            Create_Button.Location = new Point(75, 367);
            Create_Button.Name = "Create_Button";
            Create_Button.Size = new Size(130, 35);
            Create_Button.TabIndex = 7;
            Create_Button.Text = "Create";
            Create_Button.UseVisualStyleBackColor = false;
            Create_Button.Click += Create_Button_Click_1;
            // 
            // Cancel_Button
            // 
            Cancel_Button.BackColor = Color.LightGray;
            Cancel_Button.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel_Button.ForeColor = Color.DimGray;
            Cancel_Button.Location = new Point(245, 367);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(130, 35);
            Cancel_Button.TabIndex = 1;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.UseVisualStyleBackColor = false;
            Cancel_Button.Click += Cancel_Button_Click;
            // 
            // CharNotPermittedTxt
            // 
            CharNotPermittedTxt.AutoSize = true;
            CharNotPermittedTxt.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CharNotPermittedTxt.ForeColor = Color.Red;
            CharNotPermittedTxt.Location = new Point(42, 334);
            CharNotPermittedTxt.Name = "CharNotPermittedTxt";
            CharNotPermittedTxt.Size = new Size(199, 16);
            CharNotPermittedTxt.TabIndex = 14;
            CharNotPermittedTxt.Text = "Special Characters Not Permitted";
            CharNotPermittedTxt.Visible = false;
            // 
            // LoginInstance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 461);
            Controls.Add(CharNotPermittedTxt);
            Controls.Add(Cancel_Button);
            Controls.Add(Create_Button);
            Controls.Add(SubjectsBox);
            Controls.Add(CreateAccountTitleTxt);
            Controls.Add(PasswordInput_Box);
            Controls.Add(UserNameInput_Box);
            Controls.Add(LastName_Box);
            Controls.Add(FirstName_Box);
            Name = "LoginInstance";
            Text = "Form1";
            Controls.SetChildIndex(LoginTxt, 0);
            Controls.SetChildIndex(FirstName_Box, 0);
            Controls.SetChildIndex(LastName_Box, 0);
            Controls.SetChildIndex(UserNameInput_Box, 0);
            Controls.SetChildIndex(PasswordInput_Box, 0);
            Controls.SetChildIndex(CreateAccountTitleTxt, 0);
            Controls.SetChildIndex(SubjectsBox, 0);
            Controls.SetChildIndex(Create_Button, 0);
            Controls.SetChildIndex(Cancel_Button, 0);
            Controls.SetChildIndex(CharNotPermittedTxt, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstName_Box;
        private TextBox LastName_Box;
        private TextBox UserNameInput_Box;
        private TextBox PasswordInput_Box;
        private Label CreateAccountTitleTxt;
        private ComboBox SubjectsBox;
        private Button Create_Button;
        private Button Cancel_Button;
        private Label CharNotPermittedTxt;
    }
}
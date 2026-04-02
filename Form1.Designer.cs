namespace LoginScreen
{
    partial class Form1
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblID_ = new Label();
            lblPW_ = new Label();
            lblErrorMsg = new Label();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Pretendard JP Variable Medium", 28F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblAppName.Location = new Point(33, 26);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(166, 67);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Window;
            txtID.Font = new Font("Pretendard JP Variable", 16F);
            txtID.Location = new Point(44, 161);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(572, 46);
            txtID.TabIndex = 1;
            // 
            // txtPW
            // 
            txtPW.BackColor = SystemColors.Window;
            txtPW.Font = new Font("Pretendard JP Variable", 16F);
            txtPW.Location = new Point(44, 262);
            txtPW.Name = "txtPW";
            txtPW.PlaceholderText = "Password";
            txtPW.Size = new Size(572, 46);
            txtPW.TabIndex = 2;
            txtPW.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.Font = new Font("Pretendard JP Variable", 14F);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(44, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 63);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblID_
            // 
            lblID_.AutoSize = true;
            lblID_.Font = new Font("Pretendard JP Variable", 12F);
            lblID_.ForeColor = SystemColors.ControlText;
            lblID_.Location = new Point(44, 116);
            lblID_.Name = "lblID_";
            lblID_.Size = new Size(76, 29);
            lblID_.TabIndex = 4;
            lblID_.Text = "아이디";
            // 
            // lblPW_
            // 
            lblPW_.AutoSize = true;
            lblPW_.Font = new Font("Pretendard JP Variable", 12F);
            lblPW_.ForeColor = SystemColors.ControlText;
            lblPW_.Location = new Point(44, 220);
            lblPW_.Name = "lblPW_";
            lblPW_.Size = new Size(97, 29);
            lblPW_.TabIndex = 5;
            lblPW_.Text = "비밀번호";
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("Pretendard JP Variable", 12F);
            lblErrorMsg.ForeColor = Color.IndianRed;
            lblErrorMsg.Location = new Point(44, 334);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(421, 29);
            lblErrorMsg.TabIndex = 6;
            lblErrorMsg.Text = "아이디 혹은 패스워드가 일치하지 않습니다.";
            lblErrorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(656, 475);
            Controls.Add(lblErrorMsg);
            Controls.Add(lblPW_);
            Controls.Add(lblID_);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblID_;
        private Label lblPW_;
        private Label lblErrorMsg;
    }
}

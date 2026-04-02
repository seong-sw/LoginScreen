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
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Pretendard JP Variable SemiBold", 36F, FontStyle.Bold, GraphicsUnit.Point, 128);
            lblAppName.Location = new Point(216, 43);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(214, 86);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Pretendard JP Variable", 24F);
            txtID.Location = new Point(44, 183);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ID";
            txtID.Size = new Size(572, 65);
            txtID.TabIndex = 1;
            // 
            // txtPW
            // 
            txtPW.BorderStyle = BorderStyle.FixedSingle;
            txtPW.Font = new Font("Pretendard JP Variable", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txtPW.Location = new Point(44, 297);
            txtPW.Name = "txtPW";
            txtPW.PlaceholderText = "Password";
            txtPW.Size = new Size(572, 65);
            txtPW.TabIndex = 2;
            txtPW.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Pretendard JP Variable", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btnLogin.Location = new Point(240, 415);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 63);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 526);
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
    }
}

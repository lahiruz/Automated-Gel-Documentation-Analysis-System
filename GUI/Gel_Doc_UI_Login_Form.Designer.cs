namespace GUI
{
    partial class Gel_Doc_UI_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gel_Doc_UI_Login_Form));
            this.CancelFunction = new System.Windows.Forms.Button();
            this.LoginFunction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelFunction
            // 
            this.CancelFunction.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CancelFunction.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelFunction.ForeColor = System.Drawing.Color.Black;
            this.CancelFunction.Location = new System.Drawing.Point(326, 188);
            this.CancelFunction.Name = "CancelFunction";
            this.CancelFunction.Size = new System.Drawing.Size(127, 34);
            this.CancelFunction.TabIndex = 0;
            this.CancelFunction.Text = "Cancel";
            this.CancelFunction.UseVisualStyleBackColor = false;
            this.CancelFunction.Click += new System.EventHandler(this.CancelFunction_Click);
            // 
            // LoginFunction
            // 
            this.LoginFunction.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LoginFunction.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFunction.ForeColor = System.Drawing.Color.Black;
            this.LoginFunction.Location = new System.Drawing.Point(179, 188);
            this.LoginFunction.Name = "LoginFunction";
            this.LoginFunction.Size = new System.Drawing.Size(134, 34);
            this.LoginFunction.TabIndex = 1;
            this.LoginFunction.Text = "Login";
            this.LoginFunction.UseVisualStyleBackColor = false;
            this.LoginFunction.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(69, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(179, 94);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(186, 20);
            this.userName.TabIndex = 4;
            this.userName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userName_KeyUp);
            this.userName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.userName_PreviewKeyDown);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(179, 136);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(186, 20);
            this.password.TabIndex = 5;
            this.password.TabStop = false;
            this.password.UseSystemPasswordChar = true;
            this.password.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.password_PreviewKeyDown);
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loginTitle.Location = new System.Drawing.Point(174, 25);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(146, 29);
            this.loginTitle.TabIndex = 6;
            this.loginTitle.Text = " Sign With Us ";
            this.loginTitle.Click += new System.EventHandler(this.loginTitle_Click);
            // 
            // Gel_Doc_UI_Login_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(486, 258);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginFunction);
            this.Controls.Add(this.CancelFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gel_Doc_UI_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gel Analysis System Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gel_Doc_UI_Login_Form_FormClosed);
            this.Load += new System.EventHandler(this.Gel_Doc_UI_Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelFunction;
        private System.Windows.Forms.Button LoginFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label loginTitle;
    }
}
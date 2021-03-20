
namespace SqlManagmentStudio.Windows
{
    partial class LoginForm
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
            this.server_Label = new System.Windows.Forms.Label();
            this.login_Label = new System.Windows.Forms.Label();
            this.loginName_TextBox = new System.Windows.Forms.TextBox();
            this.password_Label = new System.Windows.Forms.Label();
            this.passwordName_TextBox = new System.Windows.Forms.TextBox();
            this.connectToServer_Btn = new System.Windows.Forms.Button();
            this.closeLogin_Btn = new System.Windows.Forms.Button();
            this.connectToServer_Label = new System.Windows.Forms.Label();
            this.authenticationType_ComboBox = new System.Windows.Forms.ComboBox();
            this.authenticationType_Label = new System.Windows.Forms.Label();
            this.serverName_Dropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // server_Label
            // 
            this.server_Label.AutoSize = true;
            this.server_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.server_Label.Location = new System.Drawing.Point(12, 70);
            this.server_Label.Name = "server_Label";
            this.server_Label.Size = new System.Drawing.Size(45, 15);
            this.server_Label.TabIndex = 1;
            this.server_Label.Text = "Server";
            // 
            // login_Label
            // 
            this.login_Label.AutoSize = true;
            this.login_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_Label.Location = new System.Drawing.Point(12, 177);
            this.login_Label.Name = "login_Label";
            this.login_Label.Size = new System.Drawing.Size(37, 15);
            this.login_Label.TabIndex = 3;
            this.login_Label.Text = "Login";
            // 
            // loginName_TextBox
            // 
            this.loginName_TextBox.Enabled = false;
            this.loginName_TextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginName_TextBox.Location = new System.Drawing.Point(12, 195);
            this.loginName_TextBox.Multiline = true;
            this.loginName_TextBox.Name = "loginName_TextBox";
            this.loginName_TextBox.Size = new System.Drawing.Size(322, 35);
            this.loginName_TextBox.TabIndex = 2;
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_Label.Location = new System.Drawing.Point(12, 245);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(59, 15);
            this.password_Label.TabIndex = 5;
            this.password_Label.Text = "Password";
            // 
            // passwordName_TextBox
            // 
            this.passwordName_TextBox.Enabled = false;
            this.passwordName_TextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordName_TextBox.Location = new System.Drawing.Point(12, 263);
            this.passwordName_TextBox.Multiline = true;
            this.passwordName_TextBox.Name = "passwordName_TextBox";
            this.passwordName_TextBox.PasswordChar = '*';
            this.passwordName_TextBox.Size = new System.Drawing.Size(322, 35);
            this.passwordName_TextBox.TabIndex = 4;
            // 
            // connectToServer_Btn
            // 
            this.connectToServer_Btn.Location = new System.Drawing.Point(235, 320);
            this.connectToServer_Btn.Name = "connectToServer_Btn";
            this.connectToServer_Btn.Size = new System.Drawing.Size(99, 43);
            this.connectToServer_Btn.TabIndex = 6;
            this.connectToServer_Btn.Text = "Connect";
            this.connectToServer_Btn.UseVisualStyleBackColor = true;
            this.connectToServer_Btn.Click += new System.EventHandler(this.connectToServer_Btn_Click);
            // 
            // closeLogin_Btn
            // 
            this.closeLogin_Btn.Location = new System.Drawing.Point(130, 320);
            this.closeLogin_Btn.Name = "closeLogin_Btn";
            this.closeLogin_Btn.Size = new System.Drawing.Size(99, 43);
            this.closeLogin_Btn.TabIndex = 7;
            this.closeLogin_Btn.Text = "Close";
            this.closeLogin_Btn.UseVisualStyleBackColor = true;
            this.closeLogin_Btn.Click += new System.EventHandler(this.closeLogin_Btn_Click);
            // 
            // connectToServer_Label
            // 
            this.connectToServer_Label.AutoSize = true;
            this.connectToServer_Label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.connectToServer_Label.Location = new System.Drawing.Point(69, 23);
            this.connectToServer_Label.Name = "connectToServer_Label";
            this.connectToServer_Label.Size = new System.Drawing.Size(201, 30);
            this.connectToServer_Label.TabIndex = 8;
            this.connectToServer_Label.Text = "Connect To Server";
            // 
            // authenticationType_ComboBox
            // 
            this.authenticationType_ComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.authenticationType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authenticationType_ComboBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.authenticationType_ComboBox.FormattingEnabled = true;
            this.authenticationType_ComboBox.Items.AddRange(new object[] {
            "Windows Authentication",
            "Sql Server Authentication"});
            this.authenticationType_ComboBox.Location = new System.Drawing.Point(12, 141);
            this.authenticationType_ComboBox.Name = "authenticationType_ComboBox";
            this.authenticationType_ComboBox.Size = new System.Drawing.Size(322, 33);
            this.authenticationType_ComboBox.TabIndex = 9;
            this.authenticationType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.authenticationType_ComboBox_SelectedIndexChanged);
            // 
            // authenticationType_Label
            // 
            this.authenticationType_Label.AutoSize = true;
            this.authenticationType_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.authenticationType_Label.Location = new System.Drawing.Point(11, 125);
            this.authenticationType_Label.Name = "authenticationType_Label";
            this.authenticationType_Label.Size = new System.Drawing.Size(119, 15);
            this.authenticationType_Label.TabIndex = 10;
            this.authenticationType_Label.Text = "Authentication Type";
            // 
            // serverName_Dropdown
            // 
            this.serverName_Dropdown.BackColor = System.Drawing.SystemColors.Window;
            this.serverName_Dropdown.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverName_Dropdown.FormattingEnabled = true;
            this.serverName_Dropdown.Location = new System.Drawing.Point(12, 89);
            this.serverName_Dropdown.Name = "serverName_Dropdown";
            this.serverName_Dropdown.Size = new System.Drawing.Size(322, 33);
            this.serverName_Dropdown.TabIndex = 11;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 375);
            this.Controls.Add(this.serverName_Dropdown);
            this.Controls.Add(this.authenticationType_Label);
            this.Controls.Add(this.authenticationType_ComboBox);
            this.Controls.Add(this.connectToServer_Label);
            this.Controls.Add(this.closeLogin_Btn);
            this.Controls.Add(this.connectToServer_Btn);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.passwordName_TextBox);
            this.Controls.Add(this.login_Label);
            this.Controls.Add(this.loginName_TextBox);
            this.Controls.Add(this.server_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect To Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label server_Label;
        private System.Windows.Forms.Label login_Label;
        private System.Windows.Forms.TextBox loginName_TextBox;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.TextBox passwordName_TextBox;
        private System.Windows.Forms.Button connectToServer_Btn;
        private System.Windows.Forms.Button closeLogin_Btn;
        private System.Windows.Forms.Label connectToServer_Label;
        private System.Windows.Forms.ComboBox authenticationType_ComboBox;
        private System.Windows.Forms.Label authenticationType_Label;
        private System.Windows.Forms.ComboBox serverName_Dropdown;
    }
}
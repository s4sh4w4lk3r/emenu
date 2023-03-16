using System.Windows.Forms;

namespace emenu.forms
{
    partial class Conndialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conndialog));
            welcomeLabel = new Label();
            HostnameBox = new TextBox();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            DBnameBox = new TextBox();
            hostnameLabel = new Label();
            usernameLabel = new Label();
            passwordlabel = new Label();
            dbnameLabel = new Label();
            connButton = new Button();
            closeButton = new Button();
            SaveLoginButton = new Button();
            ClearLoginButton = new Button();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.ForeColor = SystemColors.ButtonHighlight;
            welcomeLabel.Location = new Point(15, 15);
            welcomeLabel.Margin = new Padding(4, 0, 4, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(217, 20);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Connect to MySQL Database";
            // 
            // HostnameBox
            // 
            HostnameBox.Location = new Point(98, 55);
            HostnameBox.Margin = new Padding(4, 3, 4, 3);
            HostnameBox.Name = "HostnameBox";
            HostnameBox.Size = new Size(182, 23);
            HostnameBox.TabIndex = 1;
            HostnameBox.KeyDown += HostnameBox_KeyDown;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(98, 85);
            UsernameBox.Margin = new Padding(4, 3, 4, 3);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(182, 23);
            UsernameBox.TabIndex = 2;
            UsernameBox.KeyDown += UsernameBox_KeyDown;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(98, 115);
            PasswordBox.Margin = new Padding(4, 3, 4, 3);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(182, 23);
            PasswordBox.TabIndex = 3;
            PasswordBox.KeyDown += PasswordBox_KeyDown;
            // 
            // DBnameBox
            // 
            DBnameBox.Location = new Point(98, 145);
            DBnameBox.Margin = new Padding(4, 3, 4, 3);
            DBnameBox.Name = "DBnameBox";
            DBnameBox.Size = new Size(182, 23);
            DBnameBox.TabIndex = 4;
            DBnameBox.KeyDown += DBnameBox_KeyDown;
            // 
            // hostnameLabel
            // 
            hostnameLabel.AutoSize = true;
            hostnameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            hostnameLabel.ForeColor = Color.White;
            hostnameLabel.Location = new Point(14, 57);
            hostnameLabel.Margin = new Padding(4, 0, 4, 0);
            hostnameLabel.Name = "hostnameLabel";
            hostnameLabel.Size = new Size(64, 15);
            hostnameLabel.TabIndex = 5;
            hostnameLabel.Text = "Hostname";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(14, 87);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(65, 15);
            usernameLabel.TabIndex = 6;
            usernameLabel.Text = "Username";
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordlabel.ForeColor = Color.White;
            passwordlabel.Location = new Point(14, 117);
            passwordlabel.Margin = new Padding(4, 0, 4, 0);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(61, 15);
            passwordlabel.TabIndex = 7;
            passwordlabel.Text = "Password";
            // 
            // dbnameLabel
            // 
            dbnameLabel.AutoSize = true;
            dbnameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dbnameLabel.ForeColor = Color.White;
            dbnameLabel.Location = new Point(14, 147);
            dbnameLabel.Margin = new Padding(4, 0, 4, 0);
            dbnameLabel.Name = "dbnameLabel";
            dbnameLabel.Size = new Size(61, 15);
            dbnameLabel.TabIndex = 8;
            dbnameLabel.Text = "DB Name";
            // 
            // connButton
            // 
            connButton.Location = new Point(441, 105);
            connButton.Margin = new Padding(4, 3, 4, 3);
            connButton.Name = "connButton";
            connButton.Size = new Size(88, 27);
            connButton.TabIndex = 9;
            connButton.Text = "Connect";
            connButton.UseVisualStyleBackColor = true;
            connButton.Click += connButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(441, 141);
            closeButton.Margin = new Padding(4, 3, 4, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(88, 27);
            closeButton.TabIndex = 10;
            closeButton.Text = "Exit";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // SaveLoginButton
            // 
            SaveLoginButton.Location = new Point(441, 72);
            SaveLoginButton.Margin = new Padding(4, 3, 4, 3);
            SaveLoginButton.Name = "SaveLoginButton";
            SaveLoginButton.Size = new Size(88, 27);
            SaveLoginButton.TabIndex = 11;
            SaveLoginButton.Text = "Save login";
            SaveLoginButton.UseVisualStyleBackColor = true;
            SaveLoginButton.Click += SaveLoginButton_Click;
            // 
            // ClearLoginButton
            // 
            ClearLoginButton.Location = new Point(441, 39);
            ClearLoginButton.Margin = new Padding(4, 3, 4, 3);
            ClearLoginButton.Name = "ClearLoginButton";
            ClearLoginButton.Size = new Size(88, 27);
            ClearLoginButton.TabIndex = 12;
            ClearLoginButton.Text = "Clear login";
            ClearLoginButton.UseVisualStyleBackColor = true;
            ClearLoginButton.Click += ClearLoginButton_Click;
            // 
            // Conndialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(542, 188);
            Controls.Add(ClearLoginButton);
            Controls.Add(SaveLoginButton);
            Controls.Add(closeButton);
            Controls.Add(connButton);
            Controls.Add(dbnameLabel);
            Controls.Add(passwordlabel);
            Controls.Add(usernameLabel);
            Controls.Add(hostnameLabel);
            Controls.Add(DBnameBox);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(HostnameBox);
            Controls.Add(welcomeLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Conndialog";
            Text = "Connect to Database";
            KeyUp += Conndialog_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private TextBox HostnameBox;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private TextBox DBnameBox;
        private Label hostnameLabel;
        private Label usernameLabel;
        private Label passwordlabel;
        private Label dbnameLabel;
        private Button connButton;
        private Button closeButton;
        private Button SaveLoginButton;
        private Button ClearLoginButton;
    }
}
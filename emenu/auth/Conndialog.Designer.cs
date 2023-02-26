using System.Windows.Forms;

namespace emenu_csharp
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.HostnameBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.DBnameBox = new System.Windows.Forms.TextBox();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.dbnameLabel = new System.Windows.Forms.Label();
            this.connButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomeLabel.Location = new System.Drawing.Point(13, 13);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(217, 20);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Connect to MySQL Database";
            // 
            // HostnameBox
            // 
            this.HostnameBox.Location = new System.Drawing.Point(84, 48);
            this.HostnameBox.Name = "HostnameBox";
            this.HostnameBox.Size = new System.Drawing.Size(157, 20);
            this.HostnameBox.TabIndex = 1;
            this.HostnameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HostnameBox_KeyDown);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(84, 74);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(157, 20);
            this.UsernameBox.TabIndex = 2;
            this.UsernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernameBox_KeyDown);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(84, 100);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(157, 20);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordBox_KeyDown);
            // 
            // DBnameBox
            // 
            this.DBnameBox.Location = new System.Drawing.Point(84, 126);
            this.DBnameBox.Name = "DBnameBox";
            this.DBnameBox.Size = new System.Drawing.Size(157, 20);
            this.DBnameBox.TabIndex = 4;
            this.DBnameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DBnameBox_KeyDown);
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hostnameLabel.ForeColor = System.Drawing.Color.White;
            this.hostnameLabel.Location = new System.Drawing.Point(12, 49);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(64, 15);
            this.hostnameLabel.TabIndex = 5;
            this.hostnameLabel.Text = "Hostname";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(12, 75);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(65, 15);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(12, 101);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(61, 15);
            this.passwordlabel.TabIndex = 7;
            this.passwordlabel.Text = "Password";
            // 
            // dbnameLabel
            // 
            this.dbnameLabel.AutoSize = true;
            this.dbnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dbnameLabel.ForeColor = System.Drawing.Color.White;
            this.dbnameLabel.Location = new System.Drawing.Point(12, 127);
            this.dbnameLabel.Name = "dbnameLabel";
            this.dbnameLabel.Size = new System.Drawing.Size(61, 15);
            this.dbnameLabel.TabIndex = 8;
            this.dbnameLabel.Text = "DB Name";
            // 
            // connButton
            // 
            this.connButton.Location = new System.Drawing.Point(297, 128);
            this.connButton.Name = "connButton";
            this.connButton.Size = new System.Drawing.Size(75, 23);
            this.connButton.TabIndex = 9;
            this.connButton.Text = "Connect";
            this.connButton.UseVisualStyleBackColor = true;
            this.connButton.Click += new System.EventHandler(this.connButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(378, 128);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Conndialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(465, 163);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.connButton);
            this.Controls.Add(this.dbnameLabel);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.hostnameLabel);
            this.Controls.Add(this.DBnameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.HostnameBox);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Conndialog";
            this.Text = "Connect to Database";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Conndialog_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
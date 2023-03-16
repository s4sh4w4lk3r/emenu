namespace emenu.forms
{
    partial class ModeSelection
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
            CashierRadio = new RadioButton();
            KitchenRadio = new RadioButton();
            SelfServiceRadio = new RadioButton();
            HallScreenButton = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ContinueButton = new Button();
            BackButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CashierRadio
            // 
            CashierRadio.AutoSize = true;
            CashierRadio.Location = new Point(6, 22);
            CashierRadio.Name = "CashierRadio";
            CashierRadio.Size = new Size(64, 19);
            CashierRadio.TabIndex = 0;
            CashierRadio.Text = "Cashier";
            CashierRadio.UseVisualStyleBackColor = true;
            // 
            // KitchenRadio
            // 
            KitchenRadio.AutoSize = true;
            KitchenRadio.Location = new Point(6, 47);
            KitchenRadio.Name = "KitchenRadio";
            KitchenRadio.Size = new Size(65, 19);
            KitchenRadio.TabIndex = 1;
            KitchenRadio.Text = "Kitchen";
            KitchenRadio.UseVisualStyleBackColor = true;
            // 
            // SelfServiceRadio
            // 
            SelfServiceRadio.AutoSize = true;
            SelfServiceRadio.Location = new Point(6, 72);
            SelfServiceRadio.Name = "SelfServiceRadio";
            SelfServiceRadio.Size = new Size(81, 19);
            SelfServiceRadio.TabIndex = 2;
            SelfServiceRadio.Text = "SelfService";
            SelfServiceRadio.UseVisualStyleBackColor = true;
            // 
            // HallScreenButton
            // 
            HallScreenButton.AutoSize = true;
            HallScreenButton.Location = new Point(6, 97);
            HallScreenButton.Name = "HallScreenButton";
            HallScreenButton.Size = new Size(81, 19);
            HallScreenButton.TabIndex = 3;
            HallScreenButton.Text = "HallScreen";
            HallScreenButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CashierRadio);
            groupBox1.Controls.Add(HallScreenButton);
            groupBox1.Controls.Add(KitchenRadio);
            groupBox1.Controls.Add(SelfServiceRadio);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(146, 123);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operating mode";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 5;
            label1.Text = "Select the operating mode";
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(268, 133);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(100, 27);
            ContinueButton.TabIndex = 6;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(268, 100);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(100, 27);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // ModeSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(380, 176);
            Controls.Add(BackButton);
            Controls.Add(ContinueButton);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "ModeSelection";
            Text = "ModeSelection";
            Load += ModeSelection_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton CashierRadio;
        private RadioButton KitchenRadio;
        private RadioButton SelfServiceRadio;
        private RadioButton HallScreenButton;
        private GroupBox groupBox1;
        private Label label1;
        private Button ContinueButton;
        private Button BackButton;
    }
}
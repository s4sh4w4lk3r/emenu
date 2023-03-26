namespace emenu.forms
{
    partial class Kitchen
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            orderID = new DataGridViewTextBoxColumn();
            orderContent = new DataGridViewTextBoxColumn();
            passButton = new DataGridViewButtonColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DarkSlateBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderID, orderContent, passButton });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1152, 624);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // orderID
            // 
            orderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orderID.HeaderText = "orderID";
            orderID.Name = "orderID";
            orderID.Width = 21;
            // 
            // orderContent
            // 
            orderContent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderContent.HeaderText = "The order includes";
            orderContent.Name = "orderContent";
            // 
            // passButton
            // 
            passButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            passButton.FlatStyle = FlatStyle.Popup;
            passButton.HeaderText = "Action";
            passButton.Name = "passButton";
            passButton.Text = "Pass order";
            passButton.ToolTipText = "Pass order";
            passButton.Width = 21;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Kitchen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1153, 625);
            Controls.Add(dataGridView1);
            Name = "Kitchen";
            Text = "Kitchen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn orderID;
        private DataGridViewTextBoxColumn orderContent;
        private DataGridViewButtonColumn passButton;
    }
}
namespace emenu.forms
{
    partial class Cashier
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            priceLabel = new Label();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            clearBtn = new Button();
            nextBtn = new Button();
            label1 = new Label();
            picture = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            AddButton = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.DarkSlateBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { picture, name, price, AddButton });
            dataGridView1.GridColor = SystemColors.ControlDarkDark;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(909, 636);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(priceLabel);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(nextBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(927, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 635);
            panel1.TabIndex = 1;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.ForeColor = Color.Coral;
            priceLabel.Location = new Point(16, 555);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(169, 37);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Итого: 0.00₽";
            priceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = Color.DarkSlateBlue;
            richTextBox1.ForeColor = Color.Coral;
            richTextBox1.Location = new Point(16, 35);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(207, 517);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.DeepPink;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 636);
            panel2.TabIndex = 2;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearBtn.BackColor = Color.Firebrick;
            clearBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.ForeColor = SystemColors.ButtonHighlight;
            clearBtn.Location = new Point(16, 595);
            clearBtn.Margin = new Padding(5, 3, 3, 3);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(100, 41);
            clearBtn.TabIndex = 2;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextBtn.BackColor = Color.ForestGreen;
            nextBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(126, 595);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(100, 41);
            nextBtn.TabIndex = 1;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(16, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "CHECKOUT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picture
            // 
            picture.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            picture.HeaderText = "Pictrure";
            picture.Image = Properties.Resources.Без_имени_2;
            picture.Name = "picture";
            picture.Width = 21;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            price.HeaderText = "Price";
            price.Name = "price";
            price.Width = 21;
            // 
            // AddButton
            // 
            AddButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AddButton.FlatStyle = FlatStyle.Popup;
            AddButton.HeaderText = "Action";
            AddButton.Name = "AddButton";
            AddButton.Text = "";
            AddButton.Width = 21;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1165, 659);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Cashier";
            Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button clearBtn;
        private Button nextBtn;
        private Label label1;
        private Panel panel2;
        private RichTextBox richTextBox1;
        private Label priceLabel;
        private DataGridViewImageColumn picture;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewButtonColumn AddButton;
    }
}
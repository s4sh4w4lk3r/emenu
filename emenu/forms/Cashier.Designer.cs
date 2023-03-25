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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkSlateBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { picture, name, price, AddButton });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(909, 636);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(nextBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(927, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 635);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
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
            picture.HeaderText = "Pictrure";
            picture.Name = "picture";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.Name = "price";
            // 
            // AddButton
            // 
            AddButton.HeaderText = "Add";
            AddButton.Name = "AddButton";
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button clearBtn;
        private Button nextBtn;
        private Label label1;
        private Panel panel2;
        private DataGridViewImageColumn picture;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewButtonColumn AddButton;
    }
}
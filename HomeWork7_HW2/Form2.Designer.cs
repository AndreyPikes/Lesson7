
namespace HomeWork7_HW2
{
    partial class Form2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblEnter = new System.Windows.Forms.Label();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnEnter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEnter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbEnter, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 111);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnEnter
            // 
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnter.Location = new System.Drawing.Point(80, 77);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(80, 3, 80, 3);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(224, 31);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Ввод";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnter.Location = new System.Drawing.Point(3, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(378, 37);
            this.lblEnter.TabIndex = 1;
            this.lblEnter.Text = "Введите число!";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEnter
            // 
            this.tbEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnter.Location = new System.Drawing.Point(80, 40);
            this.tbEnter.Margin = new System.Windows.Forms.Padding(80, 3, 80, 3);
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.Size = new System.Drawing.Size(224, 23);
            this.tbEnter.TabIndex = 2;
            this.tbEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEnter_KeyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(400, 150);
            this.MinimumSize = new System.Drawing.Size(400, 150);
            this.Name = "Form2";
            this.Text = "Форма ввода числа";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEnter;
        internal System.Windows.Forms.TextBox tbEnter;
        internal System.Windows.Forms.Button btnEnter;
    }
}
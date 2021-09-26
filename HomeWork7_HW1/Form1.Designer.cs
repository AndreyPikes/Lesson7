
namespace HomeWork7_HW1
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
            this.btnComand1 = new System.Windows.Forms.Button();
            this.btnComand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTargetNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComand1
            // 
            this.btnComand1.Location = new System.Drawing.Point(147, 10);
            this.btnComand1.Name = "btnComand1";
            this.btnComand1.Size = new System.Drawing.Size(128, 23);
            this.btnComand1.TabIndex = 1;
            this.btnComand1.Text = "+1";
            this.btnComand1.UseVisualStyleBackColor = true;
            this.btnComand1.Click += new System.EventHandler(this.btnComand1_Click);
            // 
            // btnComand2
            // 
            this.btnComand2.Location = new System.Drawing.Point(147, 50);
            this.btnComand2.Name = "btnComand2";
            this.btnComand2.Size = new System.Drawing.Size(128, 23);
            this.btnComand2.TabIndex = 2;
            this.btnComand2.Text = "x2";
            this.btnComand2.UseVisualStyleBackColor = true;
            this.btnComand2.Click += new System.EventHandler(this.btnComand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(36, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(36, 10);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 23);
            this.tbNumber.TabIndex = 4;
            this.tbNumber.Text = "1";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(36, 89);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(0, 15);
            this.lblCounter.TabIndex = 5;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(298, 9);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(174, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Играть";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblTargetNumber
            // 
            this.lblTargetNumber.AutoSize = true;
            this.lblTargetNumber.Location = new System.Drawing.Point(298, 50);
            this.lblTargetNumber.Name = "lblTargetNumber";
            this.lblTargetNumber.Size = new System.Drawing.Size(0, 15);
            this.lblTargetNumber.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(147, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 42);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена последнего ввода";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblTargetNumber);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnComand2);
            this.Controls.Add(this.btnComand1);
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Form1";
            this.Text = "Удвоитель Pro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnComand1;
        private System.Windows.Forms.Button btnComand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTargetNumber;
        private System.Windows.Forms.Button btnCancel;
    }
}


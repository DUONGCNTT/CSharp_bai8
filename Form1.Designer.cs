namespace CSharp_bai8
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDuongLich = new System.Windows.Forms.TextBox();
            this.txtAmLich = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(246, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CAN CHI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(44, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "năm dương lịch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(56, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "năm âm lịch";
            // 
            // txtDuongLich
            // 
            this.txtDuongLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtDuongLich.Location = new System.Drawing.Point(254, 149);
            this.txtDuongLich.Name = "txtDuongLich";
            this.txtDuongLich.Size = new System.Drawing.Size(275, 23);
            this.txtDuongLich.TabIndex = 3;
            this.txtDuongLich.Text = "2023";
            // 
            // txtAmLich
            // 
            this.txtAmLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtAmLich.Location = new System.Drawing.Point(254, 228);
            this.txtAmLich.Name = "txtAmLich";
            this.txtAmLich.Size = new System.Drawing.Size(275, 23);
            this.txtAmLich.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(228, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "kết quả";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAmLich);
            this.Controls.Add(this.txtDuongLich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDuongLich;
        private System.Windows.Forms.TextBox txtAmLich;
        private System.Windows.Forms.Button button1;
    }
}


namespace WindowsFormsApp4
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
            this.btn_reverse = new System.Windows.Forms.Button();
            this.btn_urutkan = new System.Windows.Forms.Button();
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.tb_inputan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_reverse
            // 
            this.btn_reverse.Location = new System.Drawing.Point(244, 133);
            this.btn_reverse.Name = "btn_reverse";
            this.btn_reverse.Size = new System.Drawing.Size(75, 23);
            this.btn_reverse.TabIndex = 0;
            this.btn_reverse.Text = "REVERSE";
            this.btn_reverse.UseVisualStyleBackColor = true;
            this.btn_reverse.Click += new System.EventHandler(this.btn_reverse_Click);
            // 
            // btn_urutkan
            // 
            this.btn_urutkan.Location = new System.Drawing.Point(333, 133);
            this.btn_urutkan.Name = "btn_urutkan";
            this.btn_urutkan.Size = new System.Drawing.Size(75, 23);
            this.btn_urutkan.TabIndex = 1;
            this.btn_urutkan.Text = "URUTKAN";
            this.btn_urutkan.UseVisualStyleBackColor = true;
            this.btn_urutkan.Click += new System.EventHandler(this.btn_urutkan_Click);
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(241, 91);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(31, 13);
            this.lbl_input.TabIndex = 2;
            this.lbl_input.Text = "Input";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(241, 172);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(39, 13);
            this.lbl_output.TabIndex = 3;
            this.lbl_output.Text = "Output";
            // 
            // tb_inputan
            // 
            this.tb_inputan.Location = new System.Drawing.Point(244, 107);
            this.tb_inputan.Name = "tb_inputan";
            this.tb_inputan.Size = new System.Drawing.Size(164, 20);
            this.tb_inputan.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_inputan);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.btn_urutkan);
            this.Controls.Add(this.btn_reverse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reverse;
        private System.Windows.Forms.Button btn_urutkan;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.TextBox tb_inputan;
    }
}


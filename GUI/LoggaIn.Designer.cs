namespace GUI
{
    partial class LoggaIn
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
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnvändarID = new System.Windows.Forms.TextBox();
            this.txtLösenord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLoggaIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoggaIn.Location = new System.Drawing.Point(76, 184);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(230, 58);
            this.btnLoggaIn.TabIndex = 0;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = false;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "AnvändarID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lösenord";
            // 
            // txtAnvändarID
            // 
            this.txtAnvändarID.Location = new System.Drawing.Point(138, 59);
            this.txtAnvändarID.Name = "txtAnvändarID";
            this.txtAnvändarID.Size = new System.Drawing.Size(168, 23);
            this.txtAnvändarID.TabIndex = 3;
            // 
            // txtLösenord
            // 
            this.txtLösenord.Location = new System.Drawing.Point(138, 112);
            this.txtLösenord.Name = "txtLösenord";
            this.txtLösenord.Size = new System.Drawing.Size(168, 23);
            this.txtLösenord.TabIndex = 4;
            // 
            // LoggaIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 330);
            this.Controls.Add(this.txtLösenord);
            this.Controls.Add(this.txtAnvändarID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoggaIn);
            this.Name = "LoggaIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoggaIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnvändarID;
        private System.Windows.Forms.TextBox txtLösenord;
    }
}

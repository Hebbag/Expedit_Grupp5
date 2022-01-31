namespace PresentationLayer
{
    partial class ReserveraBokning
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
            this.dataGridViewReservera = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReservera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tillgängliga böcker fr.o.m:";
            // 
            // dataGridViewReservera
            // 
            this.dataGridViewReservera.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewReservera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservera.Location = new System.Drawing.Point(48, 111);
            this.dataGridViewReservera.Name = "dataGridViewReservera";
            this.dataGridViewReservera.RowTemplate.Height = 25;
            this.dataGridViewReservera.Size = new System.Drawing.Size(667, 223);
            this.dataGridViewReservera.TabIndex = 2;
            this.dataGridViewReservera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservera_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnReservera
            // 
            this.btnReservera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReservera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservera.Location = new System.Drawing.Point(556, 374);
            this.btnReservera.Name = "btnReservera";
            this.btnReservera.Size = new System.Drawing.Size(159, 48);
            this.btnReservera.TabIndex = 4;
            this.btnReservera.Text = "Reservera";
            this.btnReservera.UseVisualStyleBackColor = false;
            this.btnReservera.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReserveraBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservera);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridViewReservera);
            this.Controls.Add(this.label1);
            this.Name = "ReserveraBokning";
            this.Text = "Reservera bokning";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReservera;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReservera;
    }
}
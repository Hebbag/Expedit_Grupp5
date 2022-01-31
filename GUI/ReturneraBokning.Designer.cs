namespace PresentationLayer
{
    partial class ReturneraBokning
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
            this.dataGridViewReturnera = new System.Windows.Forms.DataGridView();
            this.Bokningsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medlemsnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anställningsnr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utlämning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Återlämning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnera)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReturnera
            // 
            this.dataGridViewReturnera.AllowUserToAddRows = false;
            this.dataGridViewReturnera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bokningsnummer,
            this.Medlemsnr,
            this.Anställningsnr,
            this.Utlämning,
            this.Återlämning});
            this.dataGridViewReturnera.Location = new System.Drawing.Point(67, 167);
            this.dataGridViewReturnera.Name = "dataGridViewReturnera";
            this.dataGridViewReturnera.RowTemplate.Height = 25;
            this.dataGridViewReturnera.Size = new System.Drawing.Size(646, 239);
            this.dataGridViewReturnera.TabIndex = 0;
            this.dataGridViewReturnera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturnera_CellContentClick);
            // 
            // Bokningsnummer
            // 
            this.Bokningsnummer.HeaderText = "Bokningsnr";
            this.Bokningsnummer.Name = "Bokningsnummer";
            // 
            // Medlemsnr
            // 
            this.Medlemsnr.HeaderText = "Medlemsnr";
            this.Medlemsnr.Name = "Medlemsnr";
            // 
            // Anställningsnr
            // 
            this.Anställningsnr.HeaderText = "Anställningsnr";
            this.Anställningsnr.Name = "Anställningsnr";
            // 
            // Utlämning
            // 
            this.Utlämning.HeaderText = "Utlämning";
            this.Utlämning.Name = "Utlämning";
            // 
            // Återlämning
            // 
            this.Återlämning.HeaderText = "Återlämning";
            this.Återlämning.Name = "Återlämning";
            // 
            // btnReturnera
            // 
            this.btnReturnera.Location = new System.Drawing.Point(561, 50);
            this.btnReturnera.Name = "btnReturnera";
            this.btnReturnera.Size = new System.Drawing.Size(152, 54);
            this.btnReturnera.TabIndex = 1;
            this.btnReturnera.Text = "Returnera";
            this.btnReturnera.UseVisualStyleBackColor = true;
            this.btnReturnera.Click += new System.EventHandler(this.btnReturnera_Click);
            // 
            // ReturneraBokning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnera);
            this.Controls.Add(this.dataGridViewReturnera);
            this.Name = "ReturneraBokning";
            this.Text = "Returnera bokning";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReturnera;
        private System.Windows.Forms.Button btnReturnera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bokningsnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medlemsnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anställningsnr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utlämning;
        private System.Windows.Forms.DataGridViewTextBoxColumn Återlämning;
    }
}
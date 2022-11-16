namespace voorraadsysteemnew
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
            this.btnexit = new System.Windows.Forms.Button();
            this.dgvgerecht = new System.Windows.Forms.DataGridView();
            this.txtnaam = new System.Windows.Forms.TextBox();
            this.txtgewicht = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgerecht)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(901, 458);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(143, 26);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Afsluiten";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // dgvgerecht
            // 
            this.dgvgerecht.AllowUserToAddRows = false;
            this.dgvgerecht.AllowUserToDeleteRows = false;
            this.dgvgerecht.AllowUserToResizeColumns = false;
            this.dgvgerecht.AllowUserToResizeRows = false;
            this.dgvgerecht.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvgerecht.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvgerecht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgerecht.Enabled = false;
            this.dgvgerecht.Location = new System.Drawing.Point(12, 12);
            this.dgvgerecht.Name = "dgvgerecht";
            this.dgvgerecht.RowHeadersWidth = 51;
            this.dgvgerecht.RowTemplate.Height = 24;
            this.dgvgerecht.Size = new System.Drawing.Size(578, 347);
            this.dgvgerecht.TabIndex = 2;
            // 
            // txtnaam
            // 
            this.txtnaam.Location = new System.Drawing.Point(697, 12);
            this.txtnaam.Name = "txtnaam";
            this.txtnaam.Size = new System.Drawing.Size(155, 22);
            this.txtnaam.TabIndex = 3;
            this.txtnaam.TextChanged += new System.EventHandler(this.txtnaam_TextChanged);
            // 
            // txtgewicht
            // 
            this.txtgewicht.Location = new System.Drawing.Point(697, 53);
            this.txtgewicht.Name = "txtgewicht";
            this.txtgewicht.Size = new System.Drawing.Size(155, 22);
            this.txtgewicht.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1056, 496);
            this.Controls.Add(this.txtgewicht);
            this.Controls.Add(this.txtnaam);
            this.Controls.Add(this.dgvgerecht);
            this.Controls.Add(this.btnexit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgerecht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView dgvgerecht;
        private System.Windows.Forms.TextBox txtnaam;
        private System.Windows.Forms.TextBox txtgewicht;
    }
}


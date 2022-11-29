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
            this.lblnaam = new System.Windows.Forms.Label();
            this.lblgewicht = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
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
            this.dgvgerecht.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgerecht_CellContentClick);
            // 
            // txtnaam
            // 
            this.txtnaam.Location = new System.Drawing.Point(646, 160);
            this.txtnaam.Name = "txtnaam";
            this.txtnaam.Size = new System.Drawing.Size(155, 22);
            this.txtnaam.TabIndex = 3;
            this.txtnaam.TextChanged += new System.EventHandler(this.txtnaam_TextChanged);
            // 
            // txtgewicht
            // 
            this.txtgewicht.Location = new System.Drawing.Point(646, 221);
            this.txtgewicht.Name = "txtgewicht";
            this.txtgewicht.Size = new System.Drawing.Size(155, 22);
            this.txtgewicht.TabIndex = 4;
            // 
            // lblnaam
            // 
            this.lblnaam.BackColor = System.Drawing.Color.LightGreen;
            this.lblnaam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnaam.Location = new System.Drawing.Point(646, 137);
            this.lblnaam.Name = "lblnaam";
            this.lblnaam.Size = new System.Drawing.Size(155, 20);
            this.lblnaam.TabIndex = 5;
            this.lblnaam.Text = "Naam";
            this.lblnaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnaam.Click += new System.EventHandler(this.lblnaam_Click);
            // 
            // lblgewicht
            // 
            this.lblgewicht.BackColor = System.Drawing.Color.LightGreen;
            this.lblgewicht.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblgewicht.Location = new System.Drawing.Point(646, 196);
            this.lblgewicht.Name = "lblgewicht";
            this.lblgewicht.Size = new System.Drawing.Size(155, 22);
            this.lblgewicht.TabIndex = 6;
            this.lblgewicht.Text = "Gewicht";
            this.lblgewicht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(920, 61);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(124, 23);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.LightGreen;
            this.lblId.Location = new System.Drawing.Point(646, 64);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(155, 23);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(646, 90);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 22);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(920, 107);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(124, 23);
            this.btnrefresh.TabIndex = 10;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 496);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lblgewicht);
            this.Controls.Add(this.lblnaam);
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
        private System.Windows.Forms.Label lblnaam;
        private System.Windows.Forms.Label lblgewicht;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnrefresh;
    }
}


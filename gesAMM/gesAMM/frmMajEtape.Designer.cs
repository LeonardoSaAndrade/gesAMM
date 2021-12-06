namespace gesAMM
{
    partial class frmMajEtape
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
            this.lvEtapeNormee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbMajNorme = new System.Windows.Forms.TextBox();
            this.tbMajDate = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvEtapeNormee
            // 
            this.lvEtapeNormee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvEtapeNormee.HideSelection = false;
            this.lvEtapeNormee.Location = new System.Drawing.Point(32, 52);
            this.lvEtapeNormee.Name = "lvEtapeNormee";
            this.lvEtapeNormee.Size = new System.Drawing.Size(518, 330);
            this.lvEtapeNormee.TabIndex = 0;
            this.lvEtapeNormee.UseCompatibleStateImageBehavior = false;
            this.lvEtapeNormee.View = System.Windows.Forms.View.Details;
            this.lvEtapeNormee.SelectedIndexChanged += new System.EventHandler(this.lvEtapeNormee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° d\'Étape";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Norme";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            // 
            // tbMajNorme
            // 
            this.tbMajNorme.Location = new System.Drawing.Point(701, 52);
            this.tbMajNorme.Name = "tbMajNorme";
            this.tbMajNorme.Size = new System.Drawing.Size(157, 22);
            this.tbMajNorme.TabIndex = 1;
            // 
            // tbMajDate
            // 
            this.tbMajDate.Location = new System.Drawing.Point(701, 101);
            this.tbMajDate.Name = "tbMajDate";
            this.tbMajDate.Size = new System.Drawing.Size(157, 22);
            this.tbMajDate.TabIndex = 2;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(713, 151);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(129, 50);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Mettre à jour";
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Norme :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date de la norme :";
            // 
            // frmMajEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.tbMajDate);
            this.Controls.Add(this.tbMajNorme);
            this.Controls.Add(this.lvEtapeNormee);
            this.Name = "frmMajEtape";
            this.Text = "frmMajEtape";
            this.Load += new System.EventHandler(this.frmMajEtape_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEtapeNormee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tbMajNorme;
        private System.Windows.Forms.TextBox tbMajDate;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
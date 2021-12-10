namespace gesAMM
{
    partial class ConsultationWorkflowEtapesMedicament
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
            this.cbMedicamentWorkflow = new System.Windows.Forms.ComboBox();
            this.lvEtape = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbMedicamentWorkflow
            // 
            this.cbMedicamentWorkflow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedicamentWorkflow.FormattingEnabled = true;
            this.cbMedicamentWorkflow.Location = new System.Drawing.Point(12, 12);
            this.cbMedicamentWorkflow.Name = "cbMedicamentWorkflow";
            this.cbMedicamentWorkflow.Size = new System.Drawing.Size(121, 21);
            this.cbMedicamentWorkflow.TabIndex = 0;
            this.cbMedicamentWorkflow.SelectedIndexChanged += new System.EventHandler(this.cbMedicamentWorkflow_SelectedIndexChanged);
            // 
            // lvEtape
            // 
            this.lvEtape.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvEtape.HideSelection = false;
            this.lvEtape.Location = new System.Drawing.Point(12, 65);
            this.lvEtape.Name = "lvEtape";
            this.lvEtape.Size = new System.Drawing.Size(549, 199);
            this.lvEtape.TabIndex = 1;
            this.lvEtape.UseCompatibleStateImageBehavior = false;
            this.lvEtape.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "n° de l\'etape";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "libellé";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "date de décision";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "libellé de la décision";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "norme";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "date de la norme";
            this.columnHeader6.Width = 110;
            // 
            // ConsultationWorkflowEtapesMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 288);
            this.Controls.Add(this.lvEtape);
            this.Controls.Add(this.cbMedicamentWorkflow);
            this.Name = "ConsultationWorkflowEtapesMedicament";
            this.Text = "Consultation du workflow des étapes d\'un medicament";
            this.Load += new System.EventHandler(this.ConsultationWorkflowEtapesMedicament_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedicamentWorkflow;
        private System.Windows.Forms.ListView lvEtape;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
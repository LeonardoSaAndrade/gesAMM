
namespace gesAMM
{
    partial class frmConsultMed
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lvConsulMed = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDetailMedFam = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvConsulMed
            // 
            this.lvConsulMed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvConsulMed.HideSelection = false;
            this.lvConsulMed.Location = new System.Drawing.Point(32, 29);
            this.lvConsulMed.Name = "lvConsulMed";
            this.lvConsulMed.Size = new System.Drawing.Size(691, 221);
            this.lvConsulMed.TabIndex = 0;
            this.lvConsulMed.UseCompatibleStateImageBehavior = false;
            this.lvConsulMed.View = System.Windows.Forms.View.Details;
            this.lvConsulMed.SelectedIndexChanged += new System.EventHandler(this.lvConsulMed_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Libelle";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Code";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre de Med";
            this.columnHeader3.Width = 143;
            // 
            // lvDetailMedFam
            // 
            this.lvDetailMedFam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvDetailMedFam.HideSelection = false;
            this.lvDetailMedFam.Location = new System.Drawing.Point(32, 288);
            this.lvDetailMedFam.Name = "lvDetailMedFam";
            this.lvDetailMedFam.Size = new System.Drawing.Size(691, 221);
            this.lvDetailMedFam.TabIndex = 1;
            this.lvDetailMedFam.UseCompatibleStateImageBehavior = false;
            this.lvDetailMedFam.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Depot légal";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nom commercial";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Code Fam";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Composition Med";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Effet";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Contre indication";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Prix Echantillon";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "dernière étape";
            this.columnHeader11.Width = 147;
            // 
            // frmConsultMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 604);
            this.Controls.Add(this.lvDetailMedFam);
            this.Controls.Add(this.lvConsulMed);
            this.Name = "frmConsultMed";
            this.Text = "frmConsultMed";
            this.Load += new System.EventHandler(this.frmConsultMed_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView lvConsulMed;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvDetailMedFam;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}
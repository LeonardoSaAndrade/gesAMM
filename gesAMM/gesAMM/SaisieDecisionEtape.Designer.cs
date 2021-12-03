namespace gesAMM
{
    partial class SaisieDecisionEtape
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
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.btValiderMedicament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(67, 58);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(121, 21);
            this.cbMedicament.TabIndex = 0;
            // 
            // btValiderMedicament
            // 
            this.btValiderMedicament.Location = new System.Drawing.Point(242, 58);
            this.btValiderMedicament.Name = "btValiderMedicament";
            this.btValiderMedicament.Size = new System.Drawing.Size(75, 23);
            this.btValiderMedicament.TabIndex = 1;
            this.btValiderMedicament.Text = "Valider";
            this.btValiderMedicament.UseVisualStyleBackColor = true;
            this.btValiderMedicament.Click += new System.EventHandler(this.btValiderMedicament_Click);
            // 
            // SaisieDecisionEtape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btValiderMedicament);
            this.Controls.Add(this.cbMedicament);
            this.Name = "SaisieDecisionEtape";
            this.Text = "Saisie de la décision d\'une étape";
            this.Load += new System.EventHandler(this.SaisieDecisionEtape_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.Button btValiderMedicament;
    }
}
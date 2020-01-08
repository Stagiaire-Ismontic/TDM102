namespace TP3
{
    partial class TP3
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.btn_SB = new System.Windows.Forms.Button();
            this.Btn_SOT = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(62, 111);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 20);
            this.DTP.TabIndex = 0;
            // 
            // btn_SB
            // 
            this.btn_SB.Location = new System.Drawing.Point(103, 163);
            this.btn_SB.Name = "btn_SB";
            this.btn_SB.Size = new System.Drawing.Size(118, 23);
            this.btn_SB.TabIndex = 1;
            this.btn_SB.Text = "Set your Birth ";
            this.btn_SB.UseVisualStyleBackColor = true;
            this.btn_SB.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_SOT
            // 
            this.Btn_SOT.Location = new System.Drawing.Point(103, 210);
            this.Btn_SOT.Name = "Btn_SOT";
            this.Btn_SOT.Size = new System.Drawing.Size(118, 23);
            this.Btn_SOT.TabIndex = 2;
            this.Btn_SOT.Text = "Show Originale time";
            this.Btn_SOT.UseVisualStyleBackColor = true;
            this.Btn_SOT.Click += new System.EventHandler(this.Btn_SOT_Click);
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_1.Location = new System.Drawing.Point(58, 58);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(213, 24);
            this.lbl_1.TabIndex = 3;
            this.lbl_1.Text = "Please ! enter your birth ";
            this.lbl_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.Btn_SOT);
            this.Controls.Add(this.btn_SB);
            this.Controls.Add(this.DTP);
            this.Name = "TP3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Button btn_SB;
        private System.Windows.Forms.Button Btn_SOT;
        private System.Windows.Forms.Label lbl_1;
    }
}


namespace TP02
{
    partial class Calculatris
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
            this.Lbl_N2 = new System.Windows.Forms.Label();
            this.Lbl_N1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_N2
            // 
            this.Lbl_N2.AutoSize = true;
            this.Lbl_N2.Location = new System.Drawing.Point(200, 42);
            this.Lbl_N2.Name = "Lbl_N2";
            this.Lbl_N2.Size = new System.Drawing.Size(53, 13);
            this.Lbl_N2.TabIndex = 0;
            this.Lbl_N2.Text = "Number 2";
            this.Lbl_N2.Click += new System.EventHandler(this.Lbl_N2_Click);
            // 
            // Lbl_N1
            // 
            this.Lbl_N1.AutoSize = true;
            this.Lbl_N1.Location = new System.Drawing.Point(62, 42);
            this.Lbl_N1.Name = "Lbl_N1";
            this.Lbl_N1.Size = new System.Drawing.Size(53, 13);
            this.Lbl_N1.TabIndex = 1;
            this.Lbl_N1.Text = "Number 1";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(34, 58);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(176, 58);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 3;
            this.txt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(99, 100);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(45, 23);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "+";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(160, 100);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(45, 23);
            this.Btn2.TabIndex = 5;
            this.Btn2.Text = "_";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(99, 138);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(45, 23);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = "x";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(160, 138);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(45, 23);
            this.Btn4.TabIndex = 7;
            this.Btn4.Text = "/";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(129, 173);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(50, 13);
            this.Lbl3.TabIndex = 8;
            this.Lbl3.Text = "RESULT";
            this.Lbl3.Click += new System.EventHandler(this.Lbl3_Click);
            // 
            // Calculatris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP02.Properties.Resources.bac_maths_2017_les_cours_pour_reussir__lg_34013;
            this.ClientSize = new System.Drawing.Size(316, 194);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.Lbl_N1);
            this.Controls.Add(this.Lbl_N2);
            this.Name = "Calculatris";
            this.Text = "Kebyani_TP02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Calculatris_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_N2;
        private System.Windows.Forms.Label Lbl_N1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Label Lbl3;
    }
}


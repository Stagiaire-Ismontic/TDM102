namespace WindowsFormsApp1
{
    partial class WindowsFormsApp1
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
            this.Lbl_a = new System.Windows.Forms.Label();
            this.Lbl_b = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.tbx_1 = new System.Windows.Forms.TextBox();
            this.tbx_2 = new System.Windows.Forms.TextBox();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_soustraction = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_a
            // 
            this.Lbl_a.AutoSize = true;
            this.Lbl_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Lbl_a.Location = new System.Drawing.Point(343, 39);
            this.Lbl_a.Name = "Lbl_a";
            this.Lbl_a.Size = new System.Drawing.Size(94, 24);
            this.Lbl_a.TabIndex = 1;
            this.Lbl_a.Text = "Number 1";
            // 
            // Lbl_b
            // 
            this.Lbl_b.AutoSize = true;
            this.Lbl_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Lbl_b.Location = new System.Drawing.Point(343, 90);
            this.Lbl_b.Name = "Lbl_b";
            this.Lbl_b.Size = new System.Drawing.Size(94, 24);
            this.Lbl_b.TabIndex = 2;
            this.Lbl_b.Text = "Number 2";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_result.Location = new System.Drawing.Point(452, 231);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(62, 24);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Result";
            this.lbl_result.Click += new System.EventHandler(this.lbl_result_Click);
            // 
            // tbx_1
            // 
            this.tbx_1.Location = new System.Drawing.Point(472, 39);
            this.tbx_1.Name = "tbx_1";
            this.tbx_1.Size = new System.Drawing.Size(121, 20);
            this.tbx_1.TabIndex = 4;
            // 
            // tbx_2
            // 
            this.tbx_2.Location = new System.Drawing.Point(472, 94);
            this.tbx_2.Name = "tbx_2";
            this.tbx_2.Size = new System.Drawing.Size(121, 20);
            this.tbx_2.TabIndex = 5;
            // 
            // btn_addition
            // 
            this.btn_addition.BackColor = System.Drawing.Color.Red;
            this.btn_addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_addition.Location = new System.Drawing.Point(520, 159);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(35, 39);
            this.btn_addition.TabIndex = 6;
            this.btn_addition.Text = "+";
            this.btn_addition.UseVisualStyleBackColor = false;
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_soustraction
            // 
            this.btn_soustraction.BackColor = System.Drawing.Color.Red;
            this.btn_soustraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_soustraction.Location = new System.Drawing.Point(439, 158);
            this.btn_soustraction.Name = "btn_soustraction";
            this.btn_soustraction.Size = new System.Drawing.Size(35, 40);
            this.btn_soustraction.TabIndex = 7;
            this.btn_soustraction.Text = "-";
            this.btn_soustraction.UseVisualStyleBackColor = false;
            this.btn_soustraction.Click += new System.EventHandler(this.btn_soustraction_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.BackColor = System.Drawing.Color.Red;
            this.btn_multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_multiplication.Location = new System.Drawing.Point(399, 159);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(34, 39);
            this.btn_multiplication.TabIndex = 8;
            this.btn_multiplication.Text = "*";
            this.btn_multiplication.UseVisualStyleBackColor = false;
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.Red;
            this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_division.Location = new System.Drawing.Point(480, 158);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(34, 40);
            this.btn_division.TabIndex = 9;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // WindowsFormsApp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 297);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_soustraction);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.tbx_2);
            this.Controls.Add(this.tbx_1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.Lbl_b);
            this.Controls.Add(this.Lbl_a);
            this.Name = "WindowsFormsApp1";
            this.Text = "Calculatrice ";
            this.Load += new System.EventHandler(this.WindowsFormsApp1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_a;
        private System.Windows.Forms.Label Lbl_b;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.TextBox tbx_1;
        private System.Windows.Forms.TextBox tbx_2;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_soustraction;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_division;
    }
}


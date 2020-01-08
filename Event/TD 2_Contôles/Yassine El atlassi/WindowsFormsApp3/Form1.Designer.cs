namespace WindowsFormsApp3
{
    partial class Form1
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
            this.Lbl_Number1 = new System.Windows.Forms.Label();
            this.Lbl_Number2 = new System.Windows.Forms.Label();
            this.Txt_2 = new System.Windows.Forms.TextBox();
            this.Txt_1 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Number1
            // 
            this.Lbl_Number1.AutoSize = true;
            this.Lbl_Number1.BackColor = System.Drawing.Color.Azure;
            this.Lbl_Number1.Location = new System.Drawing.Point(32, 23);
            this.Lbl_Number1.Name = "Lbl_Number1";
            this.Lbl_Number1.Size = new System.Drawing.Size(70, 17);
            this.Lbl_Number1.TabIndex = 0;
            this.Lbl_Number1.Text = "Number 1";
            // 
            // Lbl_Number2
            // 
            this.Lbl_Number2.AutoSize = true;
            this.Lbl_Number2.BackColor = System.Drawing.Color.MintCream;
            this.Lbl_Number2.Location = new System.Drawing.Point(211, 23);
            this.Lbl_Number2.Name = "Lbl_Number2";
            this.Lbl_Number2.Size = new System.Drawing.Size(70, 17);
            this.Lbl_Number2.TabIndex = 1;
            this.Lbl_Number2.Text = "Number 2";
            // 
            // Txt_2
            // 
            this.Txt_2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Txt_2.Location = new System.Drawing.Point(198, 67);
            this.Txt_2.Name = "Txt_2";
            this.Txt_2.Size = new System.Drawing.Size(100, 22);
            this.Txt_2.TabIndex = 2;
            this.Txt_2.UseWaitCursor = true;
            this.Txt_2.TextChanged += new System.EventHandler(this.Txt_2_TextChanged);
            // 
            // Txt_1
            // 
            this.Txt_1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Txt_1.Location = new System.Drawing.Point(21, 67);
            this.Txt_1.Name = "Txt_1";
            this.Txt_1.Size = new System.Drawing.Size(100, 22);
            this.Txt_1.TabIndex = 3;
            this.Txt_1.UseWaitCursor = true;
            this.Txt_1.TextChanged += new System.EventHandler(this.Txt_1_TextChanged);
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(90, 240);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(136, 34);
            this.txt_result.TabIndex = 4;
            this.txt_result.Text = "Result";
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(111, 129);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(42, 35);
            this.btn_1.TabIndex = 5;
            this.btn_1.Text = "+";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(159, 129);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(42, 35);
            this.btn_2.TabIndex = 6;
            this.btn_2.Text = "-";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(112, 177);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(42, 35);
            this.btn_3.TabIndex = 7;
            this.btn_3.Text = "x";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(159, 177);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(42, 35);
            this.btn_4.TabIndex = 8;
            this.btn_4.Text = "/";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._824696;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 334);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.Txt_1);
            this.Controls.Add(this.Txt_2);
            this.Controls.Add(this.Lbl_Number2);
            this.Controls.Add(this.Lbl_Number1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Number1;
        private System.Windows.Forms.Label Lbl_Number2;
        private System.Windows.Forms.TextBox Txt_2;
        private System.Windows.Forms.TextBox Txt_1;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
    }
}


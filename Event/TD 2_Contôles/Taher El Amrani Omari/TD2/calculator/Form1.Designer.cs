namespace calculator
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.txt_number1 = new System.Windows.Forms.Label();
            this.txt_number2 = new System.Windows.Forms.Label();
            this.btt_Total = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btt_Multiply = new System.Windows.Forms.Button();
            this.btt_Substract = new System.Windows.Forms.Button();
            this.btt_divid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(66, 49);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(100, 20);
            this.txt_1.TabIndex = 0;
            this.txt_1.TextChanged += new System.EventHandler(this.n1_TextChanged);
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(66, 75);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(100, 20);
            this.txt_2.TabIndex = 1;
            // 
            // txt_number1
            // 
            this.txt_number1.AutoSize = true;
            this.txt_number1.Location = new System.Drawing.Point(12, 52);
            this.txt_number1.Name = "txt_number1";
            this.txt_number1.Size = new System.Drawing.Size(48, 13);
            this.txt_number1.TabIndex = 2;
            this.txt_number1.Text = "number1";
            // 
            // txt_number2
            // 
            this.txt_number2.AutoSize = true;
            this.txt_number2.Location = new System.Drawing.Point(12, 82);
            this.txt_number2.Name = "txt_number2";
            this.txt_number2.Size = new System.Drawing.Size(48, 13);
            this.txt_number2.TabIndex = 3;
            this.txt_number2.Text = "number2";
            this.txt_number2.Click += new System.EventHandler(this.txt_number2_Click);
            // 
            // btt_Total
            // 
            this.btt_Total.Location = new System.Drawing.Point(53, 114);
            this.btt_Total.Name = "btt_Total";
            this.btt_Total.Size = new System.Drawing.Size(75, 23);
            this.btt_Total.TabIndex = 4;
            this.btt_Total.Text = "Total";
            this.btt_Total.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btt_Total.UseVisualStyleBackColor = true;
            this.btt_Total.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(235, 239);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(43, 13);
            this.lbl_Result.TabIndex = 5;
            this.lbl_Result.Text = "______";
            this.lbl_Result.Click += new System.EventHandler(this.lbl_Result_Click);
            // 
            // btt_Multiply
            // 
            this.btt_Multiply.Location = new System.Drawing.Point(134, 114);
            this.btt_Multiply.Name = "btt_Multiply";
            this.btt_Multiply.Size = new System.Drawing.Size(75, 23);
            this.btt_Multiply.TabIndex = 6;
            this.btt_Multiply.Text = "multiplication";
            this.btt_Multiply.UseVisualStyleBackColor = true;
            this.btt_Multiply.Click += new System.EventHandler(this.btt_Multiply_Click);
            // 
            // btt_Substract
            // 
            this.btt_Substract.Location = new System.Drawing.Point(53, 143);
            this.btt_Substract.Name = "btt_Substract";
            this.btt_Substract.Size = new System.Drawing.Size(75, 23);
            this.btt_Substract.TabIndex = 7;
            this.btt_Substract.Text = "substraction";
            this.btt_Substract.UseVisualStyleBackColor = true;
            this.btt_Substract.Click += new System.EventHandler(this.btt_Substract_Click);
            // 
            // btt_divid
            // 
            this.btt_divid.Location = new System.Drawing.Point(135, 142);
            this.btt_divid.Name = "btt_divid";
            this.btt_divid.Size = new System.Drawing.Size(75, 23);
            this.btt_divid.TabIndex = 8;
            this.btt_divid.Text = "division";
            this.btt_divid.UseVisualStyleBackColor = true;
            this.btt_divid.Click += new System.EventHandler(this.btt_divid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_divid);
            this.Controls.Add(this.btt_Substract);
            this.Controls.Add(this.btt_Multiply);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btt_Total);
            this.Controls.Add(this.txt_number2);
            this.Controls.Add(this.txt_number1);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label txt_number1;
        private System.Windows.Forms.Label txt_number2;
        private System.Windows.Forms.Button btt_Total;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btt_Multiply;
        private System.Windows.Forms.Button btt_Substract;
        private System.Windows.Forms.Button btt_divid;
        private System.Windows.Forms.Label label1;
    }
}


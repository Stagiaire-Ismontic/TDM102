namespace Tp3
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pnl_research = new System.Windows.Forms.Panel();
            this.btn_research = new System.Windows.Forms.Button();
            this.lbl_reault = new System.Windows.Forms.Label();
            this.txt_resault = new System.Windows.Forms.Label();
            this.txt_name_research = new System.Windows.Forms.TextBox();
            this.lbl_research = new System.Windows.Forms.Label();
            this.pnl_sign_in = new System.Windows.Forms.Panel();
            this.btn_sign = new System.Windows.Forms.Button();
            this.lbl_birthday_sign = new System.Windows.Forms.Label();
            this.lbl_nameToSign = new System.Windows.Forms.Label();
            this.name_sign = new System.Windows.Forms.TextBox();
            this.date_sign = new System.Windows.Forms.DateTimePicker();
            this.lbl_sign_in = new System.Windows.Forms.Label();
            this.pnl_research.SuspendLayout();
            this.pnl_sign_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.DimGray;
            this.lbl_welcome.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcome.Image = global::Tp3.Properties.Resources.fond_tp3;
            this.lbl_welcome.Location = new System.Drawing.Point(275, 22);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(260, 32);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome student:";
            // 
            // pnl_research
            // 
            this.pnl_research.BackColor = System.Drawing.Color.DimGray;
            this.pnl_research.BackgroundImage = global::Tp3.Properties.Resources.fond_tp3;
            this.pnl_research.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_research.Controls.Add(this.btn_research);
            this.pnl_research.Controls.Add(this.lbl_reault);
            this.pnl_research.Controls.Add(this.txt_resault);
            this.pnl_research.Controls.Add(this.txt_name_research);
            this.pnl_research.Controls.Add(this.lbl_research);
            this.pnl_research.Location = new System.Drawing.Point(52, 94);
            this.pnl_research.Name = "pnl_research";
            this.pnl_research.Size = new System.Drawing.Size(303, 329);
            this.pnl_research.TabIndex = 1;
            this.pnl_research.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_research_Paint);
            // 
            // btn_research
            // 
            this.btn_research.Location = new System.Drawing.Point(114, 119);
            this.btn_research.Name = "btn_research";
            this.btn_research.Size = new System.Drawing.Size(61, 23);
            this.btn_research.TabIndex = 4;
            this.btn_research.Text = "Done";
            this.btn_research.UseVisualStyleBackColor = true;
            this.btn_research.Click += new System.EventHandler(this.btn_research_Click);
            // 
            // lbl_reault
            // 
            this.lbl_reault.AutoSize = true;
            this.lbl_reault.BackColor = System.Drawing.Color.Black;
            this.lbl_reault.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reault.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_reault.Location = new System.Drawing.Point(89, 162);
            this.lbl_reault.Name = "lbl_reault";
            this.lbl_reault.Size = new System.Drawing.Size(106, 29);
            this.lbl_reault.TabIndex = 3;
            this.lbl_reault.Text = "Resault";
            // 
            // txt_resault
            // 
            this.txt_resault.AutoSize = true;
            this.txt_resault.BackColor = System.Drawing.Color.White;
            this.txt_resault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resault.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txt_resault.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resault.Location = new System.Drawing.Point(80, 228);
            this.txt_resault.Name = "txt_resault";
            this.txt_resault.Size = new System.Drawing.Size(128, 26);
            this.txt_resault.TabIndex = 2;
            this.txt_resault.Text = "DD/MM/YYYY";
            this.txt_resault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_resault.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // txt_name_research
            // 
            this.txt_name_research.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_name_research.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_name_research.Location = new System.Drawing.Point(94, 76);
            this.txt_name_research.Name = "txt_name_research";
            this.txt_name_research.Size = new System.Drawing.Size(100, 22);
            this.txt_name_research.TabIndex = 1;
            this.txt_name_research.Text = "Name";
            this.txt_name_research.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name_research.UseWaitCursor = true;
            // 
            // lbl_research
            // 
            this.lbl_research.AutoSize = true;
            this.lbl_research.BackColor = System.Drawing.Color.Black;
            this.lbl_research.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_research.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_research.Location = new System.Drawing.Point(75, 25);
            this.lbl_research.Name = "lbl_research";
            this.lbl_research.Size = new System.Drawing.Size(137, 29);
            this.lbl_research.TabIndex = 0;
            this.lbl_research.Text = "Research ";
            this.lbl_research.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_sign_in
            // 
            this.pnl_sign_in.BackColor = System.Drawing.Color.SkyBlue;
            this.pnl_sign_in.BackgroundImage = global::Tp3.Properties.Resources.fond_tp3;
            this.pnl_sign_in.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_sign_in.Controls.Add(this.btn_sign);
            this.pnl_sign_in.Controls.Add(this.lbl_birthday_sign);
            this.pnl_sign_in.Controls.Add(this.lbl_nameToSign);
            this.pnl_sign_in.Controls.Add(this.name_sign);
            this.pnl_sign_in.Controls.Add(this.date_sign);
            this.pnl_sign_in.Controls.Add(this.lbl_sign_in);
            this.pnl_sign_in.Location = new System.Drawing.Point(448, 94);
            this.pnl_sign_in.Name = "pnl_sign_in";
            this.pnl_sign_in.Size = new System.Drawing.Size(303, 329);
            this.pnl_sign_in.TabIndex = 2;
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(116, 216);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(61, 23);
            this.btn_sign.TabIndex = 5;
            this.btn_sign.Text = "Done";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // lbl_birthday_sign
            // 
            this.lbl_birthday_sign.AutoSize = true;
            this.lbl_birthday_sign.BackColor = System.Drawing.Color.White;
            this.lbl_birthday_sign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_birthday_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthday_sign.Location = new System.Drawing.Point(23, 151);
            this.lbl_birthday_sign.Name = "lbl_birthday_sign";
            this.lbl_birthday_sign.Size = new System.Drawing.Size(83, 17);
            this.lbl_birthday_sign.TabIndex = 3;
            this.lbl_birthday_sign.Text = "Birthday:  ";
            this.lbl_birthday_sign.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbl_nameToSign
            // 
            this.lbl_nameToSign.AutoSize = true;
            this.lbl_nameToSign.BackColor = System.Drawing.Color.White;
            this.lbl_nameToSign.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_nameToSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameToSign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_nameToSign.Location = new System.Drawing.Point(23, 81);
            this.lbl_nameToSign.Name = "lbl_nameToSign";
            this.lbl_nameToSign.Size = new System.Drawing.Size(83, 17);
            this.lbl_nameToSign.TabIndex = 3;
            this.lbl_nameToSign.Text = "Full name:";
            this.lbl_nameToSign.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // name_sign
            // 
            this.name_sign.Location = new System.Drawing.Point(129, 78);
            this.name_sign.Name = "name_sign";
            this.name_sign.Size = new System.Drawing.Size(145, 22);
            this.name_sign.TabIndex = 2;
            // 
            // date_sign
            // 
            this.date_sign.Location = new System.Drawing.Point(129, 151);
            this.date_sign.Name = "date_sign";
            this.date_sign.Size = new System.Drawing.Size(145, 22);
            this.date_sign.TabIndex = 1;
            this.date_sign.Value = new System.DateTime(2020, 1, 8, 0, 0, 0, 0);
            this.date_sign.ValueChanged += new System.EventHandler(this.date_sign_ValueChanged);
            // 
            // lbl_sign_in
            // 
            this.lbl_sign_in.AutoSize = true;
            this.lbl_sign_in.BackColor = System.Drawing.Color.Black;
            this.lbl_sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sign_in.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_sign_in.Location = new System.Drawing.Point(99, 25);
            this.lbl_sign_in.Name = "lbl_sign_in";
            this.lbl_sign_in.Size = new System.Drawing.Size(98, 29);
            this.lbl_sign_in.TabIndex = 0;
            this.lbl_sign_in.Text = "Sign in";
            this.lbl_sign_in.Click += new System.EventHandler(this.lbl_sign_in_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Tp3.Properties.Resources.fond_tp3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_sign_in);
            this.Controls.Add(this.pnl_research);
            this.Controls.Add(this.lbl_welcome);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_research.ResumeLayout(false);
            this.pnl_research.PerformLayout();
            this.pnl_sign_in.ResumeLayout(false);
            this.pnl_sign_in.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Panel pnl_research;
        private System.Windows.Forms.Label lbl_research;
        private System.Windows.Forms.Panel pnl_sign_in;
        private System.Windows.Forms.Label lbl_sign_in;
        private System.Windows.Forms.Label lbl_nameToSign;
        private System.Windows.Forms.TextBox name_sign;
        private System.Windows.Forms.DateTimePicker date_sign;
        private System.Windows.Forms.Label lbl_birthday_sign;
        private System.Windows.Forms.TextBox txt_name_research;
        private System.Windows.Forms.Label lbl_reault;
        private System.Windows.Forms.Button btn_research;
        private System.Windows.Forms.Button btn_sign;
        private System.Windows.Forms.Label txt_resault;
    }
}


namespace TP1
{
    partial class TP1
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
            this.btn_calcule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calcule
            // 
            this.btn_calcule.Location = new System.Drawing.Point(516, 339);
            this.btn_calcule.Name = "btn_calcule";
            this.btn_calcule.Size = new System.Drawing.Size(142, 40);
            this.btn_calcule.TabIndex = 0;
            this.btn_calcule.Text = "calcule";
            this.btn_calcule.UseVisualStyleBackColor = true;
            this.btn_calcule.Click += new System.EventHandler(this.button1_Click);
            // 
            // TP1
            // 
            this.AccessibleDescription = "hello everyone ";
            this.AccessibleName = "TP1 - Omar Zaoujal ";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.AutoScaleDimensions = new System.Drawing.SizeF(325F, 800F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::TP1.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(780, 483);
            this.Controls.Add(this.btn_calcule);
            this.Font = new System.Drawing.Font("Kozuka Gothic Pro H", 555F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.MaximumSize = new System.Drawing.Size(800, 526);
            this.MinimumSize = new System.Drawing.Size(800, 526);
            this.Name = "TP1";
            this.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP1 - Omar Zaoujal";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.TP1_Load);
            this.ResizeBegin += new System.EventHandler(this.TP1_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.TP1_ResizeEnd);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TP1_Scroll);
            this.DoubleClick += new System.EventHandler(this.TP1_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TP1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calcule;
    }
}
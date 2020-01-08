namespace TD3
{
    partial class Birthday
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.okbtt = new System.Windows.Forms.Button();
            this.Resetbtt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // okbtt
            // 
            this.okbtt.Location = new System.Drawing.Point(30, 95);
            this.okbtt.Name = "okbtt";
            this.okbtt.Size = new System.Drawing.Size(75, 23);
            this.okbtt.TabIndex = 1;
            this.okbtt.Text = "ok";
            this.okbtt.UseVisualStyleBackColor = true;
            this.okbtt.Click += new System.EventHandler(this.okbtt_Click);
            // 
            // Resetbtt
            // 
            this.Resetbtt.Location = new System.Drawing.Point(30, 226);
            this.Resetbtt.Name = "Resetbtt";
            this.Resetbtt.Size = new System.Drawing.Size(75, 23);
            this.Resetbtt.TabIndex = 2;
            this.Resetbtt.Text = "Reset";
            this.Resetbtt.UseVisualStyleBackColor = true;
            this.Resetbtt.Click += new System.EventHandler(this.resertbtt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please entre your full birthday:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(30, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resert to today:";
            // 
            // Birthday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resetbtt);
            this.Controls.Add(this.okbtt);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Birthday";
            this.Text = "birthday ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button okbtt;
        private System.Windows.Forms.Button Resetbtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
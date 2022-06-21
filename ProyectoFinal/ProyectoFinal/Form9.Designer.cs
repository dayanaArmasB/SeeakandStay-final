namespace ProyectoFinal
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.gboSobre = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.gboSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboSobre
            // 
            this.gboSobre.Controls.Add(this.label14);
            this.gboSobre.Location = new System.Drawing.Point(32, 21);
            this.gboSobre.Name = "gboSobre";
            this.gboSobre.Size = new System.Drawing.Size(544, 492);
            this.gboSobre.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(10, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(443, 180);
            this.label14.TabIndex = 1;
            this.label14.Text = resources.GetString("label14.Text");
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(776, 590);
            this.Controls.Add(this.gboSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.Text = "Form9";
            this.gboSobre.ResumeLayout(false);
            this.gboSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel gboSobre;
        private Label label14;
    }
}
namespace AvanzandoProyecto
{
    partial class PaisEncontrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaisEncontrado));
            this.lblEditable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEncuentra = new System.Windows.Forms.Button();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditable
            // 
            this.lblEditable.AutoSize = true;
            this.lblEditable.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEditable.Location = new System.Drawing.Point(45, 101);
            this.lblEditable.Name = "lblEditable";
            this.lblEditable.Size = new System.Drawing.Size(0, 24);
            this.lblEditable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 40);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnEncuentra
            // 
            this.btnEncuentra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnEncuentra.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnEncuentra.FlatAppearance.BorderSize = 0;
            this.btnEncuentra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnEncuentra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnEncuentra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncuentra.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEncuentra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncuentra.Location = new System.Drawing.Point(492, 64);
            this.btnEncuentra.Margin = new System.Windows.Forms.Padding(0);
            this.btnEncuentra.Name = "btnEncuentra";
            this.btnEncuentra.Size = new System.Drawing.Size(190, 72);
            this.btnEncuentra.TabIndex = 3;
            this.btnEncuentra.Text = "Ordenar bolsas de viaje desde las mas económicos";
            this.btnEncuentra.UseVisualStyleBackColor = false;
            this.btnEncuentra.Click += new System.EventHandler(this.btnEncuentra_Click);
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Source Sans Pro Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrdenar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOrdenar.Location = new System.Drawing.Point(490, 151);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(0, 24);
            this.lblOrdenar.TabIndex = 4;
            // 
            // PaisEncontrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(724, 632);
            this.Controls.Add(this.lblOrdenar);
            this.Controls.Add(this.btnEncuentra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEditable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(681, 188);
            this.Name = "PaisEncontrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PaisEncontrado";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEditable;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnEncuentra;
        private Label lblOrdenar;
    }
}
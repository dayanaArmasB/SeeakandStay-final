namespace AvanzandoProyecto
{
    partial class Form5
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
            this.gboLenguaje = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_musica = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.gboLenguaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboLenguaje
            // 
            this.gboLenguaje.Controls.Add(this.label1);
            this.gboLenguaje.Controls.Add(this.btn_musica);
            this.gboLenguaje.Controls.Add(this.label12);
            this.gboLenguaje.Controls.Add(this.button6);
            this.gboLenguaje.Controls.Add(this.cboIdioma);
            this.gboLenguaje.Location = new System.Drawing.Point(3, 50);
            this.gboLenguaje.Name = "gboLenguaje";
            this.gboLenguaje.Size = new System.Drawing.Size(604, 516);
            this.gboLenguaje.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sonido:";
            // 
            // btn_musica
            // 
            this.btn_musica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_musica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_musica.Location = new System.Drawing.Point(189, 152);
            this.btn_musica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_musica.Name = "btn_musica";
            this.btn_musica.Size = new System.Drawing.Size(28, 24);
            this.btn_musica.TabIndex = 22;
            this.btn_musica.UseVisualStyleBackColor = true;
            this.btn_musica.Click += new System.EventHandler(this.btn_musica_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(39, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Selecciona el lenguaje:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(346, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 44);
            this.button6.TabIndex = 16;
            this.button6.Text = "Guardar cambios";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cboIdioma
            // 
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.cboIdioma.Location = new System.Drawing.Point(189, 76);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(121, 23);
            this.cboIdioma.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1041, 666);
            this.Controls.Add(this.gboLenguaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.gboLenguaje.ResumeLayout(false);
            this.gboLenguaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel gboLenguaje;
        private Label label12;
        private Button button6;
        private ComboBox cboIdioma;
        private Label label1;
        private Button btn_musica;
    }
}
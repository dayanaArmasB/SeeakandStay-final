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
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.gboLenguaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboLenguaje
            // 
            this.gboLenguaje.Controls.Add(this.label12);
            this.gboLenguaje.Controls.Add(this.button6);
            this.gboLenguaje.Controls.Add(this.cboIdioma);
            this.gboLenguaje.Location = new System.Drawing.Point(3, 50);
            this.gboLenguaje.Name = "gboLenguaje";
            this.gboLenguaje.Size = new System.Drawing.Size(443, 516);
            this.gboLenguaje.TabIndex = 21;
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
            this.button6.Location = new System.Drawing.Point(91, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 44);
            this.button6.TabIndex = 16;
            this.button6.Text = "Guardar cambios";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cboIdioma
            // 
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
    }
}
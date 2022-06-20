namespace ProyectoFinal
{
    partial class Form8
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
            this.gbo2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.cboEstudios = new System.Windows.Forms.ComboBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtBag = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboContinent = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.gbo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbo2
            // 
            this.gbo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.gbo2.Controls.Add(this.button1);
            this.gbo2.Controls.Add(this.label1);
            this.gbo2.Controls.Add(this.label7);
            this.gbo2.Controls.Add(this.label6);
            this.gbo2.Controls.Add(this.rbNo);
            this.gbo2.Controls.Add(this.rbSi);
            this.gbo2.Controls.Add(this.cboEstudios);
            this.gbo2.Controls.Add(this.txtAge);
            this.gbo2.Controls.Add(this.txtBag);
            this.gbo2.Controls.Add(this.cboGender);
            this.gbo2.Controls.Add(this.label16);
            this.gbo2.Controls.Add(this.label11);
            this.gbo2.Controls.Add(this.cboContinent);
            this.gbo2.Controls.Add(this.label17);
            this.gbo2.Controls.Add(this.label13);
            this.gbo2.Controls.Add(this.cboCountry);
            this.gbo2.Controls.Add(this.label15);
            this.gbo2.Controls.Add(this.btnAnalyze);
            this.gbo2.Location = new System.Drawing.Point(54, 29);
            this.gbo2.Name = "gbo2";
            this.gbo2.Size = new System.Drawing.Size(601, 555);
            this.gbo2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(306, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 44);
            this.button1.TabIndex = 41;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(306, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "(In dollars)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(25, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Educational level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(25, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Visa";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbNo.Location = new System.Drawing.Point(210, 323);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(41, 19);
            this.rbNo.TabIndex = 37;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbSi.Location = new System.Drawing.Point(170, 323);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(34, 19);
            this.rbSi.TabIndex = 36;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Si";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // cboEstudios
            // 
            this.cboEstudios.FormattingEnabled = true;
            this.cboEstudios.Items.AddRange(new object[] {
            "Niguno",
            "Secundaria completa",
            "Titulo universitario"});
            this.cboEstudios.Location = new System.Drawing.Point(170, 384);
            this.cboEstudios.Name = "cboEstudios";
            this.cboEstudios.Size = new System.Drawing.Size(121, 23);
            this.cboEstudios.TabIndex = 35;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(170, 215);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(121, 23);
            this.txtAge.TabIndex = 28;
            // 
            // txtBag
            // 
            this.txtBag.Location = new System.Drawing.Point(170, 147);
            this.txtBag.Name = "txtBag";
            this.txtBag.Size = new System.Drawing.Size(121, 23);
            this.txtBag.TabIndex = 27;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cboGender.Location = new System.Drawing.Point(170, 270);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(121, 23);
            this.cboGender.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(25, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 15);
            this.label16.TabIndex = 16;
            this.label16.Text = "Enter your continent";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(25, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Enter your gender";
            // 
            // cboContinent
            // 
            this.cboContinent.FormattingEnabled = true;
            this.cboContinent.Items.AddRange(new object[] {
            "Asia",
            "Africa",
            "America del Sur",
            "America del Norte",
            "Europa",
            "Oceania"});
            this.cboContinent.Location = new System.Drawing.Point(170, 20);
            this.cboContinent.Name = "cboContinent";
            this.cboContinent.Size = new System.Drawing.Size(121, 23);
            this.cboContinent.TabIndex = 18;
            this.cboContinent.SelectedIndexChanged += new System.EventHandler(this.cboContinent_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(25, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 15);
            this.label17.TabIndex = 17;
            this.label17.Text = "Enter your country";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(25, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Enter your age";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(170, 78);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(121, 23);
            this.cboCountry.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(25, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "Enter your travel bag";
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnalyze.Location = new System.Drawing.Point(61, 439);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(210, 44);
            this.btnAnalyze.TabIndex = 20;
            this.btnAnalyze.Text = "Analyze countries suitable for travel";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.gbo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.Text = "Form8";
            this.gbo2.ResumeLayout(false);
            this.gbo2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel gbo2;
        private ComboBox cboGender;
        private Label label16;
        private Label label11;
        private ComboBox cboContinent;
        private Label label17;
        private Label label13;
        private ComboBox cboCountry;
        private Label label15;
        private Button btnAnalyze;
        private TextBox txtAge;
        private TextBox txtBag;
        private ComboBox cboEstudios;
        private RadioButton rbSi;
        private RadioButton rbNo;
        private Label label6;
        private Label label7;
        private Label label1;
        private Button button1;
    }
}
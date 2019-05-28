namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Ceas = new System.Windows.Forms.Label();
            this.Loc = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.Zi = new System.Windows.Forms.Label();
            this.Ziua = new System.Windows.Forms.Label();
            this.Soare = new System.Windows.Forms.PictureBox();
            this.Grade = new System.Windows.Forms.Label();
            this.Prognoza = new System.Windows.Forms.Label();
            this.Procente = new System.Windows.Forms.Label();
            this.Umiditate = new System.Windows.Forms.Label();
            this.Viteza = new System.Windows.Forms.Label();
            this.Vant = new System.Windows.Forms.Label();
            this.Noapte = new System.Windows.Forms.Label();
            this.TemperaturaMaxima = new System.Windows.Forms.Label();
            this.maxima = new System.Windows.Forms.Label();
            this.Temperaturaminima = new System.Windows.Forms.Label();
            this.minima = new System.Windows.Forms.Label();
            this.Graden = new System.Windows.Forms.Label();
            this.Rezumat = new System.Windows.Forms.Label();
            this.speech = new System.Windows.Forms.Label();
            this.raspuns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Soare)).BeginInit();
            this.SuspendLayout();
            // 
            // Ceas
            // 
            this.Ceas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ceas.AutoSize = true;
            this.Ceas.BackColor = System.Drawing.SystemColors.WindowText;
            this.Ceas.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ceas.ForeColor = System.Drawing.SystemColors.Control;
            this.Ceas.Location = new System.Drawing.Point(594, 18);
            this.Ceas.Name = "Ceas";
            this.Ceas.Size = new System.Drawing.Size(212, 56);
            this.Ceas.TabIndex = 1;
            this.Ceas.Text = "00:00:00";
            // 
            // Loc
            // 
            this.Loc.AutoSize = true;
            this.Loc.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loc.Location = new System.Drawing.Point(20, 17);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(193, 44);
            this.Loc.TabIndex = 2;
            this.Loc.Text = "Timișoara";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Data.Location = new System.Drawing.Point(23, 93);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(166, 30);
            this.Data.TabIndex = 3;
            this.Data.Text = "5 Aprilie 2018";
            // 
            // Zi
            // 
            this.Zi.AutoSize = true;
            this.Zi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Zi.Location = new System.Drawing.Point(90, 124);
            this.Zi.Name = "Zi";
            this.Zi.Size = new System.Drawing.Size(40, 21);
            this.Zi.TabIndex = 4;
            this.Zi.Text = "Luni";
            // 
            // Ziua
            // 
            this.Ziua.AutoSize = true;
            this.Ziua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ziua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ziua.Location = new System.Drawing.Point(90, 163);
            this.Ziua.Name = "Ziua";
            this.Ziua.Size = new System.Drawing.Size(42, 21);
            this.Ziua.TabIndex = 5;
            this.Ziua.Text = "Ziua";
            // 
            // Soare
            // 
            this.Soare.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Soare.ErrorImage")));
            this.Soare.Image = ((System.Drawing.Image)(resources.GetObject("Soare.Image")));
            this.Soare.InitialImage = ((System.Drawing.Image)(resources.GetObject("Soare.InitialImage")));
            this.Soare.Location = new System.Drawing.Point(28, 187);
            this.Soare.Margin = new System.Windows.Forms.Padding(0);
            this.Soare.Name = "Soare";
            this.Soare.Size = new System.Drawing.Size(67, 69);
            this.Soare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Soare.TabIndex = 6;
            this.Soare.TabStop = false;
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Grade.Location = new System.Drawing.Point(123, 187);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(66, 39);
            this.Grade.TabIndex = 7;
            this.Grade.Text = "10°";
            // 
            // Prognoza
            // 
            this.Prognoza.AutoSize = true;
            this.Prognoza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prognoza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Prognoza.Location = new System.Drawing.Point(126, 235);
            this.Prognoza.Name = "Prognoza";
            this.Prognoza.Size = new System.Drawing.Size(56, 21);
            this.Prognoza.TabIndex = 8;
            this.Prognoza.Text = "Însorit";
            // 
            // Procente
            // 
            this.Procente.AutoSize = true;
            this.Procente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Procente.Location = new System.Drawing.Point(126, 274);
            this.Procente.Name = "Procente";
            this.Procente.Size = new System.Drawing.Size(40, 21);
            this.Procente.TabIndex = 9;
            this.Procente.Text = "10%";
            // 
            // Umiditate
            // 
            this.Umiditate.AutoSize = true;
            this.Umiditate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Umiditate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Umiditate.Location = new System.Drawing.Point(22, 274);
            this.Umiditate.Name = "Umiditate";
            this.Umiditate.Size = new System.Drawing.Size(88, 21);
            this.Umiditate.TabIndex = 10;
            this.Umiditate.Text = "Umiditate";
            // 
            // Viteza
            // 
            this.Viteza.AutoSize = true;
            this.Viteza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viteza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Viteza.Location = new System.Drawing.Point(126, 295);
            this.Viteza.Name = "Viteza";
            this.Viteza.Size = new System.Drawing.Size(42, 21);
            this.Viteza.TabIndex = 11;
            this.Viteza.Text = "6km";
            // 
            // Vant
            // 
            this.Vant.AutoSize = true;
            this.Vant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Vant.Location = new System.Drawing.Point(22, 295);
            this.Vant.Name = "Vant";
            this.Vant.Size = new System.Drawing.Size(49, 21);
            this.Vant.TabIndex = 12;
            this.Vant.Text = "Vânt";
            // 
            // Noapte
            // 
            this.Noapte.AutoSize = true;
            this.Noapte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noapte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Noapte.Location = new System.Drawing.Point(22, 358);
            this.Noapte.Name = "Noapte";
            this.Noapte.Size = new System.Drawing.Size(82, 21);
            this.Noapte.TabIndex = 15;
            this.Noapte.Text = "Noaptea";
            // 
            // TemperaturaMaxima
            // 
            this.TemperaturaMaxima.AutoSize = true;
            this.TemperaturaMaxima.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperaturaMaxima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TemperaturaMaxima.Location = new System.Drawing.Point(22, 337);
            this.TemperaturaMaxima.Name = "TemperaturaMaxima";
            this.TemperaturaMaxima.Size = new System.Drawing.Size(73, 21);
            this.TemperaturaMaxima.TabIndex = 28;
            this.TemperaturaMaxima.Text = "Maxima";
            // 
            // maxima
            // 
            this.maxima.AutoSize = true;
            this.maxima.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxima.Location = new System.Drawing.Point(128, 337);
            this.maxima.Name = "maxima";
            this.maxima.Size = new System.Drawing.Size(28, 21);
            this.maxima.TabIndex = 27;
            this.maxima.Text = "10";
            // 
            // Temperaturaminima
            // 
            this.Temperaturaminima.AutoSize = true;
            this.Temperaturaminima.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperaturaminima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Temperaturaminima.Location = new System.Drawing.Point(22, 316);
            this.Temperaturaminima.Name = "Temperaturaminima";
            this.Temperaturaminima.Size = new System.Drawing.Size(67, 21);
            this.Temperaturaminima.TabIndex = 26;
            this.Temperaturaminima.Text = "Minima";
            // 
            // minima
            // 
            this.minima.AutoSize = true;
            this.minima.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minima.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minima.Location = new System.Drawing.Point(128, 316);
            this.minima.Name = "minima";
            this.minima.Size = new System.Drawing.Size(28, 21);
            this.minima.TabIndex = 25;
            this.minima.Text = "10";
            // 
            // Graden
            // 
            this.Graden.AutoSize = true;
            this.Graden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graden.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Graden.Location = new System.Drawing.Point(128, 358);
            this.Graden.Name = "Graden";
            this.Graden.Size = new System.Drawing.Size(28, 21);
            this.Graden.TabIndex = 29;
            this.Graden.Text = "10";
            // 
            // Rezumat
            // 
            this.Rezumat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rezumat.AutoSize = true;
            this.Rezumat.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rezumat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rezumat.Location = new System.Drawing.Point(1175, 17);
            this.Rezumat.Name = "Rezumat";
            this.Rezumat.Size = new System.Drawing.Size(188, 44);
            this.Rezumat.TabIndex = 30;
            this.Rezumat.Text = "Calendar";
            // 
            // speech
            // 
            this.speech.AutoSize = true;
            this.speech.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speech.ForeColor = System.Drawing.Color.Snow;
            this.speech.Location = new System.Drawing.Point(20, 405);
            this.speech.Name = "speech";
            this.speech.Size = new System.Drawing.Size(102, 41);
            this.speech.TabIndex = 32;
            this.speech.Text = "label";
            // 
            // raspuns
            // 
            this.raspuns.AutoSize = true;
            this.raspuns.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raspuns.ForeColor = System.Drawing.Color.Snow;
            this.raspuns.Location = new System.Drawing.Point(20, 492);
            this.raspuns.Name = "raspuns";
            this.raspuns.Size = new System.Drawing.Size(71, 28);
            this.raspuns.TabIndex = 33;
            this.raspuns.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1407, 822);
            this.Controls.Add(this.raspuns);
            this.Controls.Add(this.speech);
            this.Controls.Add(this.Rezumat);
            this.Controls.Add(this.Graden);
            this.Controls.Add(this.TemperaturaMaxima);
            this.Controls.Add(this.maxima);
            this.Controls.Add(this.Temperaturaminima);
            this.Controls.Add(this.minima);
            this.Controls.Add(this.Noapte);
            this.Controls.Add(this.Vant);
            this.Controls.Add(this.Viteza);
            this.Controls.Add(this.Umiditate);
            this.Controls.Add(this.Procente);
            this.Controls.Add(this.Prognoza);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.Soare);
            this.Controls.Add(this.Ziua);
            this.Controls.Add(this.Zi);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Loc);
            this.Controls.Add(this.Ceas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Soare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label Ceas;
        private System.Windows.Forms.Label Loc;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.Label Zi;
        private System.Windows.Forms.Label Ziua;
        private System.Windows.Forms.PictureBox Soare;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label Prognoza;
        private System.Windows.Forms.Label Procente;
        private System.Windows.Forms.Label Umiditate;
        private System.Windows.Forms.Label Viteza;
        private System.Windows.Forms.Label Vant;
        private System.Windows.Forms.Label Noapte;
        private System.Windows.Forms.Label TemperaturaMaxima;
        private System.Windows.Forms.Label maxima;
        private System.Windows.Forms.Label Temperaturaminima;
        private System.Windows.Forms.Label minima;
        private System.Windows.Forms.Label Graden;
        private System.Windows.Forms.Label Rezumat;
        private System.Windows.Forms.Label speech;
        private System.Windows.Forms.Label raspuns;
    }
}


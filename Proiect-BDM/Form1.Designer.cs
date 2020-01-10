namespace Proiect_BDM
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
            this.Conexiune = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxDescriere = new System.Windows.Forms.TextBox();
            this.txtBoxNumeFisier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInserareImagine = new System.Windows.Forms.Button();
            this.btnGenerareSemnatura = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tBoxNumeFisier = new System.Windows.Forms.TextBox();
            this.tBoxCuloare = new System.Windows.Forms.TextBox();
            this.tBoxTextura = new System.Windows.Forms.TextBox();
            this.tBoxForma = new System.Windows.Forms.TextBox();
            this.tBoxLocatie = new System.Windows.Forms.TextBox();
            this.txtBoxIdAfisare = new System.Windows.Forms.TextBox();
            this.btnRegasireImagine = new System.Windows.Forms.Button();
            this.btnAfisareImagine = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInserareVideo = new System.Windows.Forms.Button();
            this.btnAfisareVideo = new System.Windows.Forms.Button();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // Conexiune
            // 
            this.Conexiune.Location = new System.Drawing.Point(400, 91);
            this.Conexiune.Margin = new System.Windows.Forms.Padding(2);
            this.Conexiune.Name = "Conexiune";
            this.Conexiune.Size = new System.Drawing.Size(116, 37);
            this.Conexiune.TabIndex = 0;
            this.Conexiune.Text = "Conexiune";
            this.Conexiune.UseVisualStyleBackColor = true;
            this.Conexiune.Click += new System.EventHandler(this.Conexiune_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(455, 11);
            this.txtBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(76, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // txtBoxDescriere
            // 
            this.txtBoxDescriere.Location = new System.Drawing.Point(455, 33);
            this.txtBoxDescriere.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDescriere.Name = "txtBoxDescriere";
            this.txtBoxDescriere.Size = new System.Drawing.Size(76, 20);
            this.txtBoxDescriere.TabIndex = 2;
            // 
            // txtBoxNumeFisier
            // 
            this.txtBoxNumeFisier.Location = new System.Drawing.Point(455, 55);
            this.txtBoxNumeFisier.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNumeFisier.Name = "txtBoxNumeFisier";
            this.txtBoxNumeFisier.Size = new System.Drawing.Size(76, 20);
            this.txtBoxNumeFisier.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nume Fisier";
            // 
            // btnInserareImagine
            // 
            this.btnInserareImagine.Location = new System.Drawing.Point(400, 144);
            this.btnInserareImagine.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserareImagine.Name = "btnInserareImagine";
            this.btnInserareImagine.Size = new System.Drawing.Size(116, 23);
            this.btnInserareImagine.TabIndex = 7;
            this.btnInserareImagine.Text = "Inserare Imagine";
            this.btnInserareImagine.UseVisualStyleBackColor = true;
            this.btnInserareImagine.Click += new System.EventHandler(this.BtnInserareImagine_Click);
            // 
            // btnGenerareSemnatura
            // 
            this.btnGenerareSemnatura.Location = new System.Drawing.Point(400, 210);
            this.btnGenerareSemnatura.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerareSemnatura.Name = "btnGenerareSemnatura";
            this.btnGenerareSemnatura.Size = new System.Drawing.Size(116, 36);
            this.btnGenerareSemnatura.TabIndex = 8;
            this.btnGenerareSemnatura.Text = "Generare Semnatura";
            this.btnGenerareSemnatura.UseVisualStyleBackColor = true;
            this.btnGenerareSemnatura.Click += new System.EventHandler(this.btnGenerareSemnatura_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(400, 264);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 37);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // tBoxNumeFisier
            // 
            this.tBoxNumeFisier.Location = new System.Drawing.Point(140, 248);
            this.tBoxNumeFisier.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxNumeFisier.Name = "tBoxNumeFisier";
            this.tBoxNumeFisier.Size = new System.Drawing.Size(76, 20);
            this.tBoxNumeFisier.TabIndex = 10;
            // 
            // tBoxCuloare
            // 
            this.tBoxCuloare.Location = new System.Drawing.Point(140, 270);
            this.tBoxCuloare.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxCuloare.Name = "tBoxCuloare";
            this.tBoxCuloare.Size = new System.Drawing.Size(76, 20);
            this.tBoxCuloare.TabIndex = 11;
            // 
            // tBoxTextura
            // 
            this.tBoxTextura.Location = new System.Drawing.Point(141, 293);
            this.tBoxTextura.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxTextura.Name = "tBoxTextura";
            this.tBoxTextura.Size = new System.Drawing.Size(76, 20);
            this.tBoxTextura.TabIndex = 12;
            // 
            // tBoxForma
            // 
            this.tBoxForma.Location = new System.Drawing.Point(141, 317);
            this.tBoxForma.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxForma.Name = "tBoxForma";
            this.tBoxForma.Size = new System.Drawing.Size(76, 20);
            this.tBoxForma.TabIndex = 13;
            // 
            // tBoxLocatie
            // 
            this.tBoxLocatie.Location = new System.Drawing.Point(141, 341);
            this.tBoxLocatie.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxLocatie.Name = "tBoxLocatie";
            this.tBoxLocatie.Size = new System.Drawing.Size(76, 20);
            this.tBoxLocatie.TabIndex = 14;
            // 
            // txtBoxIdAfisare
            // 
            this.txtBoxIdAfisare.Location = new System.Drawing.Point(140, 226);
            this.txtBoxIdAfisare.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxIdAfisare.Name = "txtBoxIdAfisare";
            this.txtBoxIdAfisare.Size = new System.Drawing.Size(76, 20);
            this.txtBoxIdAfisare.TabIndex = 15;
            // 
            // btnRegasireImagine
            // 
            this.btnRegasireImagine.Location = new System.Drawing.Point(237, 273);
            this.btnRegasireImagine.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegasireImagine.Name = "btnRegasireImagine";
            this.btnRegasireImagine.Size = new System.Drawing.Size(104, 36);
            this.btnRegasireImagine.TabIndex = 16;
            this.btnRegasireImagine.Text = "Regasire";
            this.btnRegasireImagine.UseVisualStyleBackColor = true;
            this.btnRegasireImagine.Click += new System.EventHandler(this.btnRegasireImagine_Click);
            // 
            // btnAfisareImagine
            // 
            this.btnAfisareImagine.Location = new System.Drawing.Point(400, 171);
            this.btnAfisareImagine.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfisareImagine.Name = "btnAfisareImagine";
            this.btnAfisareImagine.Size = new System.Drawing.Size(116, 25);
            this.btnAfisareImagine.TabIndex = 17;
            this.btnAfisareImagine.Text = "Afisare Imagine";
            this.btnAfisareImagine.UseVisualStyleBackColor = true;
            this.btnAfisareImagine.Click += new System.EventHandler(this.BtnAfisareImagine_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Id Imagine Afisare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nume Fisier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 275);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Coef. Culoare";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Coef. Textura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Coef. Forma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 348);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Coef. Locatie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 204);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnInserareVideo
            // 
            this.btnInserareVideo.Location = new System.Drawing.Point(520, 144);
            this.btnInserareVideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInserareVideo.Name = "btnInserareVideo";
            this.btnInserareVideo.Size = new System.Drawing.Size(104, 22);
            this.btnInserareVideo.TabIndex = 25;
            this.btnInserareVideo.Text = "Inserare Video";
            this.btnInserareVideo.UseVisualStyleBackColor = true;
            // 
            // btnAfisareVideo
            // 
            this.btnAfisareVideo.Location = new System.Drawing.Point(520, 171);
            this.btnAfisareVideo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAfisareVideo.Name = "btnAfisareVideo";
            this.btnAfisareVideo.Size = new System.Drawing.Size(104, 25);
            this.btnAfisareVideo.TabIndex = 26;
            this.btnAfisareVideo.Text = "Afisare Video";
            this.btnAfisareVideo.UseVisualStyleBackColor = true;
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(551, 554);
            this.wmp.Margin = new System.Windows.Forms.Padding(2);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(75, 23);
            this.wmp.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(369, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "1.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(369, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "2.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(370, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 23);
            this.label12.TabIndex = 30;
            this.label12.Text = "3.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(370, 278);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 23);
            this.label13.TabIndex = 31;
            this.label13.Text = "4.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 372);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.btnAfisareVideo);
            this.Controls.Add(this.btnInserareVideo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAfisareImagine);
            this.Controls.Add(this.btnRegasireImagine);
            this.Controls.Add(this.txtBoxIdAfisare);
            this.Controls.Add(this.tBoxLocatie);
            this.Controls.Add(this.tBoxForma);
            this.Controls.Add(this.tBoxTextura);
            this.Controls.Add(this.tBoxCuloare);
            this.Controls.Add(this.tBoxNumeFisier);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnGenerareSemnatura);
            this.Controls.Add(this.btnInserareImagine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxNumeFisier);
            this.Controls.Add(this.txtBoxDescriere);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.Conexiune);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Conexiune;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxDescriere;
        private System.Windows.Forms.TextBox txtBoxNumeFisier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInserareImagine;
        private System.Windows.Forms.Button btnGenerareSemnatura;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox tBoxNumeFisier;
        private System.Windows.Forms.TextBox tBoxCuloare;
        private System.Windows.Forms.TextBox tBoxTextura;
        private System.Windows.Forms.TextBox tBoxForma;
        private System.Windows.Forms.TextBox tBoxLocatie;
        private System.Windows.Forms.TextBox txtBoxIdAfisare;
        private System.Windows.Forms.Button btnRegasireImagine;
        private System.Windows.Forms.Button btnAfisareImagine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInserareVideo;
        private System.Windows.Forms.Button btnAfisareVideo;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}


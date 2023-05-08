
namespace Gestor_Articulos
{
    partial class NuevaImgArt
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
            this.txtImagen1 = new System.Windows.Forms.TextBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnCargarArt = new System.Windows.Forms.Button();
            this.PBoxImgArt1 = new System.Windows.Forms.PictureBox();
            this.LblImg = new System.Windows.Forms.Label();
            this.GBImg = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt1)).BeginInit();
            this.GBImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImagen1
            // 
            this.txtImagen1.Location = new System.Drawing.Point(84, 27);
            this.txtImagen1.Name = "txtImagen1";
            this.txtImagen1.Size = new System.Drawing.Size(188, 20);
            this.txtImagen1.TabIndex = 0;
            this.txtImagen1.TextChanged += new System.EventHandler(this.txtImagen1_TextChanged);
            this.txtImagen1.Leave += new System.EventHandler(this.txtImagen1_Leave);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(20, 30);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(58, 13);
            this.lblImagen.TabIndex = 21;
            this.lblImagen.Text = "Url Imagen";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnCargarArt
            // 
            this.BtnCargarArt.Location = new System.Drawing.Point(11, 199);
            this.BtnCargarArt.Name = "BtnCargarArt";
            this.BtnCargarArt.Size = new System.Drawing.Size(125, 23);
            this.BtnCargarArt.TabIndex = 1;
            this.BtnCargarArt.Text = "Cargar imagen";
            this.BtnCargarArt.UseVisualStyleBackColor = true;
            this.BtnCargarArt.Click += new System.EventHandler(this.BtnCargarArt_Click);
            // 
            // PBoxImgArt1
            // 
            this.PBoxImgArt1.Location = new System.Drawing.Point(17, 57);
            this.PBoxImgArt1.Name = "PBoxImgArt1";
            this.PBoxImgArt1.Size = new System.Drawing.Size(255, 59);
            this.PBoxImgArt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImgArt1.TabIndex = 23;
            this.PBoxImgArt1.TabStop = false;
            // 
            // LblImg
            // 
            this.LblImg.AutoSize = true;
            this.LblImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImg.Location = new System.Drawing.Point(119, 36);
            this.LblImg.Name = "LblImg";
            this.LblImg.Size = new System.Drawing.Size(59, 16);
            this.LblImg.TabIndex = 29;
            this.LblImg.Text = "Imagen";
            // 
            // GBImg
            // 
            this.GBImg.Controls.Add(this.PBoxImgArt1);
            this.GBImg.Controls.Add(this.lblImagen);
            this.GBImg.Controls.Add(this.txtImagen1);
            this.GBImg.Location = new System.Drawing.Point(19, 55);
            this.GBImg.Name = "GBImg";
            this.GBImg.Size = new System.Drawing.Size(286, 129);
            this.GBImg.TabIndex = 10043;
            this.GBImg.TabStop = false;
            // 
            // NuevaImgArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(333, 283);
            this.Controls.Add(this.LblImg);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnCargarArt);
            this.Controls.Add(this.GBImg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaImgArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaImgArt";
            this.Load += new System.EventHandler(this.NuevaImgArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt1)).EndInit();
            this.GBImg.ResumeLayout(false);
            this.GBImg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxImgArt1;
        private System.Windows.Forms.TextBox txtImagen1;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnCargarArt;
        private System.Windows.Forms.Label LblImg;
        private System.Windows.Forms.GroupBox GBImg;
    }
}
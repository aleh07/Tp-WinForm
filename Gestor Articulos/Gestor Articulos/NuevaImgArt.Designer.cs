
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
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImagen1
            // 
            this.txtImagen1.Location = new System.Drawing.Point(173, 193);
            this.txtImagen1.Name = "txtImagen1";
            this.txtImagen1.Size = new System.Drawing.Size(100, 20);
            this.txtImagen1.TabIndex = 22;
            this.txtImagen1.TextChanged += new System.EventHandler(this.txtImagen1_TextChanged);
            this.txtImagen1.Leave += new System.EventHandler(this.txtImagen1_Leave);
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(113, 196);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(58, 13);
            this.lblImagen.TabIndex = 21;
            this.lblImagen.Text = "Url Imagen";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(530, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnCargarArt
            // 
            this.BtnCargarArt.Location = new System.Drawing.Point(530, 174);
            this.BtnCargarArt.Name = "BtnCargarArt";
            this.BtnCargarArt.Size = new System.Drawing.Size(125, 23);
            this.BtnCargarArt.TabIndex = 19;
            this.BtnCargarArt.Text = "Cargar imagen";
            this.BtnCargarArt.UseVisualStyleBackColor = true;
            this.BtnCargarArt.Click += new System.EventHandler(this.BtnCargarArt_Click);
            // 
            // PBoxImgArt1
            // 
            this.PBoxImgArt1.Location = new System.Drawing.Point(310, 174);
            this.PBoxImgArt1.Name = "PBoxImgArt1";
            this.PBoxImgArt1.Size = new System.Drawing.Size(107, 59);
            this.PBoxImgArt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBoxImgArt1.TabIndex = 23;
            this.PBoxImgArt1.TabStop = false;
            // 
            // NuevaImgArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PBoxImgArt1);
            this.Controls.Add(this.txtImagen1);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnCargarArt);
            this.Name = "NuevaImgArt";
            this.Text = "NuevaImgArt";
            this.Load += new System.EventHandler(this.NuevaImgArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBoxImgArt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBoxImgArt1;
        private System.Windows.Forms.TextBox txtImagen1;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnCargarArt;
    }
}
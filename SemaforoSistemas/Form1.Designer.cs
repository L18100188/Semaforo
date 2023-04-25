
namespace SemaforoSistemas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcbIzquierdaH = new System.Windows.Forms.PictureBox();
            this.pcbDerechaV = new System.Windows.Forms.PictureBox();
            this.pcbIzquierdaV = new System.Windows.Forms.PictureBox();
            this.pcbDerechaH = new System.Windows.Forms.PictureBox();
            this.pnlMenuControl = new System.Windows.Forms.Panel();
            this.lblDisplayVerde = new System.Windows.Forms.Label();
            this.lblDisplayAmarillo = new System.Windows.Forms.Label();
            this.lblDisplayRojo = new System.Windows.Forms.Label();
            this.lblEtiquetaRoja = new System.Windows.Forms.Label();
            this.lblEtiquetaAmarilla = new System.Windows.Forms.Label();
            this.lblEtiquetaVerde = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnAmarilla = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            this.tmrPreventivas = new System.Windows.Forms.Timer(this.components);
            this.tmrCambioSemaforos = new System.Windows.Forms.Timer(this.components);
            this.tmrCambioDisplays = new System.Windows.Forms.Timer(this.components);
            this.btnDetener = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIzquierdaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDerechaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIzquierdaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDerechaH)).BeginInit();
            this.pnlMenuControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbIzquierdaH
            // 
            this.pcbIzquierdaH.BackColor = System.Drawing.Color.Transparent;
            this.pcbIzquierdaH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIzquierdaH.Image = global::SemaforoSistemas.Properties.Resources.SMHRightOf1;
            this.pcbIzquierdaH.Location = new System.Drawing.Point(254, 116);
            this.pcbIzquierdaH.Name = "pcbIzquierdaH";
            this.pcbIzquierdaH.Size = new System.Drawing.Size(121, 75);
            this.pcbIzquierdaH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIzquierdaH.TabIndex = 0;
            this.pcbIzquierdaH.TabStop = false;
            // 
            // pcbDerechaV
            // 
            this.pcbDerechaV.BackColor = System.Drawing.Color.Transparent;
            this.pcbDerechaV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbDerechaV.Image = global::SemaforoSistemas.Properties.Resources.SMVLeftOf;
            this.pcbDerechaV.Location = new System.Drawing.Point(722, 70);
            this.pcbDerechaV.Name = "pcbDerechaV";
            this.pcbDerechaV.Size = new System.Drawing.Size(72, 112);
            this.pcbDerechaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDerechaV.TabIndex = 1;
            this.pcbDerechaV.TabStop = false;
            // 
            // pcbIzquierdaV
            // 
            this.pcbIzquierdaV.BackColor = System.Drawing.Color.Transparent;
            this.pcbIzquierdaV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIzquierdaV.Image = global::SemaforoSistemas.Properties.Resources.SMVRighOft;
            this.pcbIzquierdaV.Location = new System.Drawing.Point(291, 439);
            this.pcbIzquierdaV.Name = "pcbIzquierdaV";
            this.pcbIzquierdaV.Size = new System.Drawing.Size(84, 125);
            this.pcbIzquierdaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIzquierdaV.TabIndex = 2;
            this.pcbIzquierdaV.TabStop = false;
            // 
            // pcbDerechaH
            // 
            this.pcbDerechaH.BackColor = System.Drawing.Color.Transparent;
            this.pcbDerechaH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbDerechaH.Image = global::SemaforoSistemas.Properties.Resources.SMHLeftOf1;
            this.pcbDerechaH.Location = new System.Drawing.Point(722, 428);
            this.pcbDerechaH.Name = "pcbDerechaH";
            this.pcbDerechaH.Size = new System.Drawing.Size(134, 73);
            this.pcbDerechaH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDerechaH.TabIndex = 3;
            this.pcbDerechaH.TabStop = false;
            // 
            // pnlMenuControl
            // 
            this.pnlMenuControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenuControl.Controls.Add(this.lblDisplayVerde);
            this.pnlMenuControl.Controls.Add(this.lblDisplayAmarillo);
            this.pnlMenuControl.Controls.Add(this.lblDisplayRojo);
            this.pnlMenuControl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenuControl.Location = new System.Drawing.Point(394, 259);
            this.pnlMenuControl.Name = "pnlMenuControl";
            this.pnlMenuControl.Size = new System.Drawing.Size(320, 147);
            this.pnlMenuControl.TabIndex = 4;
            // 
            // lblDisplayVerde
            // 
            this.lblDisplayVerde.AutoSize = true;
            this.lblDisplayVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayVerde.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayVerde.Location = new System.Drawing.Point(213, 19);
            this.lblDisplayVerde.Name = "lblDisplayVerde";
            this.lblDisplayVerde.Size = new System.Drawing.Size(98, 108);
            this.lblDisplayVerde.TabIndex = 5;
            this.lblDisplayVerde.Text = "0";
            this.lblDisplayVerde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayAmarillo
            // 
            this.lblDisplayAmarillo.AutoSize = true;
            this.lblDisplayAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAmarillo.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayAmarillo.Location = new System.Drawing.Point(113, 19);
            this.lblDisplayAmarillo.Name = "lblDisplayAmarillo";
            this.lblDisplayAmarillo.Size = new System.Drawing.Size(98, 108);
            this.lblDisplayAmarillo.TabIndex = 5;
            this.lblDisplayAmarillo.Text = "0";
            // 
            // lblDisplayRojo
            // 
            this.lblDisplayRojo.AutoSize = true;
            this.lblDisplayRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayRojo.ForeColor = System.Drawing.Color.Black;
            this.lblDisplayRojo.Location = new System.Drawing.Point(18, 19);
            this.lblDisplayRojo.Name = "lblDisplayRojo";
            this.lblDisplayRojo.Size = new System.Drawing.Size(98, 108);
            this.lblDisplayRojo.TabIndex = 0;
            this.lblDisplayRojo.Text = "0";
            // 
            // lblEtiquetaRoja
            // 
            this.lblEtiquetaRoja.AutoSize = true;
            this.lblEtiquetaRoja.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaRoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaRoja.ForeColor = System.Drawing.Color.Red;
            this.lblEtiquetaRoja.Location = new System.Drawing.Point(426, 236);
            this.lblEtiquetaRoja.Name = "lblEtiquetaRoja";
            this.lblEtiquetaRoja.Size = new System.Drawing.Size(0, 20);
            this.lblEtiquetaRoja.TabIndex = 5;
            // 
            // lblEtiquetaAmarilla
            // 
            this.lblEtiquetaAmarilla.AutoSize = true;
            this.lblEtiquetaAmarilla.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaAmarilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaAmarilla.ForeColor = System.Drawing.Color.Yellow;
            this.lblEtiquetaAmarilla.Location = new System.Drawing.Point(521, 236);
            this.lblEtiquetaAmarilla.Name = "lblEtiquetaAmarilla";
            this.lblEtiquetaAmarilla.Size = new System.Drawing.Size(0, 20);
            this.lblEtiquetaAmarilla.TabIndex = 6;
            // 
            // lblEtiquetaVerde
            // 
            this.lblEtiquetaVerde.AutoSize = true;
            this.lblEtiquetaVerde.BackColor = System.Drawing.Color.Transparent;
            this.lblEtiquetaVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaVerde.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblEtiquetaVerde.Location = new System.Drawing.Point(627, 236);
            this.lblEtiquetaVerde.Name = "lblEtiquetaVerde";
            this.lblEtiquetaVerde.Size = new System.Drawing.Size(0, 20);
            this.lblEtiquetaVerde.TabIndex = 7;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(919, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 32);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnAmarilla
            // 
            this.btnAmarilla.Location = new System.Drawing.Point(860, 50);
            this.btnAmarilla.Name = "btnAmarilla";
            this.btnAmarilla.Size = new System.Drawing.Size(134, 32);
            this.btnAmarilla.TabIndex = 9;
            this.btnAmarilla.Text = "Amarillas Preventivas";
            this.btnAmarilla.UseVisualStyleBackColor = true;
            this.btnAmarilla.Click += new System.EventHandler(this.btnAmarilla_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(919, 126);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tmrDisplay
            // 
            this.tmrDisplay.Interval = 1000;
            this.tmrDisplay.Tick += new System.EventHandler(this.tmrDisplay_Tick);
            // 
            // tmrPreventivas
            // 
            this.tmrPreventivas.Interval = 500;
            this.tmrPreventivas.Tick += new System.EventHandler(this.tmrPreventivas_Tick);
            // 
            // tmrCambioSemaforos
            // 
            this.tmrCambioSemaforos.Interval = 1;
            this.tmrCambioSemaforos.Tick += new System.EventHandler(this.tmrCambioSemaforos_Tick);
            // 
            // tmrCambioDisplays
            // 
            this.tmrCambioDisplays.Interval = 500;
            this.tmrCambioDisplays.Tick += new System.EventHandler(this.tmrCambioDisplays_Tick);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(919, 88);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 32);
            this.btnDetener.TabIndex = 11;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SemaforoSistemas.Properties.Resources.Calle;
            this.ClientSize = new System.Drawing.Size(1006, 590);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAmarilla);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblEtiquetaVerde);
            this.Controls.Add(this.lblEtiquetaAmarilla);
            this.Controls.Add(this.lblEtiquetaRoja);
            this.Controls.Add(this.pnlMenuControl);
            this.Controls.Add(this.pcbDerechaH);
            this.Controls.Add(this.pcbIzquierdaV);
            this.Controls.Add(this.pcbDerechaV);
            this.Controls.Add(this.pcbIzquierdaH);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbIzquierdaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDerechaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIzquierdaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDerechaH)).EndInit();
            this.pnlMenuControl.ResumeLayout(false);
            this.pnlMenuControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbIzquierdaH;
        private System.Windows.Forms.PictureBox pcbDerechaV;
        private System.Windows.Forms.PictureBox pcbIzquierdaV;
        private System.Windows.Forms.PictureBox pcbDerechaH;
        private System.Windows.Forms.Panel pnlMenuControl;
        private System.Windows.Forms.Label lblDisplayVerde;
        private System.Windows.Forms.Label lblDisplayAmarillo;
        private System.Windows.Forms.Label lblDisplayRojo;
        private System.Windows.Forms.Label lblEtiquetaRoja;
        private System.Windows.Forms.Label lblEtiquetaAmarilla;
        private System.Windows.Forms.Label lblEtiquetaVerde;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnAmarilla;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Timer tmrDisplay;
        private System.Windows.Forms.Timer tmrPreventivas;
        private System.Windows.Forms.Timer tmrCambioSemaforos;
        private System.Windows.Forms.Timer tmrCambioDisplays;
        private System.Windows.Forms.Button btnDetener;
    }
}


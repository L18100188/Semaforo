using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaforoSistemas
{
    public partial class Form1 : Form
    {
        //DLL NECESARIO PARA FONT DIGIT
        [DllImport("gdi32.dll")]

        //FUNCION DEL DLL ANTERIOR
        private static extern IntPtr AddFontMemResourceEx(IntPtr pFileView, uint cjSize, IntPtr pvResrved, [In] ref uint pNumFonts);

        //METODO PARA CARGAR LA FUENTE AL PROGRAMA
        private FontFamily CargarFuente(byte[] fuente)
        {
            FontFamily fuenteNueva;

            //Asignar memoria y copiar bytes
            IntPtr data = Marshal.AllocCoTaskMem(fuente.Length);
            Marshal.Copy(fuente, 0, data, fuente.Length);

            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fuente.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection fontCollection = new PrivateFontCollection();

            //Pasar fuente a PrivateFontCollection
            fontCollection.AddMemoryFont(data, fuente.Length);

            //Liberar memoria
            Marshal.FreeCoTaskMem(data);

            fuenteNueva = fontCollection.Families[0];

            return fuenteNueva;
        }

        int caso = 1, contadorApagado = 0, casoConteoDisplay = 0, contarTiempo = 0;
        int segundosRojo = 0, segundosAmarillo = 0, segundosVerde = 0, segundosVerdePrp = 0;
        bool cicloVertical = true;

        // Conteo para los displays
        private void tmrDisplay_Tick(object sender, EventArgs e)
        {
            tmrDisplay.Interval = 1000;
            switch (casoConteoDisplay)
            {
                case 1:
                    lblDisplayVerde.Text = contarTiempo.ToString();
                    lblDisplayVerde.ForeColor = Color.Green; 
                    if (contarTiempo == (segundosVerde / 1000) + 1)
                    {
                        casoConteoDisplay = 2; contarTiempo = 1;
                        lblDisplayVerde.Text = contarTiempo.ToString();
                        contarTiempo++;
                    }
                    else { contarTiempo++; }
                    break;
                case 2:

                    lblDisplayVerde.Text = contarTiempo.ToString();
                    lblDisplayVerde.ForeColor = Color.Green;
                    if (contarTiempo == (segundosVerdePrp / 1000) + 1)
                    {
                        casoConteoDisplay = 3;
                        contarTiempo = 1;
                        lblDisplayVerde.Text = "0";
                        lblDisplayVerde.ForeColor = Color.Black;
                        lblDisplayAmarillo.ForeColor = Color.FromArgb(241, 236, 37);
                        lblDisplayAmarillo.Text = contarTiempo.ToString();
                        contarTiempo++;
                    }
                    else { contarTiempo++; }
                    break;
                case 3:

                    lblDisplayAmarillo.Text = contarTiempo.ToString();
                    if (contarTiempo == (segundosAmarillo / 1000) + 1)
                    {
                        casoConteoDisplay = 4; contarTiempo = 1;
                        lblDisplayAmarillo.Text = "0";
                        lblDisplayAmarillo.ForeColor = Color.Black;
                        lblDisplayRojo.ForeColor = Color.FromArgb(136, 5, 6);
                        lblDisplayRojo.Text = contarTiempo.ToString();
                        contarTiempo++;
                    }
                    else { contarTiempo++; }
                    break;
                case 4:
                    lblDisplayRojo.Text = contarTiempo.ToString();
                    if (contarTiempo == (segundosRojo / 1000) + 1)
                    {
                        casoConteoDisplay = 1; contarTiempo = 1; lblDisplayRojo.Text = "0"; ApagarDisplays();
                        tmrDisplay.Interval = 1;
                    }
                    else { contarTiempo++; }
                    break;
            }

        }

        //Metodo para cambiar las imagenes

        //Semaforos Verticales

        public void enciendeVerdeV()
        {

            pcbDerechaV.Image = Properties.Resources.SMVLeftVe;
            pcbIzquierdaV.Image = Properties.Resources.SMVRightVe;
        }
        public void enciendeAmarilloV()
        {
            pcbDerechaV.Image = Properties.Resources.SMVLeftAm;
            pcbIzquierdaV.Image = Properties.Resources.SMVRightAm;
        }
        public void enciendeRojoV()
        {
            pcbDerechaV.Image = Properties.Resources.SMVLeftRo;
            pcbIzquierdaV.Image = Properties.Resources.SMVRightRo;
        }
        public void apagaTodosV()
        {
            pcbDerechaV.Image = Properties.Resources.SMVLeftOf;
            pcbIzquierdaV.Image = Properties.Resources.SMVRighOft;
        }
        void enciendeTodosAmarillos()
        {
            pcbDerechaH.Image = Properties.Resources.SMHLeftAm1;
            pcbIzquierdaH.Image = Properties.Resources.SMHRightAm1;
            System.Threading.Thread.Sleep(200);
            pcbDerechaV.Image = Properties.Resources.SMVLeftAm;
            pcbIzquierdaV.Image = Properties.Resources.SMVRightAm;
            System.Threading.Thread.Sleep(200);
        }
        void apagaTodos()
        {
            pcbDerechaH.Image = Properties.Resources.SMHLeftOf1;
            pcbIzquierdaH.Image = Properties.Resources.SMHRightOf1;
            System.Threading.Thread.Sleep(200);
            pcbDerechaV.Image = Properties.Resources.SMVLeftOf;
            pcbIzquierdaV.Image = Properties.Resources.SMVRighOft;
            System.Threading.Thread.Sleep(200);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            segundosVerde = 17000; //ms
            segundosVerdePrp = 3000;
            segundosAmarillo = 3000;
            segundosRojo = 2000;
            IniciarSimulacion();
        }

        public void IniciarSimulacion()
        {
            casoConteoDisplay++;
            contarTiempo = 1;
            tmrCambioSemaforos.Start();
            tmrCambioDisplays.Start();
            tmrDisplay.Start();
            tmrDisplay.Interval = 1;
            btnDetener.Enabled = true;
            btnIniciar.Enabled = false;
        }


        //  Semaforos horizontales
        public void enciendeVerdeH()
        {
            pcbDerechaH.Image = Properties.Resources.SMHLeftVe1;
            pcbIzquierdaH.Image = Properties.Resources.SMHRightVe2;
        }
        public void enciendeAmarilloH()
        {
            pcbDerechaH.Image = Properties.Resources.SMHLeftAm1;
            pcbIzquierdaH.Image = Properties.Resources.SMHRightAm1;
        }
        public void enciendeRojoH()
        {
            pcbDerechaH.Image = Properties.Resources.SMHLeftRo1;
            pcbIzquierdaH.Image = Properties.Resources.SMHRightRo1;
        }
        public void apagaTodosH()
        {
            pcbDerechaH.Image = Properties.Resources.SMHLeftOf1;
            pcbIzquierdaH.Image = Properties.Resources.SMHRightOf1;
        }

        private void tmrCambioDisplays_Tick(object sender, EventArgs e)
        {
            switch (casoConteoDisplay)
            {
                case 1:
                    if (contarTiempo == (segundosVerde / 1000) + 1)
                    {
                        lblDisplayVerde.Text = " "; lblDisplayVerde.ForeColor = Color.Black;
                    }
                    break;
                case 2:
                    lblDisplayVerde.Text = " "; lblDisplayVerde.ForeColor = Color.Black;
                    if (contarTiempo == (segundosVerdePrp / 1000) + 1)
                    {
                        lblDisplayVerde.Text = " "; lblDisplayVerde.ForeColor = Color.Black;

                    }
                    break;
                case 3:
                    if (contarTiempo == (segundosAmarillo / 1000) + 1)
                    {
                        lblDisplayAmarillo.Text = " ";
                        lblDisplayAmarillo.ForeColor = Color.Black;
                    }
                    break;
            }
        }

        private void btnAmarilla_Click(object sender, EventArgs e)
        {
            tmrPreventivas.Start();
            btnDetener.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            Detener();
        }

        bool bolPreventivasPrendida = false;

        private void tmrPreventivas_Tick(object sender, EventArgs e)
        {
            if (bolPreventivasPrendida)
            {
                apagaTodos();
                ApagarDisplays();
                lblDisplayAmarillo.Text = " ";
                bolPreventivasPrendida = false;
            }
            else
            {
                enciendeTodosAmarillos();
                lblDisplayAmarillo.ForeColor = Color.FromArgb(241, 236, 37);
                lblDisplayAmarillo.Text = "0";
                bolPreventivasPrendida = true;
            }
        }

        //Timer para el control de cambio de color en los semáforos
        private void tmrCambioSemaforos_Tick(object sender, EventArgs e)
        {
            switch (caso)
            {
                case 1:                                                                     // CASO 1 - enciende en VERDE
                    if (cicloVertical)
                    {
                        enciendeVerdeV();
                        enciendeRojoH();
                    }
                    else
                    {
                        enciendeVerdeH();
                        enciendeRojoV();
                    }
                    tmrCambioSemaforos.Interval = (segundosVerde - 500); caso = 2; break;
                case 2:                                                                     // CASO 2 - apaga todos los semaforos verticales
                    if (cicloVertical)
                    {
                        apagaTodosV();
                    }
                    else
                    {
                        apagaTodosH();
                    };
                    tmrCambioSemaforos.Interval = 500;
                    if (contadorApagado == segundosVerdePrp / 1000)
                    {//  PARPADEO del semáforo (apagado)
                        tmrCambioSemaforos.Interval = 500; caso = 4; contadorApagado = 0;
                    }
                    else
                    {
                        caso = 3;
                    }
                    break;
                case 3:
                    if (cicloVertical)
                    {
                        enciendeVerdeV();
                    }
                    else
                    {
                        enciendeVerdeH();
                    }
                    tmrCambioSemaforos.Interval = 500; contadorApagado++; caso = 2;        //PARPADEO del semáforo (encendido) regresando al caso 2

                    break;
                case 4:                                                                     //CASO 3 - enciende en AMARILLO
                    if (cicloVertical)
                    {
                        enciendeAmarilloV();
                    }
                    else
                    {
                        enciendeAmarilloH();
                    }
                    tmrCambioSemaforos.Interval = (segundosAmarillo - 500); caso = 5; break;
                case 5:                                                                      //CASO 3 - apaga el AMARILLO
                    if (cicloVertical)
                    {
                        apagaTodosV();
                    }
                    else
                    {
                        apagaTodosH();
                    }
                    tmrCambioSemaforos.Interval = 500; caso = 6; break;
                case 6:                                                                     //CASO 4 - enciende en ROJO
                    if (cicloVertical)
                    {
                        enciendeRojoV();
                    }
                    else
                    {
                        enciendeRojoH();
                    }
                    tmrCambioSemaforos.Interval = (segundosRojo - 500); caso = 7; break;
                case 7:
                    if (cicloVertical)
                    {
                        cicloVertical = false;
                        apagaTodosH();

                    }
                    else
                    {
                        cicloVertical = true;
                        apagaTodosV();
                    }
                    //------------------------------------------
                    //PARA SINCRONIZAR DE MANERA CORRECTA TODO DEBEMOS REINCIAR LOS TIMERS Y LAS VARIABLES AUXILIARES
                    caso = 1;
                    tmrCambioSemaforos.Interval = 500;
                    tmrDisplay.Interval = 500;
                    tmrCambioDisplays.Interval = 500;


                    tmrDisplay.Stop();
                    tmrCambioSemaforos.Stop();
                    tmrCambioDisplays.Stop();


                    casoConteoDisplay = 1; contarTiempo = 1; lblDisplayRojo.Text = "0"; ApagarDisplays();



                    tmrDisplay.Start();
                    tmrCambioSemaforos.Start();
                    tmrCambioDisplays.Start();
                    //----------------------------------------------
                    break;
            }
        }

     

        public Form1()
        {
            InitializeComponent();
            Font fuente_DS_DIGIT = new Font(CargarFuente(Properties.Resources.DS_DIGIT), 70, FontStyle.Regular);
            Font fuente_DS_DIGI = new Font(CargarFuente(Properties.Resources.DS_DIGI), 27, FontStyle.Regular);
              

            lblDisplayVerde.Font = fuente_DS_DIGIT;
            lblDisplayAmarillo.Font = fuente_DS_DIGIT;
            lblDisplayRojo.Font = fuente_DS_DIGIT;
        }

        public void ApagarDisplays()
        {
            lblDisplayVerde.Text = "0"; lblDisplayVerde.ForeColor = Color.Black;
            lblDisplayAmarillo.Text = "0"; lblDisplayAmarillo.ForeColor = Color.Black;
            lblDisplayRojo.Text = "0"; lblDisplayRojo.ForeColor = Color.Black;
        }

        public void Detener()
        {
            tmrCambioSemaforos.Stop(); tmrDisplay.Stop(); tmrDisplay.Start(); tmrCambioDisplays.Stop();
            apagaTodosV(); apagaTodosH();
            ApagarDisplays();
            tmrPreventivas.Stop();
            tmrCambioSemaforos.Interval = 10;
            caso = 1;                               // Control para el semáforo
            contadorApagado = 0;                    //Contador para el display en los parpadeos del semáforo
            cicloVertical = true;                   // Comienza con los semáforos verticales
            btnIniciar.Enabled = true;
            btnDetener.Enabled = false;
            casoConteoDisplay = 0;
            contarTiempo = 1;
            segundosRojo = 0; segundosAmarillo = 0; segundosVerde = 0; segundosVerdePrp = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

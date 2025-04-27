using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculosGeometricos;
using FigurasGeometricas;

namespace App_Areas_Volumenes
{
    public partial class FiguraGeometricas: Form
    {
        static int seleccionFigura;

        public FiguraGeometricas()
        {
            InitializeComponent();
        }

        private void CentrarPanel(GroupBox groupBox)
        {
            groupBox.Left = (this.ClientSize.Width - groupBox.Width) / 2;
            groupBox.Top = (this.ClientSize.Height - groupBox.Height) / 2;
        }

        private void Mensaje(string texto)
        {
            this.lblMensaje.Text = texto;
        }
        private void LimpiarRespuesta()
        {
            this.lblRtaArea.Text = string.Empty;
            this.lblRtaVolumen.Text = string.Empty;
        }

        private void LimpiarDatos()
        {
            this.txtRadioEsfera.Text = string.Empty;
            this.txtRadioCilindro.Text = string.Empty;
            this.txtAlturaCilindro.Text = string.Empty;
            this.txtLadoA.Text = string.Empty;
            this.txtLadoB.Text = string.Empty;
            this.txtLadoC.Text = string.Empty;
        }

        private void FiguraGeometricas_Load(object sender, EventArgs e)
        {
            this.cbFiguras.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarDatos();
            LimpiarRespuesta();
            Mensaje(string.Empty);
            this.groupEsfera.Visible = false;
            this.groupCilindro.Visible = false;
            this.groupParale.Visible = false;

            seleccionFigura = this.cbFiguras.SelectedIndex + 1;

            switch (seleccionFigura)
            {
                case 1:
                    Image myImage = Properties.Resources.Esfera;
                    this.imgFigura.Image = myImage;
                    this.groupEsfera.Visible = true;
                    CentrarPanel(groupEsfera);
                    this.txtRadioEsfera.Focus();
                    break;
                case 2:
                    Image myImage2 = Properties.Resources.Cilindro;
                    this.imgFigura.Image = myImage2;
                    this.groupCilindro.Visible = true;
                    CentrarPanel(groupCilindro);
                    this.txtRadioCilindro.Focus();
                    break;
                default:
                    Image myImage3 = Properties.Resources.Paralelepipedo;
                    this.imgFigura.Image = myImage3;
                    this.groupParale.Visible = true;
                    CentrarPanel(groupParale);
                    this.txtLadoA.Focus();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor1 = 0, valor2 = 0, valor3 = 0;

            try
            {
                switch (seleccionFigura)
                {
                    case 1:
                        valor1 = Convert.ToSingle(this.txtRadioEsfera.Text);
                        Geometria.Esfera esfera = new Geometria.Esfera(valor1);
                        esfera.HallarArea();
                        esfera.HallarVolumen();
                        this.lblRtaArea.Text = esfera.Area.ToString();
                        this.lblRtaVolumen.Text = esfera.Volumen.ToString();
                        this.groupResultado.Visible = true;
                        break;
                    case 2:
                        valor1 = Convert.ToSingle(this.txtRadioCilindro.Text);
                        valor2 = Convert.ToSingle(this.txtAlturaCilindro.Text);
                        Geometria.Cilindro cilindro = new Geometria.Cilindro(valor1, valor2);
                        cilindro.HallarArea();
                        cilindro.HallarVolumen();
                        this.lblRtaArea.Text = cilindro.Area.ToString();
                        this.lblRtaVolumen.Text = cilindro.Volumen.ToString();
                        this.groupResultado.Visible = true;
                        break;
                    default:
                        valor1 = Convert.ToSingle(this.txtLadoA.Text);
                        valor2 = Convert.ToSingle(this.txtLadoB.Text);
                        valor3 = Convert.ToSingle(this.txtLadoC.Text);
                        Geometria.Paralelepipedo paralelepipedo = new Geometria.Paralelepipedo(valor1, valor2, valor3);
                        paralelepipedo.HallarArea();
                        paralelepipedo.HallarVolumen();
                        this.lblRtaArea.Text = paralelepipedo.Area.ToString();
                        this.lblRtaVolumen.Text = paralelepipedo.Volumen.ToString();
                        this.groupResultado.Visible = true;
                        break;
                }
            }
            catch(Exception ex)
            {
                Mensaje($"Error en ejecución -> {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
            LimpiarRespuesta();
            this.groupResultado.Visible = false;
            Mensaje(string.Empty);
        }
    }
}

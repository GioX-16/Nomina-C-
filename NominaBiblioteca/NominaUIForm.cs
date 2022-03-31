using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaBiblioteca
{
    public partial class NominaUIForm : Form
    {
        protected int Cuentas = 6;
        double rangosalarial, ir;

        public enum Indices
        {
            NOMBRE,
            APELLIDO,
            PAGOPORHORAS,
            HTRABAJADAS,
            SBRUTO,
            SNETO


        }
        public NominaUIForm()
        {
            InitializeComponent();
        }

        public void LimpiarControlesText()
        {
            for (int i=0; i<Controls.Count; i++)
            {
                Control miControl = Controls[i];
                if (miControl is TextBox)
                    miControl.Text = "";
            }
        }

        public void Establecevalores(string[] valor)
        {
            if (valor.Length != Cuentas)
            {

                throw (new ArgumentException("Debe haber " +
                    (Cuentas + 1) + " objetos string en el arreglo"));
            }
            else
            {
                txtNombre.Text = valor[(int)Indices.NOMBRE];
                txtApellido.Text = valor[(int)Indices.APELLIDO];
                txtPagoHora.Text = valor[(int)Indices.PAGOPORHORAS];
                txtHTrabajadas.Text = valor[(int)Indices.HTRABAJADAS];
                txtSBruto.Text = valor[(int)Indices.SBRUTO];
                txtSNeto.Text = valor[(int)Indices.SNETO];
            }
        }

        public string[] Obtenervalor()
        {
            string[] valor = new string[Cuentas];

            valor[(int)Indices.NOMBRE] = txtNombre.Text;
            valor[(int)Indices.APELLIDO] = txtApellido.Text;
            valor[(int)Indices.PAGOPORHORAS] = txtPagoHora.Text;
            valor[(int)Indices.HTRABAJADAS] = txtHTrabajadas.Text;
            valor[(int)Indices.SBRUTO] = txtSBruto.Text;
            valor[(int)Indices.SNETO] = txtSNeto.Text;

            return valor;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pagohoras, Htrabajadas, salariobruto, salarioneto, 
                insslaboral,deducciones, proyeccionanual, sobreexcceso;            
            
            Htrabajadas = (Convert.ToDouble(txtHTrabajadas.Text));
            pagohoras = (Convert.ToDouble(txtPagoHora.Text));

            salariobruto = pagohoras * Htrabajadas;

            insslaboral = salariobruto - Porcentaje(salariobruto, 7);
            
            proyeccionanual = salariobruto * 12;
            salarioneto = salariobruto;

            if (proyeccionanual > 1 && proyeccionanual < 100000)
            {
                ir = salariobruto;
                
            }

            if(proyeccionanual>100000 && proyeccionanual < 200000)
            {
                sobreexcceso = 100000 - proyeccionanual;                
                ir = Porcentaje(sobreexcceso, 15);
                deducciones = ir + insslaboral;
                salarioneto = salariobruto - deducciones;
            }

            if (proyeccionanual > 200000 && proyeccionanual < 350000)
            {
                sobreexcceso = 200000 - proyeccionanual;                                    
                ir = Porcentaje(sobreexcceso, 2) + 15000;
                deducciones = ir + insslaboral;
                salarioneto = salariobruto - deducciones;
            }

            if(proyeccionanual>350000 && proyeccionanual < 500000)
            {
                sobreexcceso = 350000 - proyeccionanual;                
                ir = Porcentaje(sobreexcceso, 25) + 45000;
                deducciones = ir + insslaboral;
                salarioneto = salariobruto - deducciones;
            }

            if (proyeccionanual > 500000)
            {
                sobreexcceso = 500000 - proyeccionanual;                
                ir = Porcentaje(sobreexcceso, 30) + 82500;
                deducciones = ir + insslaboral;
                salarioneto = salariobruto - deducciones;
            }


            txtSBruto.Text = salariobruto.ToString();
            txtSNeto.Text = salarioneto.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private double Porcentaje(double cantidadOriginal, int NumeroPorcentual)
        {
            return (cantidadOriginal * NumeroPorcentual) / 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaBiblioteca
{
    [Serializable]
    public class Registros
    {
        private string Nombre;
        private string Apellido;
        private int Horastrabajadas;
        private decimal SalarioNeto;
        private decimal SalarioBruto;
        private decimal PagoporHora;

        public Registros() : this("", "", 0.0M, 0.0M, 0, 0.0M)
        {
        }

        public Registros(string nombre, string apellido, decimal SABruto, decimal SANeto,
            int HOtrabajadas, decimal PAHora)
        {
            Nombre1 = nombre;

            Apellido1 = apellido;

            SalarioBruto1 = SABruto;

            SalarioNeto1 = SANeto;

            Horastrabajadas1 = HOtrabajadas;

            PagoporHora1 = PAHora;

        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public decimal SalarioBruto1 { get => SalarioBruto; set => SalarioBruto = value; }
        public decimal SalarioNeto1 { get => SalarioNeto; set => SalarioNeto = value; }
        public int Horastrabajadas1 { get => Horastrabajadas; set => Horastrabajadas = value; }
        public decimal PagoporHora1 { get => PagoporHora; set => PagoporHora = value; }
    }
}

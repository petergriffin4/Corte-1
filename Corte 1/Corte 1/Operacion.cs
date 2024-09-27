using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte_1
{
    internal class Operacion
    {
        public DateTime FechaNac { get; set; }
        public int CalcularEdad()
        {
            int edad = 0;
            try
            {
                edad = DateTime.Now.Year - FechaNac.Year;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido un error: {ex.Message}");
            }
            return edad;

        }
    
        public string EvaluarEdad()
        {
            if (CalcularEdad() <= 18)
            {
                return "Menor de edad";
            }
            else if (CalcularEdad() >= 18 && CalcularEdad() < 69)
            {
                return "Adulto";
            }
            else
            {
                return "Adulto Mayor";
            }
        }
    }

}

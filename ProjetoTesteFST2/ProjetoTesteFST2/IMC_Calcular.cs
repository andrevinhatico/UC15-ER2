using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteFST2
{
    public static class IMCCalcular
    {
        public static string CalcularImc(double Altura, double Peso)
        {
            double Imc = Peso / (Altura * Altura);

            
            if (Imc < 18.5)
            {
                return  ("Abaixo do peso");

            }
            if (Imc >= 18.5 && Imc <= 24.9)
            {
                return  ("Peso normal!");
            }
            if (Imc >= 25.0 && Imc <= 29.9)
            {
                return  ("Sobrepeso");
            }
            if (Imc >= 30.0 && Imc <= 34.9)
            {
               return ("Obesidade grau I");
            }
            if (Imc >= 35.0 && Imc <= 39.9)
            {
                return  ("Obesidade grau II");
            }
            if (Imc >= 40.0)
            {
                return ("Obesidade grau III");
            }

            return ("Não classificado");
            
        }
    }

    
}

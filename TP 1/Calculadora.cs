using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1
{
    class Calculadora
    {
        public static double operar(Numero numero1, Numero numero2,string operador)
        {
            string Operador = validarOperador(operador);
            double resultado = 0;
            double num1 = numero1.Getter();//= numero1.getNumero();
            double num2 = numero2.Getter();//= numero2.getNumero();
            
            switch (Operador)
            { 
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        resultado = 0;
                        break;
                    }
                    else
                    resultado = num1 / num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
            }

            return resultado;        
        }

        public static string validarOperador(string operador)
        {
            string OperadorFallo;

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                return operador;
            }
            else
            {
                OperadorFallo = "+";
            }

            return OperadorFallo;
        }
    }
}



namespace EjercicioExcepciones
{
    public class Operacion
    {
        /// <summary>
        /// Primer número a ingresar
        /// </summary>
        public double n1;

        /// <summary>
        /// Segundo número a ingresar
        /// </summary>
        public double n2;

        /// <summary>
        /// Calcula la suma de dos números
        /// </summary>
        /// <returns>suma</returns>
        public double Suma(double n1, double n2)
        {
            return n1 + n2;
        }

        /// <summary>
        /// Calcula la resta de dos números
        /// </summary>
        /// <returns>resta</returns>
        public double Resta(double n1, double n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// Calcula la multipicación de dos números
        /// </summary>
        /// <returns>multiplicación</returns>
        public double Multiplica(double n1, double n2)
        {
            return n1 * n2;
        }

        /// <summary>
        /// Calcula la division de dos números cuyo primer valor no sea cero
        /// </summary>
        /// <returns>división</returns>
        public double Divide(double n1, double n2)
        {
            if (n1 == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero");
            }
            return n1 / n2;
        }
      
    }
}

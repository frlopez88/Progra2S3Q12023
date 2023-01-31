using System;
namespace Herencia.Modelos
{
	public class Persona
	{

		public string nombre { get; set; }
		public string apellido { get; set; }
		public DateTime fechaNacimiento { get; set; }
		public double peso { get; set; }

		public void correr(double librasBajar) {

			peso = peso - librasBajar;

        }

		public void comer(double librasComer) {

			peso = peso + librasComer;


		}

        public string toString()
        {

            return $"Nombre: {nombre}  Apellido: {apellido} Peso: {peso} ";

        }

    }
}


using System;
namespace Herencia.Modelos
{
	public class Empleado : Persona
	{

		public double salario { get; set; }

		public void trabajar(double salarioNuevo) {

			salario = salario + salarioNuevo;


        }

        public string toString()
        {

            return $"{base.toString()}  Salario: {this.salario}";

        }

    }
}


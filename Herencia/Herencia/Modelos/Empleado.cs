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

            return $"Nombre: {base.nombre}  Apellido: {apellido} Peso: {base.peso}  Salario: {this.salario}";

        }

    }
}


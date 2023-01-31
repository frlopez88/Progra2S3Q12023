using System;


namespace Herencia.Modelos
{
	public class Estudiante : Persona
	{

		public List<Materia> listadoMateriasPasadas { get; set; } = new List<Materia>();
		private double promedio {get; set; }
		public double Promedio {
			get => promedio;
		}


		public void pasarClase( string nombreClase, double notaClase)
		{
			Materia x = new Materia() {
				nombre = nombreClase,
				nota = notaClase
            };

			if (notaClase >= 60) {

				listadoMateriasPasadas.Add(x);

            }


			calcularPromedio();

        }

		private void calcularPromedio() {

			double totalNotas = 0;
			double conteoNotas = 0;

			foreach (Materia j in listadoMateriasPasadas) {

				totalNotas += j.nota;
				conteoNotas += 1;


            }

            promedio = (totalNotas / listadoMateriasPasadas.Count);
		}

        public string toString()
        {

			return $"{base.toString()} Promedio : {this.promedio}";

        }


    }

	
}


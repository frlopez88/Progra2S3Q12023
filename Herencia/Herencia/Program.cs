// Herencia:
// Es cuando una clase es hija de otra clase
// Medio de Transporte: Terrestre, Maritimo y Aereo.
// Cuando tenemos herencia por lo general se comparten atributos y cada clase hija
// tiene sus atribitos propios.

// Persona: Nombre, Identidad, FechaNacimiento, Peso. Comer(lbs a aumentar) -> Aumenta de Peso,
// Correr(Libras a Bajar) -> Bajar de Peso.
// Empleado: Salario. Trabajar() -> aumentar el salario;
// Estudiante: ListadoClases, Promedio. PasarClase( NombreClase, Nota) -> Vamos a agrelar a la lista de clases pasadas
// CalcularPromedio() Calcula el promedio de las clases.

using Herencia.Modelos;


Persona persona1 = new Persona() {
    nombre = "Juan",
    apellido = "Lopez",
    fechaNacimiento = new DateTime(1988, 01, 01),
    peso = 150
};

persona1.comer(1);
persona1.correr(0.5);

Empleado persona2 = new Empleado() {

    nombre = "Fernando",
    apellido = "Lopez",
    fechaNacimiento = new DateTime( 1988, 11,30),
    peso = 185,
    salario = 500

};


persona2.trabajar(10);
persona2.comer(2);
persona2.correr(1);


Estudiante persona3 = new Estudiante()
{
    nombre = "Lia",
    apellido = "Garay",
    fechaNacimiento = new DateTime(1995, 05, 05),
    peso = 120

};

persona3.comer(0.5);
persona3.correr(1);
persona3.pasarClase("Matematicas", 80);
persona3.pasarClase("Programacion 1", 100);
persona3.pasarClase("Español", 90);


Console.WriteLine(persona1.toString());
Console.WriteLine(persona2.toString());
Console.WriteLine(persona3.toString());
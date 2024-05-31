using Nomina.Model;
Console.WriteLine("Demostración de relación de herencia en una nómina.\n");
List<Empleado> empleados = new List<Empleado>();
empleados.Add(new EmpleadoDeBase("Maria", "Moreno", "MOMA19570824ABC", new DateTime(2016, 6, 16), 350.0M));
empleados.Add(new Empleado DeBase("Alberto", "Arjona", "ARAL19970314DEF", new DateTime(2022, 1, 1), 300.0M)); 
empleados.Add(new EmpleadoConComision("Raul", "Ramírez", "RARA19850801GHI", new DateTime(2020, 1, 1)));
empleados.Add(new EmpleadoConComision("Josefina", "Juárez", "JUJO19950915JKL", new DateTime(2021, 3, 16)));

for(int i = 0; i < empleados.Count; i++)
{
    ImprimirInfoDelEmpleado(empleados[i]);
}




//EmpleadoDeBase empleado DeBase1 = new EmpleadoDeBase ("Maria", "Moreno", "MOMA19570824ABC", new DateTime(2016, 6, 16), 350.0M);
//ImprimirInfoDelEmpleado (empleadoDeBasel);
//ImprimirInfoDeEmpleadoDeBase (empleadoDeBase1);

//Console.WriteLine();
//EmpleadoDeBase empleado De Base2 = new EmpleadoDeBase("Alberto", "Arjona", "ARAL19970314DEF" new DateTime (2022, 1, 1), 300.0M); 
//ImprimirInfoDeEmpleado De Base (empleado DeBase2);
//ImprimirInfoDelEmpleado (empleado De Base2);

//Console.WriteLine();
//EmpleadoConComision empleadoConComision1 = new EmpleadoConComision("Raul", "Ramirez", "RARA19850801GHI", new DateTime(2020, 1, 1));
//empleadoConComision1. ImporteTotalDeVentas = 33250.0м;
//ImprimirInfoDelEmpleado (empleadoConComision1);
////ImprimirInfoDeEmpleadoConComision (empleadoConComision1);

//Console.WriteLine();
//EmpleadoConComision empleadoConComision2 = new EmpleadoConComision("Josefina", Juárez" "JUJO19950915JKL" new DateTime(2021, 3, 16)); //empleadoConComision2. ImporteTotalDeVentas = 23345.0M;
//ImprimirInfoDelEmpleado (empleadoConComision2);
//ImprimirInfoDeEmpleadoConComision (empleado ConComision2);

void Imprimir InfoDelEmpleado (Empleado empleado)
{
Console.WriteLine($"Nombre completo: {empleado.NombreCompleto}"); 
Console.WriteLine($"Rfc: {empleado.Rfc}");
Console.WriteLine($"Fecha de ingreso: {empleado.FechaDe Ingreso}");
Console.WriteLine($"Salario del periodo: {empleado.CalcularSalario()}");
}


//void ImprimirInfoDeEmpleado De Base (Empleado De Base empleadoDeBase) 
//{
// Console.WriteLine($"Nombre completo: {empleado DeBase. NombreCompleto}");
// Console.WriteLine($"Rfc: {empleado DeBase.Rfc}");
// Console.WriteLine($"Fecha de ingreso: {empleado De Base. FechaDe Ingreso}");
// Console.WriteLine($"Salario diario: {empleado De Base. SalarioDiario}");
// Console.WriteLine($"Salario fijo del periodo: {empleadoDeBase. CalcularSalarioFijoDelPeriodo(15)}");
// Console.WriteLine($"Estimulo de antigüedad: {empleadoDeBase. CalcularEstimuloPorAntiguedad()}");
// Console.WriteLine($"Salario del periodo: {empleadoDeBase. CalcularSalario()}");
//}


//void Imprimir InfoDeEmpleadoConComision (EmpleadoConComision empleado)
//{
// Console.WriteLine($"Nombre completo: {empleado. NombreCompleto}");
// Console.WriteLine($"Rfc: {empleado.Rfc}");
// Console.WriteLine($"Fecha de ingreso: {empleado. FechaDeIngreso}");
// Console.WriteLine($"Importe total de ventas: {empleado. ImporteTotalDeVentas}");
// Console.WriteLine($"Salario del periodo: fempleado. CalcularSalario ()}");
//}using Nomina.Model;
Console.WriteLine("Demostración de relación de herencia en una nómina.\n");
List<Empleado> empleados = new List<Empleado>();
empleados.Add(new EmpleadoDeBase("Maria", "Moreno", "MOMA19570824ABC", new DateTime(2016, 6, 16), 350.0M));
empleados.Add(new Empleado DeBase("Alberto", "Arjona", "ARAL19970314DEF", new DateTime(2022, 1, 1), 300.0M)); 
empleados.Add(new EmpleadoConComision("Raul", "Ramírez", "RARA19850801GHI", new DateTime(2020, 1, 1)));
empleados.Add(new EmpleadoConComision("Josefina", "Juárez", "JUJO19950915JKL", new DateTime(2021, 3, 16)));

//for(int i = 0; i < empleados.Count; i++)
//{
 //   ImprimirInfoDelEmpleado(empleados[i]);
//}

//Console.WriteLine();

foreach (var empleado in empleados)
{
    ImprimirInfoDelEmpleado(empleado);

}


//EmpleadoDeBase empleado DeBase1 = new EmpleadoDeBase ("Maria", "Moreno", "MOMA19570824ABC", new DateTime(2016, 6, 16), 350.0M);
//ImprimirInfoDelEmpleado (empleadoDeBasel);
//ImprimirInfoDeEmpleadoDeBase (empleadoDeBase1);

//Console.WriteLine();
//EmpleadoDeBase empleado De Base2 = new EmpleadoDeBase("Alberto", "Arjona", "ARAL19970314DEF" new DateTime (2022, 1, 1), 300.0M); 
//ImprimirInfoDeEmpleado De Base (empleado DeBase2);
//ImprimirInfoDelEmpleado (empleado De Base2);

//Console.WriteLine();
//EmpleadoConComision empleadoConComision1 = new EmpleadoConComision("Raul", "Ramirez", "RARA19850801GHI", new DateTime(2020, 1, 1));
//empleadoConComision1. ImporteTotalDeVentas = 33250.0м;
//ImprimirInfoDelEmpleado (empleadoConComision1);
////ImprimirInfoDeEmpleadoConComision (empleadoConComision1);

//Console.WriteLine();
//EmpleadoConComision empleadoConComision2 = new EmpleadoConComision("Josefina", Juárez" "JUJO19950915JKL" new DateTime(2021, 3, 16)); //empleadoConComision2. ImporteTotalDeVentas = 23345.0M;
//ImprimirInfoDelEmpleado (empleadoConComision2);
//ImprimirInfoDeEmpleadoConComision (empleado ConComision2);

void Imprimir InfoDelEmpleado (Empleado empleado)
{
Console.WriteLine($"Nombre completo: {empleado.NombreCompleto}"); 
Console.WriteLine($"Rfc: {empleado.Rfc}");
Console.WriteLine($"Fecha de ingreso: {empleado.FechaDe Ingreso}");
Console.WriteLine($"Salario del periodo: {empleado.CalcularSalario()}");
}


//void ImprimirInfoDeEmpleado De Base (Empleado De Base empleadoDeBase) 
//{
// Console.WriteLine($"Nombre completo: {empleado DeBase. NombreCompleto}");
// Console.WriteLine($"Rfc: {empleado DeBase.Rfc}");
// Console.WriteLine($"Fecha de ingreso: {empleado De Base. FechaDe Ingreso}");
// Console.WriteLine($"Salario diario: {empleado De Base. SalarioDiario}");
// Console.WriteLine($"Salario fijo del periodo: {empleadoDeBase. CalcularSalarioFijoDelPeriodo(15)}");
// Console.WriteLine($"Estimulo de antigüedad: {empleadoDeBase. CalcularEstimuloPorAntiguedad()}");
// Console.WriteLine($"Salario del periodo: {empleadoDeBase. CalcularSalario()}");
//}


//void Imprimir InfoDeEmpleadoConComision (EmpleadoConComision empleado)
//{
// Console.WriteLine($"Nombre completo: {empleado. NombreCompleto}");
// Console.WriteLine($"Rfc: {empleado.Rfc}");
// Console.WriteLine($"Fecha de ingreso: {empleado. FechaDeIngreso}");
// Console.WriteLine($"Importe total de ventas: {empleado. ImporteTotalDeVentas}");
// Console.WriteLine($"Salario del periodo: fempleado. CalcularSalario ()}");
//}
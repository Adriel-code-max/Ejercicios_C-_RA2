Calculadora de Sueldo Neto en C#
Este programa en C# permite calcular el sueldo neto de un empleado después de aplicar los descuentos de AFP (Administradora de Fondos de Pensiones), SFS (Seguro Familiar de Salud) e ISR (Impuesto sobre la Renta) según las normativas vigentes.

Características
Entrada de datos:

Sueldo bruto mensual del empleado.

Procesamiento:

Calcula los descuentos de AFP (2.87%) y SFS (3.04%).

Calcula el ISR basado en el sueldo anual, aplicando los tramos correspondientes:

Exento: RD$ 499,884.00 anual.

Tramo 1: RD
499
,
884.01
−
R
D
499,884.01−RD 749,822.00 (15%).

Tramo 2: RD
749
,
822.01
−
R
D
749,822.01−RD 1,041,224.00 (20% + RD$ 37,491.00).

Tramo 3: Más de RD
1
,
041
,
224.00
(
25
1,041,224.00(25 75,082.00).

Calcula el sueldo neto mensual restando los descuentos.

Salida: Muestra el sueldo bruto, descuentos de AFP, SFS, ISR (si aplica) y el sueldo neto.

Ejecución
El programa solicita al usuario que ingrese el sueldo bruto mensual del empleado.

Calcula los descuentos de AFP y SFS.

Calcula el ISR basado en el sueldo anual.

Muestra el sueldo bruto, los descuentos y el sueldo neto.

Tecnologías
Lenguaje: C#

Entorno: .NET
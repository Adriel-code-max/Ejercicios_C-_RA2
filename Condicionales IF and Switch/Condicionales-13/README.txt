Sistema de Evaluación de Estudiantes en C#
Este programa en C# permite calcular la nota final de un estudiante en una materia, considerando la posibilidad de exámenes completivos y extraordinarios si el estudiante no alcanza la nota mínima para aprobar.

Características
Entrada de datos:

Nombre del estudiante.

Nombre de la materia.

Cuatro notas parciales.

Nota del examen completivo (si aplica).

Nota del examen extraordinario (si aplica).

Procesamiento:

Calcula el promedio de las cuatro notas.

Si el promedio es mayor o igual a 70, el estudiante aprueba.

Si el promedio es menor a 70, se solicita la nota del examen completivo y se calcula la nota completiva (50% promedio + 50% examen completivo).

Si la nota completiva es menor a 70, se solicita la nota del examen extraordinario y se calcula la nota extraordinaria (30% promedio + 70% examen extraordinario).

Si la nota extraordinaria es menor a 70, el estudiante reprueba la materia.

Salida: Muestra el resultado final del estudiante (aprobado o reprobado) y la nota correspondiente.

Ejecución
El programa solicita al usuario que ingrese el nombre del estudiante, la materia y las cuatro notas parciales.

Calcula el promedio de las cuatro notas.

Si el promedio es mayor o igual a 70, el estudiante aprueba.

Si el promedio es menor a 70, solicita la nota del examen completivo y calcula la nota completiva.

Si la nota completiva es menor a 70, solicita la nota del examen extraordinario y calcula la nota extraordinaria.

Muestra el resultado final del estudiante.

Tecnologías
Lenguaje: C#

Entorno: .NET
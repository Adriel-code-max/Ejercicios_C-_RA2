Sistema de Gestión de Habitaciones de Hotel en C#
Este programa en C# simula un sistema de gestión de habitaciones para un hotel llamado "Hotel La Paja". Permite visualizar el estado de las habitaciones (libres u ocupadas) y ocupar una habitación específica.

Características
Estructura del hotel:

5 pisos.

10 habitaciones por piso.

Cada habitación puede estar libre (L) u ocupada (X).

Funcionalidades:

Mostrar mapa de habitaciones: Muestra el estado actual de todas las habitaciones.

Ocupar una habitación: Permite al usuario seleccionar una habitación específica para marcarla como ocupada.

Salir: Cierra el sistema.

Validaciones:

Verifica que el número de piso y habitación estén dentro del rango válido.

Verifica si la habitación ya está ocupada antes de marcarla como tal.

Ejecución
El programa inicia mostrando un menú con las opciones disponibles.

El usuario puede:

Ver el mapa de habitaciones.

Ocupar una habitación específica.

Salir del sistema.

Después de cada operación, el programa espera a que el usuario presione una tecla para continuar.

Tecnologías
Lenguaje: C#

Entorno: .NET

Ejemplo de Salida
Caso 1: Mostrar mapa de habitaciones
Copy
Sistema de Gestión de Habitaciones - Hotel La Paja
1. Mostrar mapa de habitaciones
2. Ocupar una habitacion
3. Salir
Seleccione una opcion: 1

Mapa de habitaciones:
Piso 1: L L L L L L L L L L
Piso 2: L L L L L L L L L L
Piso 3: L L L L L L L L L L
Piso 4: L L L L L L L L L L
Piso 5: L L L L L L L L L L

Presione cualquier tecla para continuar...
Caso 2: Ocupar una habitación
Copy
Sistema de Gestión de Habitaciones - Hotel La Paja
1. Mostrar mapa de habitaciones
2. Ocupar una habitacion
3. Salir
Seleccione una opcion: 2

Ingrese el número de piso (1-5): 3
Ingrese el número de habitación (1-10): 5

Habitacion 5 en el piso 3 ahora esta ocupada.

Presione cualquier tecla para continuar...
Caso 3: Intentar ocupar una habitación ya ocupada
Copy
Sistema de Gestión de Habitaciones - Hotel La Paja
1. Mostrar mapa de habitaciones
2. Ocupar una habitacion
3. Salir
Seleccione una opcion: 2

Ingrese el número de piso (1-5): 3
Ingrese el número de habitación (1-10): 5

Habitacion 5 en el piso 3 ya esta ocupada.

Presione cualquier tecla para continuar...
Caso 4: Salir del sistema
Copy
Sistema de Gestión de Habitaciones - Hotel La Paja
1. Mostrar mapa de habitaciones
2. Ocupar una habitacion
3. Salir
Seleccione una opcion: 3

Saliendo del sistema...

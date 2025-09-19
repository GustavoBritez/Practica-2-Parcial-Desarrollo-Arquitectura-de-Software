Requisitos del Ejercicio

1- Cargar el archivo XML: Levantar el archivo XML en un DataSet utilizando el método ReadXml.

2- Crear relaciones en el DataSet:  

Relación Estudiante → Prestamos: Usar la clave Legajo para vincular.  
Relación Libro → Prestamos: Usar la clave ID para vincular.


3- Mostrar datos en grillas:  

Mostrar una grilla con los Estudiantes.  
Mostrar una grilla con los Libros.  
Mostrar una grilla con los Préstamos filtrada según el estudiante seleccionado.


4- Filtrado dinámico de préstamos:Cada vez que el usuario seleccione un estudiante en la grilla de estudiantes, la grilla de préstamos debe mostrar únicamente los préstamos pendientes correspondientes a ese estudiante.

5- Usar BindingSource:Implementar la lógica de Master-Detail utilizando BindingSource para gestionar la relación y el filtrado entre las grillas.


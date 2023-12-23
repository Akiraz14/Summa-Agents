# Summas - Prueba Tecnica .NET 💻

[![](https://static.wixstatic.com/media/57c50b_10ace1329e484af3abaa7321ca5d7010~mv2.jpg/v1/fill/w_350,h_197,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/57c50b_10ace1329e484af3abaa7321ca5d7010~mv2.jpg)]()

Prueba técnica con enfoque en conocimientos de desarrollo creada por Summa – Grupo Argos

### 📖 Tabla de contenido

* [➤ Prueba técnica Gestor SR – Desarrollador .NET](#summas---prueba-tecnica-net-💻)
    * [Credito de la solución](#solución-realizada-por-juan-zapata)
	* [PARTE 1](#➤-parte-1)
 		* Planteamiento
		* Aspectos para tener en cuenta
		* Descripción detalladamente la solución planteada y sus componentes
		* Solución propuesta
  	* [PARTE 2](#➤-parte-2)
 		* Planteamiento
		* Criterios de evaluación
		* Entrega del proyecto
		* Solución propuesta

[![](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/colored.png)]()

## Credito de la solución

Esta solución propuesta fue realizada por Juan Zapata (aka. Akiraz)

## ➤ PARTE 1

### Planteamiento
Como parte de los proyectos de sostenibilidad de la compañía, se está buscando una solución que permita que los empleados publiquen sus rutas de transporte e indiquen los cupos que tienen disponibles en su vehículo, la hora de salida, el lugar de origen y el destino y que permita a los demás compañeros inscribirse en alguna de las rutas.

La aplicación debe tener las siguientes funcionalidades: 
* Autenticar a los empleados de la compañía:
	* La aplicación sólo puede ser accedida por los usuarios de la compañía. 
	* Para facilitar la gestión es necesario que la aplicación use el directorio activo para autenticación y autorización. 
* Registrar mi ruta:
	* Como empleado necesito publicar la ruta que voy a realizar en una fecha particular, para que mis compañeros puedan suscribirse a ella. 
	* Para el registro de la ruta se debe poder ingresar fecha, el tipo de vehículo, hora de salida, cupos disponibles, lugar de origen y lugar de destino. 
* Cancelar mi ruta: Como empleado quiero poder cancelar una de las rutas que he publicado para que no esté disponible para suscripción. o Si la ruta es cancelada, se debe notificar a los usuarios que se habían suscrito.
* Ver personas suscritas a mi ruta:
	* Como dueño de la ruta quiero poder ver los datos compañeros que se han suscrito a mi ruta para poder coordinar con ellos los detalles de la recogida. 
	* De cada suscriptor a la ruta se debe ver nombre, correo electrónico, celular. Estos datos deben consultarse en el directorio activo. 
* Ver rutas disponibles:
	* Como empleado quiero poder ver el listado de rutas que fueron compartidas para la fecha actual para saber a cuál de ellas me puedo suscribir. 
	* La lista debe permitir ver los datos generales de la ruta: hora de salida, cupos disponibles, lugar de origen y lugar de destino. 
	* La lista me debe permitir ver las rutas para el día actual en orden ascendente de hora de salida. 
	* Únicamente se podrán ver las rutas que tengan cupos disponibles y que sean en horas futuras.
* Suscribirse a una ruta: Como empleado quiero poder suscribirme a una ruta disponible para asegurar mi cupo. o Se debe notificar al usuario que publicó la ruta vía correo electrónico y a su celular si una persona se inscribe a su ruta. 

### Aspectos para tener en cuenta
* Se espera que la solución sea una aplicación móvil y una página web. 
* La interfaz de usuario debe estar basada en el manual de marca de la compañía.
* El número aproximado de usuarios esperados es 500 diarios. 

Como experto técnico usted debe plantear la solución para la necesidad del negocio y entregar:

### Descripción detalladamente la solución planteada y sus componentes
* Diagrama de arquitectura de la solución (Basada en la nube de Azure). 
* Modelo entidad relación. 
* Tecnologías, lenguajes de programación y frameworks a utilizar y justificación de la selección de cada uno. 
* Metodología de desarrollo. 
* Descripción de las buenas prácticas metodológicas que pueden agilizar el proceso de desarrollo, para la entrega de software de calidad en los diferentes ambientes. 
* Infraestructura y plataformas necesaria para soportar el desarrollo. 
* Posibles riesgos que pueden materializarse en la ejecución del proyecto y cómo mitigarlos. 
* Otros elementos que considere necesarios para este proyecto.

### Solución propuesta

## ➤ PARTE 2
### Planteamiento
Un sistema de información cuenta con tres agentes (A, B y C) cada agente cumple con dos funcionalidades:

* Funcionalidad 1: Obtener media
	* Definir la función getMedia(Lista de números reales)  valor de retorno: número real
	* Agente A: Obtener la media aritmética o promedio
	* Agente B: Obtener media armónica 
	* Agente C: Obtener mediana

	Si la cantidad de datos es impar, la mediana es el valor que queda en la mitad al ordenar los datos de menor a mayor.

	Si la cantidad de datos es par, la mediana es el promedio de los dos valores que quedan al centro al ordenar los datos de menor a mayor.

* Funcionalidad 2: Escalera
Definir función getStaircase(número entero) valor de retorno: cadena de texto

	* Agente A: La base y altura son ambas iguales a n. Se dibuja usando el símbolo # símbolos y espacios. La última línea no va precedida de ningún espacio.
   	Escriba un programa que imprima una escalera de tamaño n. Formato de entrada: Un único entero, n, que denota el tamaño de la escalera.
	
 		Restricciones:  0 < n < 100.  La escalera debe estar alineada a la derecha.

	* Agente B: La cima y altura son ambas iguales a n. Se dibuja usando el símbolo # símbolos y espacios. La primera línea no va precedida de ningún espacio. 	Escriba un programa que imprima una escalera de tamaño n. Formato de entrada: Un único entero, n, que denota el tamaño de la escalera.
	
 		Restricciones:  0 < n < 100.  La escalera debe estar alineada a la derecha.

	* Agente C:
	La base y cima son ambas iguales a n. Entre los extremos superior e inferior debe haber una distancia igual a n con el centro. Se dibuja usando el símbolo # símbolos y espacios. La línea central no va precedida de ningún espacio. Escriba un programa que imprima una escalera de tamaño n. Formato de entrada: Un único entero, n, que denota el tamaño de la primera y última línea de la escalera.

		Restricciones:  0 < n < 100.  La escalera debe estar alineada al centro.

### Solución propuesta

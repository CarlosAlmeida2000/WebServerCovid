# Web Services de cifras del Covid

Esta aplicación se realizó con la finalidad de crear Web services en .NET Core C# y consumir los datos mediante Ajax.

## **Nota:**

Para visualizar la Web Service en .NET Core C#, debe tener instalado la IDE de [**Visual Studio**](https://visualstudio.microsoft.com/es/).

## **Instalación**

### **Paso 1**

**Forma 1:** Dar clic en **Code**, luego **Download Zip** y descomprimir el archivo en tu ordenador.

**Forma 2:** Abrir una terminal en tu ordenador y ejecutar el siguiente comando:

    https://github.com/CarlosAlmeida2000/WebServicesCovid.git

**Forma3:** Abrir Visual Studio y seleccionar la opción clonar repositorio.

### **Paso 2**

Buscar la carpeta de **WebServicesCovid**, dentro de la carpeta deberas abrir el archivo **_WebServicesCovid.sln_**, ese archivo permitira abrir el proyecto en **Visual Studio**.

### **Paso 3**

Configurar .NET Core para conectar la base de datos a la aplicación, **Nota:** la aplicación se realizó utilizando el motor de base de datos [**PostgreSQL**](https://www.postgresql.org/).

1. Ubicarse en la carpeta que tiene las configuaciones de la aplicación **..\WebServicesCovid\WebServerCovid**.
2. Buscar el archivo **appsettings.json**
3. Abrir el archivo y modificar siguientes datos.

-   "Config_postgres": "Server=**{Ruta servidor}**;Port=**{Puerto del servidor}**;Database=**{Nombre de base de datos}**;User Id=**{Usuario}**;Password=**{Contraseña}**;"

**Extra:** La aplicación fue diseñada para conectarse al motor de base de datos de **PostgresSQL**, si desea ingresar un nuevo motor de base de datos deberá instalar los paquetes necesarios para su utilización.

### **Paso 4**

Crear la base de datos en **PostgreSQL** con las siguientes tablas:

**Provincia**

| idprovincia | nombre   | superficie | hombres | mujeres | capital  | problacion_total | contagiados | recuperados | fallecidos |
| ----------- | -------- | ---------- | ------- | ------- | -------- | ---------------- | ----------- | ----------- | ---------- |
| 13          | Los Ríos | 7205,27    | 380016  | 398099  | Babahoyo | 778115           | 778115      | 778115      | 778115     |
| ....        | ....     | ........   | ....    | ....    | ....     | ....             | ....        | ....        | ....       |

**Nota:** Los datos de las tablas se encuentra en un archivo **provincias.csv** en la carpeta **..\WebServerCovid\Recursos** y tambien cuenta con un **.txt** que contienen el script para crear la tabla provincia.

### **Paso 5**

Ejecutar la WebService y la Web de consumo de .NET Core C#.

1. Para ejecutar la aplicación se deben abrir dos veces el proyecto de **WebServerCovid** en **Visual Studio**, donde una ventana de la IDE servirá para ejecutar el WebService y la otra ventana servirá para ejecutar la aplicación de consumo.
2. Ejecuar el WebService. **Nota:** Para poder ejecuar el WebService corretamete debe tener seleccionado en el IDE **WebServerCovid** y al seleccionar correr o play de **Visual Studio** se debe cambiar de **IIS Express** a **WebServerCovid**.
3. Ejecutar la aplicación de consumo. **Nota:** Para poder ejecuar la aplicación de consumo corretamete debe tener seleccionado en el IDE **ConsumoWScovid** y al seleccionar correr o play de **Visual Studio** se debe cambiar de **IIS Express** a **ConsumoWScovid**.

## **Extra**

Si deseas ver los datos que trae de la base de datos a la **WebService** debes tener ejecutado el servidor e ir a la siguiente dirección en tu navegador.

1.  Ver todos los datos de las provincias.

        https://localhost:5001/api/contagios_ecuador

2.  Ver los datos de una provincia especifica.

    -   **Por id:**

              https://localhost:5001/api/contagios_ecuador/id-provincia?id={Id_provincia}

    -   **Por nombre:**

             https://localhost:5001/api/contagios_ecuador/name-provincia?provincia={Nombre_provincia}

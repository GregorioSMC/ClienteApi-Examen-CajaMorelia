# Solucion propuesta al Ejercicio 2: API en .NET Core con Entity Framework

Para el desarrollo del API se siguio la siguiente estructura
  
<img width="306" height="562" alt="image" src="https://github.com/user-attachments/assets/0fc29ef9-423a-4f7f-800a-df3f39b03c4a" />

Donde se creo un proyecto base ASP.NET Core Web API y tres librerias de clases:
* Aplication: donde se crearon los servicios que se consumiran mediante una intefaz que llama a la clase ClienteService
* Domain: donde se creo la clase cliente que dara forma a la tabla cliente y al manejo de la informacion
* Infrastructure: donde se estable la conexión con las base de datos a traves de entityFramework

<img width="719" height="234" alt="image" src="https://github.com/user-attachments/assets/0b85cf0d-50d2-4233-9dfc-b1dc50d882c9" />

Para el apartado de base de datos se creo la tabla clientes y se valido que la conexion existiera de forma correcta y se valida su creación

<img width="395" height="570" alt="image" src="https://github.com/user-attachments/assets/4a6bbdf8-7df2-4dfb-a8b6-d916bcb17ec8" />

posteriormente se corrobora que los endpoints funcionen correctamente y se incluyan todos los elementos correspondientes a un CRUD

<img width="1902" height="1021" alt="image" src="https://github.com/user-attachments/assets/8faa888b-f84a-4b31-8476-50e8601fcf1e" />

posteriormente se valida que funcione correctamente la autentificacion configurada mediente API KEY

<img width="530" height="176" alt="image" src="https://github.com/user-attachments/assets/d3f0ce26-e7fa-4f7a-9480-4757cfcd5da4" />

<img width="1565" height="289" alt="image" src="https://github.com/user-attachments/assets/7ceb3cab-7899-4ee3-8193-c4b05858bf5e" />

Haciendo uso de postman se valida que los mensajes y codigos funcionen de acuerdo a lo requerido 
* para el caso de que no se construya una llamada con API KEY

<img width="1775" height="392" alt="image" src="https://github.com/user-attachments/assets/2825b27c-bf1d-4bf9-97b6-acf96378d873" />

* para el caso que se construye el documento con una clave que no es valida

<img width="1794" height="396" alt="image" src="https://github.com/user-attachments/assets/22d389bc-4bf0-4808-81d2-a48bcdb3d8d5" />

* para el caso donde se construye un documento con credenciales validas y se obtiene una respuesta exitosa

<img width="1760" height="691" alt="image" src="https://github.com/user-attachments/assets/3b5bb701-161b-4ce3-86da-d2fb8f425fd2" />

Finalmente se valida que la informacion se obtenga correctamente de la base de datos

<img width="1919" height="1031" alt="image" src="https://github.com/user-attachments/assets/65f6224c-2c95-4f80-811e-125c7d8f9620" />


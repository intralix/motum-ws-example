# Introducción

Este proyecto se creó como punto de partida para ejemplificar el consumo de los servicios web de Intralix.

## Dependencias necesarias

Se utiliza la librería  [Guzzle PHP HTTP client](http://docs.guzzlephp.org/en/stable/) para realizar solicitudes HTTP.

Se utiliza el gestor de paquetes [composer](https://getcomposer.org/) para instalar las dependencias necesarias del proyecto. 

### Instalación de Composer para Windows

Descargar de: https://getcomposer.org/download/

### Instalación de Composer - Linux / Unix / macOS

Obtener instrucciones de: https://getcomposer.org/doc/00-intro.md#installation-linux-unix-macos

## Instrucciones
#### Clonar Repositorio:
*`git clone  https://github.com/intralix/motum-ws-example.git`*

#### Instalando dependencias
- Navegar al directorio ***php*** dentro del repositorio
- Ejecuta el comando *`composer install`* dentro de ***repositorio/php***

- Abrir el archivo ***process_request.php*** y colocar los valores según el documento proporcionado:

| Linea | Actualizar Valor |
|--|--|
| 34 | Verifica que la ***url*** sea correcta |
| 41 | API_TOKEN |
| 46 | CLIENT_ID |

- Ejecutar el script para obtener información del endpoint.


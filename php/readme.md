
# Instructions

You need to use composer to install dependencies: 

### Composer for windows

Download from: https://getcomposer.org/download/

### Installation - Linux / Unix / macOS

Get instructions: https://getcomposer.org/doc/00-intro.md#installation-linux-unix-macos

### Instrucciones
- Clonar Repositorio:
`git clone  https://github.com/intralix/motum-ws-example.git`

- Instalando dependencias
Navegar al directorio ***php*** dentro del repositorio
Ejecuta el comando *composer install* dentro del *repositorio/php*
`composer install`

- Abrir el archivo ***process_request.php*** y colocar los valores según el documento proporcionado:

| Linea | Valor a Reemplazar |
|--|--|
| 34 | Verifica que la ***url*** sea correcta |
| 41 | API_TOKEN |
| 46 | CLIENT_ID |

- Ejecutar el script para obtener información del endpoint.

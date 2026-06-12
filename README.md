<div align="center">

<!-- Espacio para el Logo/Banner del proyecto -->
<img src="https://via.placeholder.com/900x250.png?text=TiendaDonPedro+%7C+Sistema+de+Gesti%C3%B3n" alt="TiendaDonPedro Banner" width="100%">

# TiendaDonPedro

### Sistema de Gestion Comercial de Escritorio

</div>

---

## Descripcion del Proyecto

**TiendaDonPedro** es una aplicacion de escritorio desarrollada en **C# con Windows Forms** que ofrece una solucion integral para la gestion administrativa y comercial de una tienda o pequeno negocio.

El sistema resuelve la problematica del control manual de inventario, clientes y ventas en comercios pequenos y medianos, centralizando en una sola interfaz la gestion de productos, categorias, clientes, usuarios y facturacion de ventas, todo respaldado por una base de datos MySQL/MariaDB y con generacion de reportes en Excel.

---

## Insignias del Proyecto

![Status](https://img.shields.io/badge/status-en%20desarrollo-yellow?style=for-the-badge)
![Version](https://img.shields.io/badge/version-1.0.0-blue?style=for-the-badge)
![License](https://img.shields.io/badge/license-MIT-green?style=for-the-badge)

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%20Framework-4.8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

---

## Caracteristicas Principales

- Autenticacion de usuarios con manejo de sesion y roles (administrador / vendedor).
- Gestion de categorias de productos (CRUD completo).
- Gestion de productos: registro, edicion, control de inventario y precios.
- Gestion de clientes: alta, edicion y consulta de informacion de clientes.
- Gestion de usuarios del sistema: administracion de accesos y permisos.
- Modulo de facturacion: generacion de facturas con encabezado y detalle de venta.
- Exportacion de reportes a Excel mediante la libreria EPPlus.
- Interfaz grafica moderna bajo un diseno Flat UI.
- Manejo seguro de datos apoyado en BouncyCastle Cryptography.

---

## Stack Tecnologico

| Categoria              | Tecnologia                                       |
|------------------------|--------------------------------------------------|
| **Lenguaje**           | C#                                                 |
| **Framework UI**       | Windows Forms (.NET Framework 4.8)                |
| **Base de Datos**      | MySQL / MariaDB                                    |
| **Acceso a datos**     | MySql.Data (Connector/NET)                        |
| **Reportes**           | EPPlus (exportacion a Excel)                      |
| **Seguridad**          | BouncyCastle.Cryptography                         |
| **IDE recomendado**    | Visual Studio 2019 / 2022                         |
| **Gestor de paquetes** | NuGet                                              |

---

## Requisitos Previos

Antes de comenzar, asegurate de tener instalado lo siguiente:

- **Visual Studio 2019 o superior** (con el workload de Desarrollo de escritorio .NET).
- **.NET Framework 4.8 Developer Pack**.
- **MySQL Server / MariaDB** (se recomienda usar XAMPP o WAMP) corriendo en `localhost:3306`.
- **Git** para clonar el repositorio.

---

## Instalacion

Sigue estos pasos para configurar el proyecto en tu entorno local:

### 1. Clonar el repositorio

```bash
git clone https://github.com/Bhusvnash/TiendaDonPedro.git
cd TiendaDonPedro
```

### 2. Configurar la base de datos

Crea la base de datos en MySQL/MariaDB e importa el script incluido en el repositorio:

```sql
CREATE DATABASE tienda_don_pedro;
```

Luego, importa el archivo de estructura y datos ubicado en:

```
Base de Datos/Script bd_tiendadonpedro.sql
```

Puedes hacerlo desde la linea de comandos:

```bash
mysql -u root -p tienda_don_pedro < "Base de Datos/Script bd_tiendadonpedro.sql"
```

### 3. Abrir el proyecto en Visual Studio

Abre la solucion ubicada en:

```
ProyectoVS_TiendaDonPedro/TiendaDonPedro.sln
```

### 4. Restaurar los paquetes NuGet

Visual Studio restaurara automaticamente las dependencias al compilar, o puedes hacerlo manualmente desde la consola del Administrador de paquetes NuGet:

```powershell
nuget restore ProyectoVS_TiendaDonPedro/TiendaDonPedro.sln
```

---

## Configuracion (Variables de Conexion)

La aplicacion utiliza una cadena de conexion a la base de datos definida en el archivo `BackEnd/FuncionesLogin.cs`. Antes de ejecutar el proyecto, ajusta los siguientes valores segun tu entorno:

```csharp
public static string cadenaConexion = "Server=127.0.0.1;Port=3306;Database=tienda_don_pedro;Uid=root;Pwd=;";
```

| Variable   | Descripcion                            | Valor por defecto      |
|------------|------------------------------------------|--------------------------|
| `Server`   | Direccion del servidor MySQL              | `127.0.0.1`               |
| `Port`     | Puerto del servidor MySQL                 | `3306`                    |
| `Database` | Nombre de la base de datos                | `tienda_don_pedro`        |
| `Uid`      | Usuario de la base de datos               | `root`                    |
| `Pwd`      | Contrasena del usuario                    | *(vacio)*                 |

---

## Ejecucion en Local

1. Establece **`COMPLETE_FLAT_UI`** como proyecto de inicio (Startup Project) en Visual Studio.
2. Presiona `F5` o el boton Iniciar para compilar y ejecutar la aplicacion.

```bash
# Alternativamente, desde la terminal con MSBuild
msbuild ProyectoVS_TiendaDonPedro/TiendaDonPedro.sln /p:Configuration=Debug
```

---

## Ejemplos de Uso Rapido

### Inicio de sesion

Al ejecutar la aplicacion, se mostrara el formulario de Login (`FrmLogin`), donde el usuario debe ingresar su alias registrado en la base de datos.

**Entrada:**

```text
Alias de usuario: admin
```

**Salida esperada:**

```text
Sesion iniciada correctamente.
Bienvenido al Menu Principal - Rol: Administrador
```

---

## Diagrama de Flujo del Proyecto

A continuacion se muestra un diagrama (ASCII) que representa el flujo general de la aplicacion, desde el inicio de sesion hasta la persistencia de datos y generacion de reportes.

```
                          +---------------------------+
                          |         FrmLogin           |
                          |     (Inicio de Sesion)     |
                          +--------------+--------------+
                                         |
                                         | Valida alias / password
                                         v
                          +---------------------------+
                          |   Base de Datos MySQL       |
                          |   tabla: tbl_usuario         |
                          +--------------+--------------+
                                         |
                            Credenciales validas
                                         v
                          +---------------------------+
                          |      FrmMenuPrincipal       |
                          |       (Menu Principal)      |
                          +----+------+------+------+----+
                               |      |      |      |
              +----------------+      |      |      +----------------+
              |                       |      |                       |
              v                       v      v                       v
   +-------------------+   +-------------------+   +-------------------+   +-------------------+
   |   FrmCategorias    |   |   FrmProductos     |   |   FrmClientes      |   |   FrmUsuarios      |
   |  (CRUD Categorias) |   |  (CRUD Productos)  |   |  (CRUD Clientes)   |   |  (CRUD Usuarios)   |
   +----------+--------+   +----------+--------+   +----------+--------+   +----------+--------+
              |                       |                       |                       |
              +-----------+-----------+-----------+-----------+
                                       |
                                       v
                          +---------------------------+
                          |      FrmFacturaEnc           |
                          |  (Facturacion de Ventas)      |
                          +--------------+--------------+
                                         |
                                         v
                          +---------------------------+
                          |   Base de Datos MySQL       |
                          |   tbl_facturaventa            |
                          |   tbl_detallefactura           |
                          +--------------+--------------+
                                         |
                                         v
                          +---------------------------+
                          |   Exportacion de Reportes    |
                          |       (Excel - EPPlus)        |
                          +---------------------------+
```

### Resumen del flujo

1. El usuario inicia sesion en `FrmLogin`, validandose contra la tabla `tbl_usuario` en MySQL.
2. Tras la autenticacion, se carga `FrmMenuPrincipal`, punto central de navegacion.
3. Desde el menu principal se accede a los modulos de gestion: Categorias, Productos, Clientes y Usuarios, todos con operaciones CRUD sobre sus respectivas tablas.
4. La informacion de productos y clientes alimenta el modulo de Facturacion (`FrmFacturaEnc`), donde se registran las ventas.
5. Cada venta se almacena en `tbl_facturaventa` y `tbl_detallefactura`.
6. Finalmente, los datos pueden exportarse a reportes en formato Excel mediante EPPlus.

---

## Guia Rapida para Contribuir

Las contribuciones son bienvenidas. Para colaborar con el proyecto:

1. Haz un Fork de este repositorio.
2. Crea una nueva rama para tu funcionalidad o correccion:
```bash
   git checkout -b feature/nueva-funcionalidad
```
3. Realiza tus cambios y haz commit:
```bash
   git commit -m "feat: agrega nueva funcionalidad"
```
4. Sube tus cambios a tu fork:
```bash
   git push origin feature/nueva-funcionalidad
```
5. Abre un Pull Request describiendo los cambios realizados.

Por favor, asegurate de que tu codigo compile correctamente y siga el estilo del proyecto antes de enviar el PR.

---

## Licencia

Este proyecto esta bajo la licencia MIT. Consulta el archivo `LICENSE` para mas detalles.

```
MIT License

Copyright (c) 2025 TiendaDonPedro

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.
```

---

## Contacto / Autores

- **Repositorio:** [github.com/Bhusvnash/TiendaDonPedro](https://github.com/Bhusvnash/TiendaDonPedro)
- **Autor:** [Bhusvnash](https://github.com/Bhusvnash)

Tienes preguntas o sugerencias? Abre un Issue en el repositorio.

<div align="center">

Hecho para la gestion de pequenos negocios.

</div>

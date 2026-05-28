# 🏛️ .NET 8 API with Design Patterns

Este repositorio contiene una **Web API RESTful** desarrollada en **.NET 8 (C# 12)**. El objetivo principal de este proyecto es servir como referencia técnica y plantilla para la implementación de buenas prácticas de desarrollo, arquitectura limpia (Clean Architecture) y patrones de diseño empresariales en el ecosistema de Microsoft.

---

## 🧩 Patrones de Diseño Implementados

Este proyecto no es solo un CRUD básico; está diseñado para ser escalable, mantenible y altamente testeable mediante la aplicación de los siguientes patrones:

* **Repository Pattern:** Abstracción de la capa de acceso a datos para desacoplar la lógica de negocio del ORM (Entity Framework Core).
* **Unit of Work:** Gestión centralizada de transacciones para asegurar la integridad de los datos al guardar múltiples repositorios en una sola operación.
* **CQRS (Command and Query Responsibility Segregation):** Separación de las operaciones de lectura (Queries) y escritura (Commands) para optimizar el rendimiento y la escalabilidad.
* **Mediator Pattern:** (Usualmente a través de MediatR) para reducir el acoplamiento entre los componentes, enviando comandos y consultas a sus respectivos manejadores.
* **Dependency Injection (DI):** Gestión nativa del ciclo de vida de los servicios (Transient, Scoped, Singleton) para facilitar el testing y el mantenimiento.

---

## 🚀 Instrucciones de Ejecución

### 📋 Requisitos previos
* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Un IDE compatible (Visual Studio 2022, VS Code, o JetBrains Rider)
* *(Opcional)* SQL Server o Docker si el proyecto utiliza una base de datos relacional externa (revisar la cadena de conexión en `appsettings.json`).

### 💻 Pasos para ejecutar localmente

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/julhr7/net8_api_with_patterns.git](https://github.com/julhr7/net8_api_with_patterns.git)
   ```

2. **Navegar a la carpeta raíz del proyecto:**
   ```bash
   cd net8_api_with_patterns
   ```

3. **Restaurar dependencias y herramientas:**
   ```bash
   dotnet restore
   ```

4. **Ejecutar migraciones de base de datos** *(Si aplica Entity Framework Core):*
   ```bash
   dotnet ef database update
   ```

5. **Lanzar la API:**
   ```bash
   dotnet run --project <NombreDelProyecto.Api>
   ```
   *(Nota: Reemplaza `<NombreDelProyecto.Api>` con el nombre exacto de la carpeta/proyecto donde reside tu archivo `Program.cs`)*

---

## 📖 Interacción con la API

Una vez que la aplicación esté en ejecución, puedes explorar y probar los endpoints fácilmente utilizando la interfaz de **Swagger/OpenAPI** que viene integrada. 

* Abre tu navegador y dirígete a: `https://localhost:<puerto>/swagger`
* Desde allí podrás ver la documentación de la API, los modelos de datos (Schemas) y ejecutar peticiones HTTP directamente.

---

## 🧪 Pruebas (Testing)

La arquitectura utilizada en este proyecto está diseñada para ser altamente testeable. Para ejecutar la suite de pruebas unitarias y de integración, abre una terminal en la raíz de la solución y ejecuta:

```bash
dotnet test
```

---

## 🛠️ Stack Tecnológico

* **Framework:** .NET 8 Web API
* **Lenguaje:** C# 12
* **ORM:** Entity Framework Core
* **Librerías destacadas:** MediatR, AutoMapper, FluentValidation, xUnit/Moq *(Ajustar según las librerías reales de tu proyecto)*
* **Documentación:** Swashbuckle (Swagger)

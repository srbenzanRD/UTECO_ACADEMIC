# Universidad Tecnológica del Cibao Oriental 
# Programa de clase: Lenguaje de Programación III (IRI-005)

**Asignatura:** Lenguaje de Programación III  
**Tecnología:** .NET 8, Blazor Server, EF Core, SQL Server  
**Docente:** https://www.felixbenzan.com.do  

---

## 🎯 Objetivo General
Desarrollar aplicaciones web robustas bajo una arquitectura de servicios, dominando el acceso a datos con EF Core y la creación de interfaces interactivas con Blazor Server, aplicando estándares de seguridad y buenas prácticas de la industria.

---

## 📊 Sistema de Evaluación (Teoría)
- **Primer Parcial (Semana 4):** 15 Pts.
- **Segundo Parcial (Semana 8):** 15 Pts.
- **Examen Final (Semana 11):** 30 Pts.
- **Total Teoría:** 60 Pts.

## 💻 Sistema de Evaluación (Laboratorio)
- **Hito 1: Capa de Datos (Semana 4):** 10 Pts.
- **Hito 2: CRUD Funcional (Semana 8):** 15 Pts.
- **Hito 3: Proyecto Final con Seguridad (Semana 11):** 15 Pts.
- **Total Laboratorio:** 40 Pts.

---

## 📅 Cronograma Semanal

### Módulo 1: Arquitectura y Capa de Datos (Semanas 1-4)

#### Semana 1: Introducción y Ecosistema .NET
- **Teoría (Lunes):** Arquitectura cliente-servidor vs. Blazor Server. Inyección de Dependencias (DI) como estándar de desacoplamiento.
- **Laboratorio (Mar/Mié):** Configuración de entorno (SDK, SQL Express, VS 2022). Creación de solución multi-capa.
- **Tarea:** Investigar el ciclo de vida de una solicitud en Blazor Server.

#### Semana 2: Entity Framework Core (Code First)
- **Teoría (Lunes):** El patrón ORM. Modelado de Entidades, Data Annotations y Fluent API.
- **Laboratorio (Mar/Mié):** Creación del `DbContext`. Configuración de `ConnectionString` en `appsettings.json`. Primera migración.
- **Tarea:** Crear el diagrama ER del proyecto individual.

#### Semana 3: El Patrón Repository y LINQ
- **Teoría (Lunes):** Abstracción de datos. Consultas avanzadas con LINQ (Where, Select, Include, Join).
- **Laboratorio (Mar/Mié):** Implementación de una interfaz `IRepository` y su servicio concreto. Consultas a la base de datos desde código.
- **Tarea:** Implementar métodos de búsqueda y filtrado en el repositorio.

#### Semana 4: Evaluación I
- **Teoría (Lunes):** **PRIMER PARCIAL (15 pts)** - Conceptos de DI, ORM y EF Core.
- **Laboratorio (Mar/Mié):** **ENTREGA HITO 1 (10 pts)**: Base de datos creada mediante migraciones y servicios de acceso a datos probados.

---

### Módulo 2: Interfaz de Usuario e Interactividad (Semanas 5-8)

#### Semana 5: Componentes Razor y Ciclo de Vida
- **Teoría (Lunes):** Anatomía de un componente. Parámetros (`[Parameter]`) y Eventos (`EventCallback`). Concepto de "State Management" básico.
- **Laboratorio (Mar/Mié):** Creación de componentes reutilizables (Botones, Tablas, Alertas). Uso de Layouts.
- **Tarea:** Crear un componente de "Card" genérico para mostrar datos.

#### Semana 6: Formularios y Validaciones
- **Teoría (Lunes):** Manejo de formularios en Blazor (`EditForm`). DataAnnotationsValidator y ValidationSummary.
- **Laboratorio (Mar/Mié):** Creación de pantallas de "Nuevo" y "Editar". Manejo de mensajes de error de usuario.
- **Tarea:** Implementar validaciones personalizadas (ej. Cédula dominicana o RNC).

#### Semana 7: Relaciones y Complejidad en la UI
- **Teoría (Lunes):** Manejo de relaciones 1:N en la UI (Dropdowns vinculados). Introducción a los DTOs (Data Transfer Objects).
- **Laboratorio (Mar/Mié):** CRUD complejo con llaves foráneas. Uso de `InputSelect` para vincular tablas (ej. Producto -> Categoría).
- **Tarea:** Refactorizar el CRUD para usar DTOs en lugar de entidades directas.

#### Semana 8: Evaluación II
- **Teoría (Lunes):** **SEGUNDO PARCIAL (15 pts)** - Ciclo de vida de componentes, eventos y validaciones.
- **Laboratorio (Mar/Mié):** **ENTREGA HITO 2 (15 pts)**: CRUD completo y funcional (Listar, Crear, Editar, Eliminar) con persistencia en SQL Server.

---

### Módulo 3: Seguridad y Calidad de Software (Semanas 9-11)

#### Semana 9: Autenticación con ASP.NET Core Identity
- **Teoría (Lunes):** Conceptos de Identidad: Claims, Roles y Cookies de sesión. Seguridad a nivel de protocolo.
- **Laboratorio (Mar/Mié):** Instalación de Identity. Creación de formularios de Registro y Login personalizados.
- **Tarea:** Configurar políticas de contraseña (mínimo de caracteres, símbolos).

#### Semana 10: Autorización y Roles
- **Teoría (Lunes):** Protección de rutas con `[Authorize]`. Uso del componente `AuthorizeView` para UI condicional.
- **Laboratorio (Mar/Mié):** Restricción de acceso: Solo "Admin" puede eliminar; "User" solo puede ver. Ocultar elementos del menú según el rol.
- **Tarea:** Implementar un Middleware de manejo de errores o página de error 404 personalizada.

#### Semana 11: Evaluación Final
- **Teoría (Lunes):** **EXAMEN FINAL (30 pts)** - Integración de todos los módulos.
- **Laboratorio (Mar/Mié):** **PRESENTACIÓN PROYECTO FINAL (15 pts)**: Aplicación completa, segura y bajo arquitectura de capas.

---

## 🛠️ Stack Tecnológico Sugerido
- **Editor:** Visual Studio 2022 0 2026 (Community)
- **Runtime:** .NET 8.0
- **Base de Datos:** Archivo de base de datos (SQL Server o SQLite)
- **Control de Versiones:** Git + GitHub
- **Diseño:** Bootstrap 5 (Integrado en Blazor)

---

## 📌 Notas para el Estudiante
1. Las clases teóricas son la base para el diseño lógico; el laboratorio es para la implementación técnica.
2. Es obligatorio el uso de **Git** para todas las entregas de laboratorio.
3. Se evaluará la **limpieza del código** y el uso de estándares de nombrado (CamelCase vs PascalCase).

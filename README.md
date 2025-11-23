# Laboratorios-de-Computo

# Gestión de Reservas – Laboratorios de Cómputo (ASP.NET Core MVC)

Este proyecto es una aplicación web desarrollada en **ASP.NET Core MVC** que permite registrar y visualizar reservas de laboratorios de cómputo en un campus universitario. La solución implementa el patrón MVC, validaciones en servidor, almacenamiento en memoria y vistas para crear y listar reservas.

---

## Objetivo General

Desarrollar una aplicación web que gestione las reservas hechas por profesores para el uso de laboratorios de cómputo, validando los datos y almacenándolos temporalmente en memoria.

---

## Historia del Cliente – *“Laboratorios CampusTech”*

El departamento de tecnología administra varios laboratorios y necesita un sistema para:

* Registrar reservas realizadas por profesores.
* Ver un listado organizado de todas las reservas.
* Garantizar validaciones correctas para evitar errores o datos inconsistentes.

Laboratorios disponibles:

* **Lab-01, Lab-02, Lab-03, Lab-Redes, Lab-IA**

---

## Funcionalidades principales

* Registrar nuevas reservas mediante un formulario.
* Validar datos tanto con anotaciones (DataAnnotations) como manualmente en el servidor.
* Guardar todas las reservas en una lista en memoria.
* Mostrar el listado completo en una tabla ordenada por fecha y hora.
* Prevenir duplicación del código de reserva.

---

## Datos solicitados en el formulario

Cada reserva debe contener:

* Nombre del profesor.
* Correo institucional (@campus.edu).
* Laboratorio.
* Fecha de la reserva.
* Hora de inicio.
* Hora de fin.
* Motivo o descripción.
* Código de reserva (formato **RES-###**).

---

## Validaciones implementadas

### Nombre del profesor

* Obligatorio.
* Mínimo 3 caracteres.

### Correo institucional

* Obligatorio.
* Formato de correo válido.
* Debe ser del dominio **@campus.edu**.

### Laboratorio

* Obligatorio.
* Debe ser uno de los valores válidos.
* No se permite la opción "Seleccione...".

### Fecha de la reserva

* Obligatoria.
* No se permite una fecha en el pasado.

### Hora de inicio / fin

* Ambas obligatorias.
* **HoraFin > HoraInicio**.
* No se permiten reservas de duración cero o negativa.

### Motivo

* Obligatorio.
* Mínimo 5 caracteres.
* Máximo 200 caracteres.

### Código de reserva

* Obligatorio.
* Formato **RES-###**.
* Debe ser único (validación manual).

---

## Estructura del proyecto

```
GestionReservas/
├─ Controllers/
│  └─ ReservationsController.cs
├─ Models/
│  └─ Reservation.cs
├─ Data/
│  └─ InMemoryReservationRepository.cs
├─ Views/
│  └─ Reservations/
│     ├─ Index.cshtml
│     └─ Create.cshtml
├─ Program.cs
└─ wwwroot/
```

---

## Tecnologías utilizadas

* **ASP.NET Core MVC** (C#)
* Inyección de dependencias (DI)
* Listas en memoria como almacenamiento temporal
* Bootstrap básico para estilos
* Validaciones con DataAnnotations
* Validaciones manuales en el controlador y repositorio

---

## Cómo ejecutar el proyecto

1. Abrir la solución en **Visual Studio 2022**.
2. Asegurarse de tener instalado:

   * .NET 6 o superior.
3. Ejecutar con **F5** o "Run".
4. Por defecto se abrirá la ruta:

   ```
   /Reservations/Index
   ```

---

## Vistas incluidas

### **Index**

* Muestra una tabla con todas las reservas ordenadas por fecha y hora.

### **Create**

* Formulario para agregar nuevas reservas con validación integrada.

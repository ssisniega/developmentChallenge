# 🧮 Development Challenge — Refactor de Reporte de Formas

Este proyecto corresponde a la resolución del desafío técnico solicitado, cuyo objetivo es refactorizar una solución existente que genera un reporte HTML a partir de una lista de figuras geométricas.

---

## 🎯 Objetivos del refactor

- ✅ Aplicar principios de **programación orientada a objetos** 
- ✅ Facilitar la **extensibilidad** para nuevos idiomas y formas
- ✅ Separar responsabilidades usando **interfaces claras**
- ✅ Mejorar legibilidad, mantenibilidad y testabilidad

---

## ⚙️ Cambios principales aplicados

- ✨ Se eliminaron los `switch` y estructuras rígidas
- 🧱 Se implementaron interfaces `IFormaGeometrica` y `ITraductor`
- 🌐 Se separó la lógica de generación del reporte en `ReporteFormasHelper`
- 🗣️ Se agregaron traductores para **Castellano**, **Inglés** e **Italiano**
- 📐 Se agregaron nuevas figuras geométricas:
  - `Rectángulo`
  - `Trapecio`

---

## 🌍 Idiomas soportados

| Código         | Idioma     |
|----------------|------------|
| Castellano     | Español 🇪🇸 |
| Ingles         | English 🇬🇧 |
| Italiano       | Italiano 🇮🇹 |

---

## 🧮 Figuras geométricas soportadas

- Cuadrado
- Círculo
- Triángulo equilátero
- Rectángulo
- Trapecio

Cada una implementa su propia lógica de cálculo de área, perímetro y pluralización.

---

## 🧪 Tests unitarios

- ✔️ Se conservaron **todos los tests originales** (adaptados al nuevo diseño)
- ➕ Se agregaron más de 30 nuevos tests cubriendo:
  - ✔️ Listas vacías
  - ✔️ Una figura en cada idioma
  - ✔️ Múltiples figuras en cada idioma
  - ✔️ Validación de contenido HTML exacto
- ✔️ Todos los tests pasan correctamente ✅

---

## 🛠 Requisitos

- Visual Studio 2022 (matuvimos compatibilidad con C# 7.3)
- .NET Framework 4.8
- NUnit y NUnit3TestAdapter instalados vía NuGet
- Compatible con Windows, multiplataforma si se recompila en .NET Core

---

## ▶️ Cómo ejecutar los tests

1. Abrir la solución en Visual Studio 2022
2. Asegurar que esté seleccionado el proyecto `DevelopmentChallenge.Tests.Refactor`
3. Ir al menú **Test > Run All Tests** o presionar `Ctrl + R, A`
4. Verificar que todos los tests finalicen exitosamente ✅

---

## 📝 Notas técnicas

- Se estandarizó el uso de `\n` como salto de línea en `ReporteFormasHelper` para evitar errores en asserts por diferencias de sistema operativo
- Los valores numéricos se normalizan con punto decimal para consistencia en todos los idiomas
- El proyecto fue migrado a Visual Studio 2022 por estabilidad de entorno y soporte actualizado

---

## 📎 Repositorio

🔗 Podés acceder al código fuente en este repositorio:

👉 [https://github.com/ssisniega/DevelopmentChallenge](https://github.com/tuusuario/DevelopmentChallenge)

---

## 🙌 Gracias

Gracias por la oportunidad de participar del proceso técnico. Espero que este refactor refleje buenas prácticas y compromiso con la calidad del software.


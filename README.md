# 🎲 Juego de Adivinanza: ¡Adivina el Número! 🎲

**Un sencillo y entretenido juego de consola en C# donde el reto es adivinar un número aleatorio. ¿Podrás acertar en el menor número de intentos?**

## 📜 Descripción

Este juego genera un número aleatorio entre 1 y 10 y desafía al usuario a adivinarlo. Cada intento fallido recibe una pista: si el número es más alto o más bajo. El juego sigue hasta que el usuario acierta, mostrando al final la cantidad de intentos realizados.

### 🚀 Ejemplo de ejecución

```plaintext
Adivina un número entre 1 y 10:
Introduce tu intento: 3
El número es mayor. Intenta de nuevo.
Introduce tu intento: 8
El número es menor. Intenta de nuevo.
Introduce tu intento: 7
¡Felicidades! Adivinaste el número 7 después de 3 intentos.
```
## 🎮 Cómo jugar

   1. Clona el repositorio:
      ```plaintext
      git clone https://github.com/javis17/Numeros-Aleatorios-en-c-
      ```
   2. Abre el proyecto en tu entorno de desarrollo (recomendado: Visual Studio).
   3. Ejecuta el juego y sigue las instrucciones en la consola.
   4. Ingresa tus intentos hasta que adivines el número. ¡Cada pista te acerca a la respuesta!

## ⚙️ Requisitos
   - .NET SDK 6.0 o superior.

## 🛠️ Estructura del Código
   - Generación de número aleatorio: Se usa Random para crear un número entre 1 y 10.
   - Bucle do-while: Repite el juego hasta que el usuario adivine el número.
   - Contador de intentos: Lleva la cuenta de cuántas veces intentaste adivinar.

## 🧩 Ideas de Mejora
  - Ampliar el rango de números para hacerlo más desafiante.
  - Agregar niveles de dificultad con rangos de números y cantidad de intentos limitada.
  - Implementar un sistema de puntaje para registrar el menor número de intentos.

## 🤝 Contribuciones
¡Contribuciones son bienvenidas! Si tienes ideas para mejorar el juego, abre un *issue* o envía un *pull request*.

## 📄 Licencia
Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo `LICENSE` para más detalles.

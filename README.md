## Índice de Demostraciones
1. [Configuraciones de Rigidbody y Collider](#1-configuraciones-de-rigidbody-y-collider)
2. [Controlador de Cilindro con Físicas](#2-controlador-de-cilindro-con-físicas)
3. [Colisiones con Registro y Cambio de Color](#3-colisiones-con-registro-y-cambio-de-color)
4. [Persecución de Objetivo con Obstáculo Reactivo](#4-persecución-de-objetivo-con-obstáculo-reactivo)

---

### 1. Configuraciones de Rigidbody y Collider
* **Descripción:** En Unity, el comportamiento físico de los objetos depende de la combinación de `Collider`, que detecta colisiones geométricas, y `Rigidbody`, que aplica leyes físicas como gravedad, masa y fuerzas.

* **Situación 1:** Plano con `Collider`, cubo con `Rigidbody` y esfera con `Collider`.
  * **Resultado:** En la configuración mostrada, el cubo está ligeramente dentro del plano, por lo que su Rigidbody resuelve la colisión empujándolo hacia fuera. Si no fuera asi, el objeto caería debido a la gravedad y se detiene al chocar contra el plano. La esfera, al no tener `Rigidbody`, es un objeto estático y no le afecta la gravedad.

> ![Situación 1](./Assets/Media/p1_1.gif)

* **Situación 2:** Plano con `Collider`, cubo y esfera con `Rigidbody` dinámico.
  * **Resultado:** Tanto el cubo como la esfera caen por la acción de la gravedad. Colisionan físicamente entre ellos y contra el plano.

> ![Situación 2](./Assets/Media/p1_2.gif)

* **Situación 3:** Plano con `Collider`, cubo con `Rigidbody` y esfera con `Rigidbody` cinemático.
  * **Resultado:** El cubo cae y choca contra el plano. La esfera, al ser cinemática (`isKinematic = true`), ignora la gravedad y las fuerzas externas; sin embargo, conserva su colisionador activo y actúa como un obstáculo sólido inamovible, salvo que se mueva mediante código con `transform.position` o `MovePosition`.

> ![Situación 3](./Assets/Media/p1_3.gif)

* **Situaciones con variación de masa (10x y 100x más masa):** Plano, cubo y esfera físicos.
  * **Resultado:** Según la segunda ley de Newton (\(F = ma\)) y la conservación del momento lineal, al aumentar la masa de la esfera a 10 o 100 veces la del cubo, su inercia aumenta considerablemente. Al chocar contra el cubo, la esfera apenas sufre desvíos o pérdida de velocidad, mientras que el cubo sale despedido con mayor fuerza y velocidad.

> ![Situación 4](./Assets/Media/p1_4.gif)

> ![Situación 5](./Assets/Media/p1_5.gif)

> ![Situación 5](./Assets/Media/p1_5-2.gif)

> ![Situación 5](./Assets/Media/p1_5-3.gif)

* **Plano cinemático y fricción (`Physics Material`):** Plano cinemático, cubo físico y esfera física con fricción.
  * **Resultado:** Un plano cinemático no se desplaza ante impactos externos y actúa como un suelo firme controlado por código. La fricción definida mediante un `Physics Material` regula la resistencia al deslizamiento: un valor alto frena rápidamente al cubo y a la esfera, mientras que un valor bajo genera una superficie resbaladiza, similar al hielo.

> ![Situación 6](./Assets/Media/p1_6.gif)

* **Esfera como `Trigger` (`IsTrigger = true`):** Plano cinemático, cubo físico y esfera sin física o física marcada como `Trigger`.
  * **Resultado:** Con `IsTrigger` activado, la esfera pierde su colisión sólida de rebote. Los objetos pueden atravesarla, pero el motor de físicas detecta la entrada, permanencia y salida mediante eventos como `OnTriggerEnter`, `OnTriggerStay` y `OnTriggerExit`. Esto permite utilizarla como zona de activación, sensor, portal o sistema de recolección de objetos.

> ![Situación 7](./Assets/Media/p1_7.gif)

> ![Situación 8](./Assets/Media/p1_8.gif)

---

### 2. Controlador de Cilindro con Físicas
* **Descripción:** Control en tiempo de ejecución de un cilindro mediante las flechas de dirección, aplicando fuerzas a su `Rigidbody` para obtener un movimiento basado en físicas.

> ![Ejecución Ejercicio 2](./Assets/Media/p2.gif)

---

### 3. Colisiones con Registro y Cambio de Color
* **Descripción:** Varios cubos y esferas con `Rigidbody` dinámico detectan colisiones mediante `OnCollisionEnter`, mostrando por consola el nombre del objeto impactado y modificando aleatoriamente su color.

> ![Ejecución Ejercicio 3](./Assets/Media/p3.gif)

---

### 4. Persecución de Objetivo con Obstáculo Reactivo
* **Descripción:** Una esfera con `Rigidbody` se dirige hacia un cilindro cinemático marcado como objetivo. Al colisionar con el cubo que actúa como obstáculo, este cambia de material y avanza hacia adelante.

> ![Ejecución Ejercicio 4](./Assets/Media/p4.gif)

---

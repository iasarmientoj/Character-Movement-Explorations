# Character-Movement-Explorations
Este repositorio contiene una serie de exploraciones y pruebas relacionadas con diversas formas de mover un personaje en Unity. Se incluyen implementaciones de diferentes mecánicas de movimiento para personajes en entornos 2D y 3D.

---

## Anotaciones escenas
### Scene 1

<details><summary><i>Tutoriales guía:</i></summary>

- [FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial](https://www.youtube.com/watch?v=f473C43s8nE)

</details>

_Descripción:_ Movimiento básico en primera persona para PC con mouse y teclas WASD.

![Scene 1](/CME/Assets/Scenes/miniaturas/Scene%201.png "Scene 1")

[![First-Person Movement System in Unity](/CME/Assets/Scenes/miniaturas/Scene%201yt.jpg)](https://youtu.be/gsb55bVfXGU)


_Detalles:_
- Orientación de cámara controlada con el mouse.
- Movimiento sobre el plano X,Z añadiendo fuerza al Rigidbody del personaje.
- Drag en la detección de suelo con raycast.
- Velocidad máxima limitada a un valor fijo.
- Salto con fuerza de impulso vertical en el Rigidbody.
- Comportamiento del movimiento ligeramente diferente en el salto.



### Scene 2
<details><summary><i>Tutoriales guía:</i></summary>

- [Basic Third Person Character Controller in Unity - Unity C# Tutorial 2022](https://www.youtube.com/watch?v=cEqjkubspGo)

</details>

_Descripción:_ Movimiento básico en tercera persona **(usando Rigidbody)** para PC con teclas WASD y animaciones.

![Scene 2](/CME/Assets/Scenes/miniaturas/Scene%202.png "Scene 2")

[![Third-Person Character Movement in Unity](/CME/Assets/Scenes/miniaturas/Scene%202yt.jpg)](https://youtu.be/NzED5H33hPo)

_Detalles:_
- Movimiento de desplazamiento con velocity en el Rigidbody.
- Rotación del personaje rotando su transform.
- Animaciones de idle, walk, run, walkback.
- Solucionados giros estando en idle.
- Solucionado bug al dejar de presionar W antes que Shift al correr.
- Por mejorar: complejidad del Animator.
- Por mejorar: la combinación de teclas en el movimiento causa varios bugs.



### Scene 3 ⭐
<details><summary><i>Tutoriales guía:</i></summary>

- [SCRIPT De MOVIMIENTO Para JUEGOS En TERCERA PERSONA Con UNITY 3D](https://www.youtube.com/watch?v=ffs_dI6gzyQ)
- [Como Hacer TRANSICIONES Entre ANIMACIONES En UNITY 3D](https://www.youtube.com/watch?v=NhEN9rAU2_w)
- [Como Utilizar BLEND TREES En UNITY Para Combinar ANIMACIONES](https://www.youtube.com/watch?v=1qYXd7eCQss)

</details>

_Descripción:_ Movimiento básico en tercera persona **(usando CharacterController)** para PC con teclas WASD y animaciones.

_Destacable:_ Animator organizado.

![Scene 3](/CME/Assets/Scenes/miniaturas/Scene%203.png "Scene 3")

[![Third-person character movement system in Unity using CharacterController and organized animations](/CME/Assets/Scenes/miniaturas/Scene%203yt.jpg)](https://youtu.be/cEQbxtYwGEw)

_Detalles:_
- Movimiento de desplazamiento con Move en el CharacterController.
- Se mueve en relación a donde esté mirando la cámara principal.
- Se aplica gravedad en el código.
- El personaje gira en el sentido del movimiento con rotación suavizada.
- Animator con Blend Trees.



### Scene 4
<details><summary><i>Tutoriales guía:</i></summary>

- [UNITY 3D PLAYER MOVEMENT in 2 MINUTES! FPS Shooter](https://www.youtube.com/watch?v=1uW-GbHrtQc)

</details>

_Descripción:_ Sistema de movimiento en primera persona **(usando CharacterController)** para PC con teclas WASD.

![Scene 4](/CME/Assets/Scenes/miniaturas/Scene%204.png "Scene 4")

[![First-person movement system in Unity using CharacterController with walking, running, jumping, and crouching features](/CME/Assets/Scenes/miniaturas/Scene%204yt.jpg)](https://youtu.be/ImpIO2B_9Q8)

_Detalles:_
- Script tomado del tutorial.
- Función de caminar, correr, saltar, agacharse y aplicar gravedad.
- Movimiento de desplazamiento con Move en el CharacterController.
- El personaje gira en el sentido del movimiento con rotación.



### Scene 5 ⭐
<details><summary><i>Tutoriales guía:</i></summary>

- [THIRD PERSON MOVEMENT in 11 MINUTES - Unity Tutorial](https://www.youtube.com/watch?v=UCwwn2q4Vys)

</details>

_Descripción:_ Sistema de movimiento con cinemachine en tercera persona (usando Rigidbody) para PC con teclas WASD.

_Destacable:_ Sistema de cámara tercera persona muy bien, con cinemachine y no atraviesa paredes.

![Scene 5](/CME/Assets/Scenes/miniaturas/Scene%205.png "Scene 5")

[![Third-person movement system in Unity with Cinemachine for smooth camera control and wall collision](/CME/Assets/Scenes/miniaturas/Scene%205yt.jpg)](https://youtu.be/yPbZFs6GX_0)

_Detalles:_
- Script tomado del tutorial.
- Con Rigidbody.
- Función de caminar, correr, saltar y agacharse.
- El personaje gira en el sentido del movimiento con rotación.
- La cámara no atraviesa paredes.
- Varios tipos de cámara: exploración, combate y topdown.



### Scene 6
<details><summary><i>Tutoriales guía:</i></summary>

- [How To Make An FPS Player In Under A Minute - Unity Tutorial](https://www.youtube.com/watch?v=qQLvcS9FxnY)

</details>

_Descripción:_ Movimiento básico en primera persona (usando CharacterController) para PC con teclas WASD.

![Scene 6](/CME/Assets/Scenes/miniaturas/Scene%206.png "Scene 6")

[![First-person movement system in Unity with CharacterController for smooth walking, running, and jumping](/CME/Assets/Scenes/miniaturas/Scene%206yt.jpg)](https://youtu.be/nBTNeh91_tw)

_Detalles:_
- Script tomado del tutorial.
- Con CharacterController.
- Función de caminar, correr y saltar.
- El personaje gira en el sentido del movimiento con rotación.



### Scene 7 ⭐
<details><summary><i>Tutoriales guía:</i></summary>

- [First Person Controller - Basic Movement and Mouse Input (EP01) [Unity Tutorial]](https://www.youtube.com/watch?v=2FTDa14nryI&list=PLfhbBaEcybmgidDH3RX_qzFM0mIxWJa21)
- [First Person Controller - Sprinting (EP02) [Unity Tutorial]](https://www.youtube.com/watch?v=Ew4l5RPltG8&list=PLfhbBaEcybmgidDH3RX_qzFM0mIxWJa21&index=2)
- [First Person Controller - Jumping (EP03) [Unity Tutorial]](https://www.youtube.com/watch?v=1ZnI7gXzQcg&list=PLfhbBaEcybmgidDH3RX_qzFM0mIxWJa21&index=3)
- [First Person Controller - Crouching (EP04) [Unity Tutorial]](https://www.youtube.com/watch?v=-XNm7dPVVOQ&list=PLfhbBaEcybmgidDH3RX_qzFM0mIxWJa21&index=4)
- [First Person Controller - Headbob (EP05) [Unity Tutorial]](https://www.youtube.com/watch?v=_c5IoF1op4E&list=PLfhbBaEcybmgidDH3RX_qzFM0mIxWJa21&index=5)
- [First Person Controller - Slope Sliding (EP06) [Unity Tutorial]](https://www.youtube.com/watch?v=jIsHe9ARE70&list=PLfhbBaEcybmgidDH3RX_qzFM0mIxWJa21&index=6)
- [First Person Controller - Zoom/ADS (EP07) [Unity Tutorial]](https://www.youtube.com/watch?v=hrCLJpDKKKw&list=PLfhbBaEcybmgidDH3RX_qzFM0mIxWJa21&index=7)

</details>

_Descripción:_ Movimiento básico en primera persona, programación "modular".

_Destacable:_ Script de Player muy bien programado, modular y organizado. Se podría adaptar fácilmente a tercera persona y con cámara de cinemachine.

![Scene 7](/CME/Assets/Scenes/miniaturas/Scene%207.png "Scene 7")

[![Modular first-person movement system in Unity with sprint, jump, crouch, and headbob effects](/CME/Assets/Scenes/miniaturas/Scene%207yt.jpg)](https://youtu.be/WAePyiP-_oY)

_Detalles:_
- Implementación modular de scripts.
- Movimiento básico con teclas WASD y rotación con el mouse.
- Sprint al presionar Shift para aumentar la velocidad.
- Salto con detección de suelo y fuerza vertical.
- Agacharse con reducción de altura y velocidad.
- Efecto de headbob al caminar y correr.
- Deslizamiento automático en pendientes inclinadas.
- Zoom para apuntar mejor al presionar un botón.
- Por mejorar, aún se pueden escalar rampas con saltos muy seguidos.



### Scene 8
<details><summary><i>Tutoriales guía:</i></summary>

- [Mobile Third Person Character Controller from Scratch [01/13]](https://www.youtube.com/watch?v=Im4VP_Kuylc&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=2)
- [Unity Mobile Third Person Character Controller [ 02 / 13]](https://www.youtube.com/watch?v=kxaEBCJtBvs&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=2)
- [Unity Third Person Character Controller - Character Setup [03/13]](https://www.youtube.com/watch?v=ItKe1BS1Egk&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=3)
- [Unity Third Person Rotation - Game Mathematics Trigonometry [04/13]](https://www.youtube.com/watch?v=FPkAmEwRMr4&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=4)
- [Mobile Third Person Character Controller - Player Movement [05/13]](https://www.youtube.com/watch?v=qi-dSfrPSCw&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=5)
- [Unity Mobile Third Person Character Controller (Local vs World Space) [ 06 / 13]](https://www.youtube.com/watch?v=UWn0Ap_AkZ8&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=6)
- [Unity Mobile Third person Character Controller - Smoothing Movement [07/13]](https://www.youtube.com/watch?v=wcufT7HaUQM&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=7)
- [Unity Mobile Third person Character Controller - Camera Movement And Rotation [08/13]](https://www.youtube.com/watch?v=U0mghZ3KYJ8&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=8)
- [Unity Third person character Controller - Camera Bounds and Smoothness [09/13]](https://www.youtube.com/watch?v=Dzxs-4MfxfQ&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=9)
- [Unity3d - Third person Character Controller - Player Rotation With Camera [10/13]](https://www.youtube.com/watch?v=ABbHXGLpKz8&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=10)
- [Unity3d - Third person Character Controller - Joystick and touch for mobile [11/13]](https://www.youtube.com/watch?v=DGEJPz5XG2Y&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=11)
- [Unity3d - Third person Character Controller - player Animations and Controllers [12/13]](https://www.youtube.com/watch?v=AuSTcrS2laE&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=12)
- [Unity Third person Character Controller - Player Animator [13/13]](https://www.youtube.com/watch?v=rTbnF3O-ZJQ&list=PLgAF6rpCsTCgSLHAnkd_M793TG3sekY8D&index=13)
- [UNITY REMOTE 5 NOT WORKING? HERE IS MY SETUP TUTORIAL AND CHECKLIST FOR ANDROID AND IOS](https://www.youtube.com/watch?v=L6CkG2sgupA)

</details>

_Descripción:_ Movimiento básico en tercera persona, para móvil, con Joystick descargado.

![Scene 8](/CME/Assets/Scenes/miniaturas/Scene%208.png "Scene 8")

[![Basic Third-Person Mobile Character Controller with Joystick in Unity](/CME/Assets/Scenes/miniaturas/Scene%208yt.jpg)](https://youtu.be/FHHSUN3j2Uc)

_Detalles:_
- Personaje descargado de assetstore.
- Joystick descargado de assetstore.
- Capsule collider + RigidBody.
- Joystick para caminar.
- Boton para saltar.
- Zona para mover la cabeza o mirada.
- Giro suavizado pero "raro".
- Probado en Unity Remote.
- Exportado a Android.



### Scene 9
<details><summary><i>Tutoriales guía:</i></summary>

- [JoyStick In Under 2 Minutes With Unity New Input System](https://www.youtube.com/watch?v=grCToWRfJx4)

</details>

_Descripción:_ Creación de un Joystick con New Input System.

![Scene 9](/CME/Assets/Scenes/miniaturas/Scene%209.png "Scene 9")

[![Mobile Joystick Setup with Unity's New Input System for Basic Player Movement](/CME/Assets/Scenes/miniaturas/Scene%209yt.jpg)](https://youtu.be/pl-8QB-ByV4)

_Detalles:_
- No comprendo del todo cómo funciona este Joystick
- Player sin Rigidbody ni CharacterController.
- Se mueve con transform.Translate.
- Player no gira en la dirección a la que se mueve.
- Probado en Unity Remote.
- Joystick fijo.



### Scene 10
<details><summary><i>Tutoriales guía:</i></summary>

- [How to make Virtual Joystick | Unity in 60 seconds](https://www.youtube.com/watch?v=vBxNwCEb68g)

</details>

_Descripción:_ Creación de Joystick simple.

![Scene 10](/CME/Assets/Scenes/miniaturas/Scene%2010.png "Scene 10")

[![Simple Virtual Joystick Setup for Unity Mobile with Axis Values](/CME/Assets/Scenes/miniaturas/Scene%2010yt.jpg)](https://youtu.be/QkFOiUnCOSc)

_Detalles:_
- Devuelve los valores de -1 a 1 en cada eje.
- Un poco buggeado.



### Scene 11
<details><summary><i>Tutoriales guía:</i></summary>

- [TOUCH CONTROLS in Unity!](https://www.youtube.com/watch?v=bp2PiFC9sSs)

</details>

_Descripción:_ Mover un objeto al lugar donde está tocando la pantalla en 2D.

![Scene 11](/CME/Assets/Scenes/miniaturas/Scene%2011.png "Scene 11")

[![Touch-Based Object Movement in Unity 2D Explained](/CME/Assets/Scenes/miniaturas/Scene%2011yt.jpg)](https://youtu.be/V-DCqgjZ6vU)

_Detalles:_
- Ver rayos del origen a cada toque de la pantalla.



### Scene 12 ⭐
<details><summary><i>Tutoriales guía:</i></summary>

- [Easy character move with mobile joystick in unity | cinemachine| | hyper casual |](https://www.youtube.com/watch?v=sYDq5s1EXiI)

</details>

_Descripción:_ Mover personaje topdown hyper casual games vertical con Joystick.
_Destacable:_ Estilo propio de los juegos hyper casual.

![Scene 12](/CME/Assets/Scenes/miniaturas/Scene%2012.png "Scene 12")

[![Floating Joystick Character Movement for Hyper Casual Games](/CME/Assets/Scenes/miniaturas/Scene%2012yt.jpg)](https://youtu.be/2e6jzJbxllo)

_Detalles:_
- Joystick flotante de la assetstore.
- Animación de idle y run.
- Estilo hyper casual game.



### Scene 13
<details><summary><i>Tutoriales guía:</i></summary>

- [Setup 3D Pathfinding Agents In Minutes Using Unity](https://www.youtube.com/watch?v=mJu-zdZ9dyE)
- [How to use Unity NavMesh Pathfinding! (Unity Tutorial)](https://www.youtube.com/watch?v=atCOd4o7tG4)

</details>

_Descripción:_ Navegación sobre mapa con NavMesh.

![Scene 13](/CME/Assets/Scenes/miniaturas/Scene%2013.png "Scene 13")

[![Simple Navigation with NavMesh and Target Controls](/CME/Assets/Scenes/miniaturas/Scene%2013yt.jpg)](https://youtu.be/zaYJax7nTH4)

_Detalles:_
- Movimiento al apuntar con el ratón.
- Movimiento con objeto Target y presionar espacio.
- Sin animaciones.



### Scene 14 ⭐
<details><summary><i>Tutoriales guía:</i></summary>

- []()

</details>

_Descripción:_ Movimiento básico en primera persona, para móvil, adaptación de Scene 7 con Scene 8.

![Scene 14](/CME/Assets/Scenes/miniaturas/Scene%2014.png "Scene 14")

[![First-Person Mobile Movement with Joystick and Touch Controls](/CME/Assets/Scenes/miniaturas/Scene%2014yt.jpg)](https://youtu.be/E21HWGaz96U)

_Detalles:_
- Adaptación del sistema de movimiento para dispositivos móviles.
- Uso de joystick, para desplazar al personaje.
- Uso de botones con events, para ejecutar acciones: saltar, correr, zoom, agacgarse.
- Uso de touch panel, para rotar la cabeza del personaje.



### Scene 15
<details><summary><i>Tutoriales guía:</i></summary>

- [2D Player Movement In Unity](https://www.youtube.com/watch?v=K1xZ-rycYY8)

</details>

_Descripción:_ Movimiento básico en 2D (RigidBody).

![Scene 15](/CME/Assets/Scenes/miniaturas/Scene%2015.png "Scene 15")

[![Basic 2D Movement with Rigidbody Physics in Unity](/CME/Assets/Scenes/miniaturas/Scene%2015yt.jpg)](https://youtu.be/F8GPEWKNILE)

_Detalles:_
- Implementación de movimiento lateral y salto en 2D.
- Uso de Rigidbody 2D para manejar la física del personaje.
- Sin animaciones.
- Flip dependiendo de la dirección de movimiento.



### Scene 16
<details><summary><i>Tutoriales guía:</i></summary>

- [ULTIMATE 2D Platformer Controller for Unity](https://www.youtube.com/watch?v=zHSWG05byEc)
- [Player Movement - New Input System - Unity Tutorial](https://www.youtube.com/watch?v=zHSWG05byEc)

</details>

_Descripción:_ Movimiento básico en 2D.

![Scene 16](/CME/Assets/Scenes/miniaturas/Scene%2016.png "Scene 16")

[![Advanced 2D Platformer Movement with Unity’s New Input System](/CME/Assets/Scenes/miniaturas/Scene%2016yt.jpg)](https://youtu.be/7EoPCOXwI38)

_Detalles:_
- Uso de New Input System (teclado, mando).
- Movimiento Walk, Run y Jump.
- Salto calculado en script.
- Altura de salto connstante.
- Uso de ScriptableObject.
- Visualización de salto en editor.
- Implementadas mejoras de salto (cima sostenida, salto feura de plataforma, doble salto).



### Scene 17
<details><summary><i>Tutoriales guía:</i></summary>

- []()

</details>

_Descripción:_ Movimiento básico de un auto en 3D.

![Scene 17](/CME/Assets/Scenes/miniaturas/Scene%2017.png "Scene 17")

[![](/CME/Assets/Scenes/miniaturas/Scene%2017yt.jpg)]()

_Detalles:_
- Implementación de controles para un auto en 3D.
- Uso de Rigidbody para simular la física del vehículo.
- Incorporación de animaciones de ruedas y efectos de movimiento.



### Scene 18
<details><summary><i>Tutoriales guía:</i></summary>

- []()

</details>

_Descripción:_ Movimiento básico de un auto en 2D.

![Scene 18](/CME/Assets/Scenes/miniaturas/Scene%2018.png "Scene 18")

[![](/CME/Assets/Scenes/miniaturas/Scene%2018yt.jpg)]()

_Detalles:_
- Implementación de controles para un auto en 2D.
- Movimiento basado en Rigidbody 2D para simular la física.
- Integración de animaciones para el auto y efectos visuales.



### Scene 19
<details><summary><i>Tutoriales guía:</i></summary>

- []()

</details>

_Descripción:_ New Input System.

![Scene 19](/CME/Assets/Scenes/miniaturas/Scene%2019.png "Scene 19")

[![](/CME/Assets/Scenes/miniaturas/Scene%2019yt.jpg)]()

_Detalles:_
- Implementación del nuevo sistema de entrada de Unity.
- Soporte para múltiples dispositivos de entrada (mouse, teclado, controladores).
- Personalización de las entradas para el movimiento del personaje.



### Scene 20
<details><summary><i>Tutoriales guía:</i></summary>

- []()

</details>

_Descripción:_ Implementación de movimientos complementarios en 3D.

![Scene 20](/CME/Assets/Scenes/miniaturas/Scene%2020.png "Scene 20")

[![](/CME/Assets/Scenes/miniaturas/Scene%2020yt.jpg)]()

_Detalles:_
- Movimiento básico (WASD/joystick).
- Salto y doble salto.
- Deslizamiento o "dash".
- Correr y sprintar.
- Movimiento en plataformas.
- Agacharse y deslizarse.
- Nadar.
- Vuelo o levitación.
- Sigilo o "crouch walking".
- Teletransporte.
- Escalar paredes.



### Scene 21
<details><summary><i>Tutoriales guía:</i></summary>

- []()

</details>

_Descripción:_ Implementación de movimientos complementarios en 2D.

![Scene 21](/CME/Assets/Scenes/miniaturas/Scene%2021.png "Scene 21")

[![](/CME/Assets/Scenes/miniaturas/Scene%2021yt.jpg)]()

_Detalles:_
- Movimiento básico (WASD/joystick).
- Salto y doble salto.
- Deslizamiento o "dash".
- Correr y sprintar.
- Movimiento en plataformas.
- Agacharse y deslizarse.
- Nadar.
- Vuelo o levitación.
- Sigilo o "crouch walking".
- Teletransporte.
- Escalar paredes.



---

## Otros conocimientos aplicados
### Creación de personajes 3D
_Descripción:_ Guía para la creación y animación de personajes humanoides 3D con IA. 

1. Crear el prompt en inglés en el [Traductor de google](https://translate.google.com/?hl=es&sl=es&tl=en), ej: detective, brazos extendidos, t pose, estilo 3d, caricatura	
2. Generar la imagen del personaje con [Bing AI](https://www.bing.com/images/create/)
3. Generar el modelo 3D en [Instant Mesh](https://huggingface.co/spaces/TencentARC/InstantMesh) o en [Stable Fast 3D](https://huggingface.co/spaces/stabilityai/stable-fast-3d) o en [Hyperhuman](https://hyperhuman.deemos.com/)
4. Convertir el modelo 3D de glb a fbx en Blender o en este [Convertidor GLB a FBX](https://www.3dpea.com/en/convert/GLB-to-FBX)
5. Animar el personaje en [Mixamo](https://www.mixamo.com/#/)

### Rescatar textura en Blender
_Descripción:_ Guía para texturizado en Blender. 
1. Optimizar la superficie con la herramienta Decimate en Blender: [Blender 3.3 - Decimate Mesh To Lower Poly Count](https://www.youtube.com/watch?v=GrD71-wXrIA)
2. Generar la textura preliminar en Blender: [Blender materials export to GLB/GLTF](https://www.youtube.com/watch?v=2sgKu0bKUwU)

### Arreglar sombras en Android
_Descripción:_ Guía para mejorar calidad de sombras. 
1. En Quality cambi<r Stable Fit a Close Fit. [Pixelated shadow in Android. Any solutions?](https://discussions.unity.com/t/pixelated-shadow-in-android-any-solutions/548966/7)
2. Ir a Graphics > Tier Settings y activar todas las shadow cascades. [Pixelated shadow in Android. Any solutions?](https://discussions.unity.com/t/pixelated-shadow-in-android-any-solutions/548966/7)




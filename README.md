# Character-Movement-Explorations
Este repositorio contiene una serie de exploraciones y pruebas relacionadas con diversas formas de mover un personaje en Unity. Se incluyen implementaciones de diferentes mecánicas de movimiento para personajes en entornos 2D y 3D.

---

## Anotaciones escenas
### Escena - Mov 1
_Descripción:_ Movimiento básico en primera persona para PC con mouse y teclas WASD. 

![Escena - Mov 1](/CME/Assets/Scenes/miniaturas/Mov%201.png "Escena - Mov 1")

_Detalles:_
- Orientación de cámara controlada con el mouse.
- Movimiento sobre el plano X,Z añadiendo fuerza al rb del personanje.
- Drag en la detección de suelo con raycast.
- Velocidad máxima limitada a un valor fijo.
- Salto con fuerza impulso vertical en el rb.
- Comportamiento del movimiento ligeramente diferente en el salto.

_Tutoriales guía:_ 
- [FIRST PERSON MOVEMENT in 10 MINUTES - Unity Tutorial](https://www.youtube.com/watch?v=f473C43s8nE)

### Escena - Mov 2
_Descripción:_ Movimiento básico en tercera persona **(usando rb)** para PC con teclas WASD y animaciones. 
![Escena - Mov 2](/CME/Assets/Scenes/miniaturas/Mov%202.png "Escena - Mov 2")
_Detalles:_
- Movimiento de desplazamiento con velocity en el rb.
- Rotación del personaje rotando su transform.
- Animaciones de idle, walk, run, walkback.
- Solucionado, los giros estando en idle.
- Solucionado, bug al dejar de presionar W antes que Shift al correr.
- Por mejorar, complejidad del Animator.
- Por mejorar, la combinación de teclas en el movimiento causa varios bugs.
_Tutoriales guía:_ 
- [Basic Third Person Character Controller in Unity - Unity C# Tutorial 2022](https://www.youtube.com/watch?v=cEqjkubspGo)

### Escena - Mov 3
_Descripción:_ Movimiento básico en tercera persona **(usando CharacterController)** para PC con teclas WASD y animaciones. 
![Escena - Mov 3](/CME/Assets/Scenes/miniaturas/Mov%203.png "Escena - Mov 3")
_Detalles:_
- Movimiento de desplazamiento con Move en el CharacterController.
- Se mueve en relación hacia donde esté mirando la cámara principal.
- Se aplica gravedad en el código.
- El personaje gira en el sentido del movimiento con rotation, suavizado.
- Animator con Blend Trees.
_Tutoriales guía:_ 
- [SCRIPT De MOVIMIENTO Para JUEGOS En TERCERA PERSONA Con UNITY 3D](https://www.youtube.com/watch?v=ffs_dI6gzyQ)
- [Como Hacer TRANSICIONES Entre ANIMACIONES En UNITY 3D](https://www.youtube.com/watch?v=NhEN9rAU2_w&list=PLiagFqvgGpygMquHIEZDjDMU0fo-WqyX4&index=2)
- [Como Utilizar BLEND TREES En UNITY Para Combinar ANIMACIONES](https://www.youtube.com/watch?v=1qYXd7eCQss)


### Escena - Mov 4
_Descripción:_ Sistema de movimiento en primera persona **(usando CharacterController)** para PC con teclas WASD.
![Escena - Mov 4](/CME/Assets/Scenes/miniaturas/Mov%204.png "Escena - Mov 4")
_Detalles:_
- Script tomado del tutorial.
- Función de caminar, correr, saltar, agacharse, gravedad. 
- Movimiento de desplazamiento con Move en el CharacterController.
- El personaje gira en el sentido del movimiento con rotation.
_Tutoriales guía:_ 
- [UNITY 3D PLAYER MOVEMENT in 2 MINUTES! FPS Shooter](https://www.youtube.com/watch?v=1uW-GbHrtQc)

---

## Otros conocimientos aplicados
### Creación de personajes 3D
_Descripción:_ Guía para la creación y animación de personajes humanoides 3D con IA. 

1. Crear el prompt en inglés en el [Traductor de google](https://translate.google.com/?hl=es&sl=es&tl=en), ej: detective, brazos extendidos, t pose, estilo 3d, caricatura	
2. Generar la imagen del personaje con [Bing AI](https://www.bing.com/images/create/)
3. Generar el modelo 3D en [Instant Mesh](https://huggingface.co/spaces/TencentARC/InstantMesh) o en [Stable Fast 3D](https://huggingface.co/spaces/stabilityai/stable-fast-3d) o en [Hyperhuman](https://hyperhuman.deemos.com/)
4. Convertir el modelo 3D de glb a fbx en Blender o en este [Convertidor GLB a FBX](https://imagetostl.com/convert/file/glb/to/fbx#convert)
5. Animar el personaje en [Mixamo](https://www.mixamo.com/#/)

### Rescatar textura en Blender
_Descripción:_ Guía para texturizado en Blender. 
1. Optimizar la superficie con la herramienta Decimate en Blender: [Blender 3.3 - Decimate Mesh To Lower Poly Count](https://www.youtube.com/watch?v=GrD71-wXrIA)
2. Generar la textura preliminar en Blender: [Blender materials export to GLB/GLTF](https://www.youtube.com/watch?v=2sgKu0bKUwU)
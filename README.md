# Dungeon Crawler Platform 2D

Videojuego de plataformas 2D estilo *dungeon crawler* con estética pixel art, desarrollado en Unity 6 como proyecto académico. El jugador avanza por niveles progresivos derrotando enemigos, recogiendo llaves y atravesando puertas para completar cada mazmorra.

## Características

- **Niveles progresivos**: múltiples niveles con dificultad y enemigos crecientes (Goblins, Faceless Goblins, Goblin Demons).
- **Sistema de HUD**: indicadores de vida, puntuación y posesión de llave mediante TextMeshPro.
- **Mecánica de llave y puerta**: el jugador recoge una llave en el escenario para desbloquear la puerta de salida del nivel.
- **Guardado y carga de partida**: persistencia en archivos JSON que restaura nivel, vida, puntuación y estado de la llave.
- **Menú principal**: nueva partida, cargar partida, opciones y salir.
- **Menú de pausa**: accesible con ESC, detiene el juego (`Time.timeScale = 0`) con fondo semitransparente.
- **Audio**: música de fondo y efectos de sonido para interacciones, con feedback visual y sonoro en los botones.
- **Escena narrativa (StoryScene)**: introducción de la historia con fondos diferenciados por nivel.

## Tecnologías

- **Motor**: Unity 6
- **Lenguaje**: C#
- **UI / Texto**: TextMeshPro
- **Render**: Universal Render Pipeline (URP) 2D
- **Input**: Unity Input System
- **Estética**: Pixel art
- **Persistencia**: Serialización en JSON

## Estructura del proyecto

Assets/
├── Audio/          # Música y efectos de sonido
├── Scenes/         # Niveles, menús, StoryScene, GameOver, Victory
├── Scripts/        # Lógica del juego (C#)
│   └── SaveSystem/ # Sistema de guardado/carga
├── Prefabs/        # Enemigos, puertas, llaves
└── Settings/       # Configuración de render (URP)

## Requisitos

- Unity 6 (o la versión indicada en `ProjectSettings/ProjectVersion.txt`)

## Cómo ejecutar

1. Clonar el repositorio:
```bash
   git clone https://github.com/jorgegrhlm/DungeonCrawlerPlatform2D.git
```
2. Abrir el proyecto desde Unity Hub seleccionando la carpeta del repositorio.
3. Abrir la escena `Assets/Scenes/MainMenu.unity`.
4. Pulsar **Play**.

## Controles

- **Movimiento**: teclas de dirección / WASD
- **Pausa**: ESC

## Autor

Jorge Gómez — [GitHub](https://github.com/jorgegrhlm) · [LinkedIn](https://www.linkedin.com/in/jorge-gomez-1660a128a)

Proyecto desarrollado en el marco del ciclo de Desarrollo de Aplicaciones Multiplataforma (DAM).

# Getting Started with Unity 6 and C# — Example Projects

Practical, chapter-aligned C# scripts that accompany **Getting Started with Unity 6 and C#: Build Your First Game—Even If You’ve Never Written a Line of Code** by **Mowaml Mohammed**. Use these examples to connect concepts to working gameplay fast.

---

## About the Book

🎮 **What If Your First Video Game Could Come to Life This Weekend—in Just 10 Minutes?**

**Getting Started with Unity 6 and C#: Build Your First Game—Even If You’ve Never Written a Line of Code**

Step into game development with a visual-first, hands-on guide that makes coding intuitive, exciting—and yes, totally doable. No jargon. No fluff. Just real results, real fast.  
Start building today. Your future game-dev self will thank you.

🧑‍💻 **Who This Book Is For**
- Aspiring creators eager to turn ideas into real, playable games  
- Hobbyists who want to explore C# within Unity’s powerful visual environment  
- Visual learners who prefer doing over reading endless theory  

🧩 **If you can drag a file, you can build a game. Seriously.**  
“I wrote this for the version of me that once opened Unity, stared at the Scene window, and had no idea what a ‘GameObject’ was.”

❗ **Why Beginners Get Stuck—And How This Book Helps**  
Let’s be real: Unity can feel like a spaceship cockpit, and C# looks like a spellbook written in code. Most beginners:
- Get overwhelmed by panels, settings, and cryptic menus  
- Struggle to connect code with actual gameplay  
- Hit bugs and give up when nothing seems to work  

**This book is your co-pilot. It:**
- Pauses to explain every new concept with clear analogies  
- Leads you through small, rewarding projects (like a spinning cube, 2D jumper, bouncing ball)  
- Shows you where to click, what to type, and why it matters—with annotated screenshots throughout  

📌 **By the end of Chapter One, you'll have a cube spinning on-screen—animated by your very own code.**

🚀 **What You’ll Learn (Step by Step)**
- **Unity Essentials** – Master the Scene View, Hierarchy, Inspector, and Prefabs  
- **C# Programming** – Learn loops, conditionals, variables, and methods, line by line  
- **Player Mechanics** – Build smooth movement, jumping, collisions, and camera follow  
- **Gameplay Systems** – Code a working health bar, lives, score tracker, and inventory  
- **Real Projects** – Use downloadable assets and full source code to build and customize scenes  

🎯 Feel real progress fast—and watch your imagination become playable.

📚 **Chapter Highlights**
- **Welcome to Unity** – Build your first interactive scene and avoid beginner pitfalls  
- **C# Demystified** – Understand `int`, `float`, `Update()`, and everything in between  
- **Player Controls** – Make your player move, jump, and respond to input smoothly  
- **Core Gameplay Systems** – Learn reusable logic for health, scoring, and UI elements  

🎁 Includes free art assets, game templates, and code files you can modify instantly.

🧠 You're not just learning—you’re building your own world.

✨ **Key Features You’ll Love**
- Conversational tone – No cold lectures—just real talk from a friendly teacher  
- “Did You Know?” pro tips – Discover Unity tricks, shortcuts, and best practices  
- Chapter-end quizzes – Test your understanding before you move on  
- Plug-and-play assets – Don’t waste time sourcing graphics—just drop and go  

💡 Imagine showing your friends a game you built this week. Yes, really.

---

## Quick Start

1. **Create or open a Unity 6 project** (2D or 3D depending on the example).  
2. **Copy the example script(s)** from this repo into your project’s `Assets/` folder.  
3. **Attach the script** to a suitable GameObject (e.g., `PlayerController.cs` on a Player).  
4. **Assign public references** in the **Inspector** (targets, speeds, UI elements, etc.).  
5. **Press Play** and iterate.

> **Tip:** If you use the **new Input System**, set **Project Settings → Player → Active Input Handling** to **Both** (or **Input System Package**) and install the package via **Package Manager**.

---

## Requirements

- **Unity 6 (6000.x)** or newer  
- **IDE:** Visual Studio / Rider with C# and Unity tooling  
- **UI:** Built-in `UnityEngine.UI` (Text/Images/Sliders). Some UI examples can be adapted to TextMeshPro.  
- **No third-party packages** required for the scripts in this repository.

---

## Repository Structure

Examples are organized by book chapter. Each example is a minimal script (or small set of scripts) intended to be dropped into a blank scene.

<details>
<summary><strong>Click to view the full tree</strong></summary>

```text
+---Chapter 1 Introduction to Unity and Essential Concepts
|   \---Example 1.1
|           PlayerMovement.cs
|
+---Chapter 2 Fundamentals of C# Programming in Unity
|   +---Example 2.1
|   |       PublicPrivateExample.cs
|   |
|   +---Example 2.10
|   |       ColorChanger.cs
|   |
|   +---Example 2.11
|   |       UImessages.cs
|   |
|   +---Example 2.12
|   |       Spawner.cs
|   |
|   +---Example 2.13
|   |       EnemyState.cs
|   |
|   +---Example 2.14
|   |       TetrominoRotator.cs
|   |
|   +---Example 2.15
|   |       GameDifficultyModes.cs
|   |
|   +---Example 2.16
|   |       CameraMode.cs
|   |
|   +---Example 2.17
|   |       CircleMover.cs
|   |
|   +---Example 2.18
|   |       CircleJumper.cs
|   |
|   +---Example 2.19
|   |       ColorBasedonScore.cs
|   |
|   +---Example 2.2
|   |       intvariable.cs
|   |
|   +---Example 2.20
|   |       HealthBarStates.cs
|   |
|   +---Example 2.21
|   |       PlayerRankBased.cs
|   |
|   +---Example 2.22
|   |       weapontype.cs
|   |
|   +---Example 2.23
|   |       EnemyAI.cs
|   |
|   +---Example 2.24
|   |       Choosing the Firing Power.cs
|   |       Firing the Shell (Using if).cs
|   |       Managing the Shell Lifecycle.cs
|   |       Refining With switch-case.cs
|   |       TankController.cs
|   |
|   +---Example 2.25
|   |       SpawningCoins.cs
|   |
|   +---Example 2.26
|   |       Changing Color on Multiple Enemies.cs
|   |
|   +---Example 2.27
|   |       CountdownTimer.cs
|   |
|   +---Example 2.28
|   |       Disabling All Enemies When Player Dies.cs
|   |
|   +---Example 2.29
|   |       EnemyFlasher.cs
|   |
|   +---Example 2.3
|   |       explorefloat.cs
|   |
|   +---Example 2.30
|   |       CoinCollector.cs
|   |
|   +---Example 2.31
|   |       Countdown.cs
|   |
|   +---Example 2.32
|   |       WaitForInput.cs
|   |
|   +---Example 2.33
|   |       HealthRegen.cs
|   |
|   +---Example 2.34
|   |       Repeated Input Until Valid.cs
|   |
|   +---Example 2.35
|   |       In-Game Menu Loop.cs
|   |
|   +---Example 2.36
|   |       Retry a Dice Roll.cs
|   |
|   +---Example 2.37
|   |       u58.png
|   |       u59.png
|   |       Wheel .png
|   |       WheelSpinner.cs
|   |
|   +---Example 2.38
|   |       EnemyLineController.cs
|   |
|   +---Example 2.39
|   |       DynamicEnemySpawner.cs
|   |
|   +---Example 2.4
|   |       boolvariables.cs
|   |
|   +---Example 2.40
|   |       CoinPickup.cs
|   |       PlayerInventory.cs
|   |
|   +---Example 2.41
|   |       ShopItemDescriptions.cs
|   |
|   +---Example 2.42
|   |       EnemyWaveSpawner.cs
|   |
|   +---Example 2.43
|   |       Undo Building Blocks.cs
|   |
|   +---Example 2.44
|   |       Collectible Tracker.cs
|   |
|   +---Example 2.45
|   |       Heal.cs
|   |
|   +---Example 2.46
|   |       NotificationTester.cs
|   |       UINotificationManager.cs
|   |
|   +---Example 2.47
|   |       EnemyAI.cs
|   |
|   +---Example 2.48
|   |       GreetDelegate.cs
|   |
|   +---Example 2.49
|   |       HealthUI.cs
|   |       Player.cs
|   |
|   +---Example 2.5
|   |       combinetextandvariables.cs
|   |
|   +---Example 2.50
|   |       EnemyDied.cs
|   |
|   +---Example 2.51
|   |       WeaponData.cs
|   |
|   +---Example 2.52
|   |       Weapon.cs
|   |
|   +---Example 2.6
|   |       Example2.6.cs
|   |
|   +---Example 2.7
|   |       StringUIExample.cs
|   |
|   +---Example 2.8
|   |       MouseTracker.cs
|   |
|   \---Example 2.9
|           ObjectTracker.cs
|
+---Chapter 3 Building Basic Player Mechanics and Controls
|   +---Example 3.1
|   |       InputAction.cs
|   |
|   +---Example 3.10
|   |       Following a Player With a Camera.cs
|   |
|   +---Example 3.11
|   |       Technical implementation tip.cs
|   |
|   +---Example 3.12
|   |       Designing for Immediate Stop.cs
|   |
|   +---Example 3.13
|   |       Adding “Friction” to Smooth Stops.cs
|   |
|   +---Example 3.14
|   |       2D Horizontal and Vertical Velocity.cs
|   |
|   +---Example 3.15
|   |       Squash and Stretch.cs
|   |
|   +---Example 3.16
|   |       BouncyBall.cs
|   |
|   +---Example 3.17
|   |       The Collectible Coin.cs
|   |
|   +---Example 3.18
|   |       Bumping Into an Enemy.cs
|   |
|   +---Example 3.19
|   |       Layer Masks.cs
|   |
|   +---Example 3.2
|   |       Physics2DRaycast.cs
|   |
|   +---Example 3.20
|   |       PlayerHealth.cs
|   |
|   +---Example 3.21
|   |       Collecting Coins.cs
|   |
|   +---Example 3.22
|   |       The Quick-and-Dirty Lock-On Camera.cs
|   |
|   +---Example 3.23
|   |       Smooth Camera Follow.cs
|   |
|   +---Example 3.24
|   |       Mathf.Clamp.cs
|   |
|   +---Example 3.25
|   |       Auto-Fitting the Bounds to the Camera View.cs
|   |
|   +---Example 3.26
|   |       look-ahead offset..cs
|   |
|   +---Example 3.27
|   |       look-ahead offset..cs
|   |
|   +---Example 3.3
|   |       Taps.cs
|   |
|   +---Example 3.4
|   |       Swipes.cs
|   |
|   +---Example 3.5
|   |       Cycling Through Your Equipment List.cs
|   |
|   +---Example 3.6
|   |       PlayerController.cs
|   |       VirtualJoystick.cs
|   |
|   +---Example 3.7
|   |       SimpleMover.cs
|   |
|   +---Example 3.8
|   |       PlayerMover.cs
|   |
|   \---Example 3.9
|           PlayerMover2D.cs
|
\---Chapter 4 Programming Core Gameplay Systems
    +---Example 4.1
    |       CameraFollow.cs
    |       GameManager.cs
    |       PlayerController.cs
    |
    +---Example 4.10
    |       Implementing a Life Counter.cs
    |
    +---Example 4.11
    |       Triggering a Game Over Screen.cs
    |
    +---Example 4.12
    |       Heart Icons.cs
    |
    +---Example 4.13
    |       Using Dictionaries — For Stacking Items.cs
    |
    +---Example 4.14
    |       pickup logic.cs
    |       storeing item names.cs
    |
    +---Example 4.15
    |       ItemPickup.cs
    |
    +---Example 4.16
    |       InventoryManager.cs
    |
    +---Example 4.17
    |       InventoryManager.cs
    |
    +---Example 4.18
    |       InventoryManager.cs
    |
    +---Example 4.19
    |       ItemPickup.cs
    |       UIInventory.cs
    |
    +---Example 4.2
    |       LifeBubble.cs
    |       PlayerHealth.cs
    |
    +---Example 4.20
    |       InventoryItem.cs
    |       InventoryManager.cs
    |       ItemPickup.cs
    |       UIInventory.cs
    |
    +---Example 4.21
    |       Expanding the Item Class with Purpose.cs
    |       InventoryManager.cs
    |       Making a Collectible Item With Real Power.cs
    |
    +---Example 4.22
    |       ScoreManager.cs
    |
    +---Example 4.3
    |       PlayerHealth.cs
    |       Step 2.cs
    |       Taking Fall Damage.cs
    |
    +---Example 4.4
    |       Visual Feedback.cs
    |
    +---Example 4.5
    |       Displaying Health as Text.cs
    |
    +---Example 4.6
    |       Using a Slider.cs
    |
    +---Example 4.7
    |       using Lerp().cs
    |
    +---Example 4.8
    |       Detecting Death.cs
    |
    \---Example 4.9
            Death Logic with Cleanup.cs

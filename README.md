# MYStack It!

---

## 🚀 Overview

"MYStack It!" is an simple **Android game** developed with the **Unity Engine**. The goal is simple: build the highest possible tower by precisely stacking blocks on top of each other. With each successfully placed block, the speed increases, making the game progressively more challenging.

This application offers a straightforward introduction to Unity's core principles, making it ideal for understanding the basics.

---

## ✨ Features

* **Engaging Gameplay:** Simple yet challenging block-stacking principle.
* **Dynamic Difficulty:** Stacking speed continuously increases for a demanding player experience.
* **High Score System:** Track your best performance and strive to beat it.
* **Android Optimization:** Developed and optimized for mobile devices.

---

## 🛠️ Technologies

* **Game Engine:** Unity (exact version: **2020.1.14f1**)
* **Programming Language:** C#
* **Target Platform:** Android

---

## 📦 Installation & Usage

You have two main options to explore and test this project:

### Testing in Unity Editor with Unity Remote (Recommended for Developers)

This method is ideal for quickly testing changes and debugging the game on your Android device in real-time, without building a full app every time.

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/YOUR_USERNAME/StackIt.git](https://github.com/YOUR_USERNAME/StackIt.git)
    cd StackIt
    ```
    *Replace `YOUR_USERNAME` with your GitHub username.*

2.  **Set up Unity Remote 5 on your Android Device:**
    * Install the **"Unity Remote 5"** app from the Google Play Store on your Android device.
    * Enable **Developer Options** on your device (usually by tapping the "Build number" in phone information 7 times).
    * Enable **USB Debugging** in Developer Options.
    * Connect your device to your computer via USB cable and select **"File transfer"** or **"PTP"** as the USB connection mode.

3.  **Open the Project in Unity:**
    * Start **Unity Hub**.
    * Click on **"Add Project from Disk"** and select the cloned `StackIt` folder.
    * Ensure the **correct Unity version** (2020.1.14f1) is selected.

4.  **Configure Unity Editor for Remote Connection:**
    * In Unity, go to `Edit > Project Settings`.
    * In the "Project Settings" window, select the **`Editor`** section on the left.
    * Scroll down to the **"Unity Remote"** section and select your connected Android device under **"Device"**.
    * Make sure the Unity Remote 5 app is running on your phone.

5.  **Start the Game:**
    * Open the main scene of the game (usually located under `Assets/Scenes/GameScene.unity` or `Assets/Scenes/MainMenu.unity`).
    * Click the **Play button** in the Unity Editor. The game should now be displayed synchronously on your Android device, and you can control it via your phone's touchscreen.

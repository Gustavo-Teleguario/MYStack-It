# Stack It!

---

## 🚀 Überblick

"Stack It!" ist ein süchtig machendes **Android-Spiel**, das mit der **Unity-Engine** entwickelt wurde. Das Ziel ist einfach: Baue den höchstmöglichen Turm, indem du Blöcke präzise aufeinander legst. Mit jedem erfolgreich platzierten Block erhöht sich die Geschwindigkeit, was das Spiel zunehmend herausfordernder macht.

Dieses Projekt dient als **praktische Demonstration** der Entwicklung einer mobilen Anwendung mit Unity. Es beleuchtet grundlegende Konzepte wie Gameplay-Implementierung, Benutzeroberflächengestaltung und den Export für Android-Plattformen.

---

## ✨ Features

* **Fesselndes Gameplay:** Simples, aber herausforderndes Prinzip des Blockstapelns.
* **Dynamische Schwierigkeit:** Die Stapelgeschwindigkeit erhöht sich kontinuierlich für eine anspruchsvolle Spielerfahrung.
* **Highscore-System:** Verfolge deine beste Leistung und versuche, sie zu überbieten.
* **Android-Optimierung:** Entwickelt und optimiert für mobile Geräte.

---

## 🛠️ Technologien

* **Game Engine:** Unity (genaue Version: [2020.1.14f1])
* **Programmiersprache:** C#
* **Zielplattform:** Android

---

## 📦 Installation & Nutzung

Du hast zwei Hauptoptionen, um dieses Projekt zu erkunden und zu testen:

### Option 1: Testen im Unity Editor mit Unity Remote (Empfohlen für Entwickler)

Diese Methode ist ideal, um Änderungen schnell zu testen und das Spiel auf deinem Android-Gerät in Echtzeit zu debuggen, ohne jedes Mal eine vollständige App zu bauen.

1.  **Repository klonen:**
    ```bash
    git clone [https://github.com/DEIN_USERNAME/StackIt.git](https://github.com/DEIN_USERNAME/StackIt.git)
    cd StackIt
    ```
    *Ersetze `DEIN_USERNAME` durch deinen GitHub-Benutzernamen.*

2.  **Unity Remote 5 auf deinem Android-Gerät einrichten:**
    * Installiere die App **"Unity Remote 5"** aus dem Google Play Store auf deinem Android-Gerät
    * Aktiviere **Entwickleroptionen** auf deinem Gerät (meistens 7x auf die "Build-Nummer" in den Telefoninformationen tippen).
    * Aktiviere **USB-Debugging** in den Entwickleroptionen.
    * Verbinde dein Gerät per USB-Kabel mit deinem Computer und wähle **"Dateiübertragung"** oder **"PTP"** als USB-Verbindungsmodus.

3.  **Projekt in Unity öffnen:**
    * Starte den **Unity Hub**.
    * Klicke auf **"Add Project from Disk"** und wähle den geklonten `StackIt`-Ordner aus.
    * Stelle sicher, dass die **korrekte Unity-Version** ausgewählt ist.

4.  **Unity Editor für Remote-Verbindung konfigurieren:**
    * Gehe in Unity zu `Edit > Project Settings`.
    * Wähle im Fenster "Project Settings" links den Bereich **`Editor`**.
    * Scrolle zum Abschnitt **"Unity Remote"** und wähle unter **"Device"** dein verbundenes Android-Gerät aus.
    * Stelle sicher, dass die Unity Remote 5 App auf deinem Handy läuft.

5.  **Spiel starten:**
    * Öffne die Hauptszene des Spiels (normalerweise unter `Assets/Scenes/GameScene.unity` oder `Assets/Scenes/MainMenu.unity`).
    * Klicke auf den **Play-Button** im Unity Editor. Das Spiel sollte nun synchron auf deinem Android-Gerät angezeigt werden, und du kannst es über den Touchscreen deines Handys steuern.

---

### Option 2: Direktinstallation auf Android (APK-Build)

Diese Methode erstellt eine eigenständige ausführbare Android-App (APK), die du auf jedem kompatiblen Android-Gerät installieren kannst.

1.  **Projekt in Unity öffnen** (siehe Schritt 3 unter Option 1).
2.  **Android Build Support prüfen:** Stelle sicher, dass du den **Android Build Support** über den Unity Hub für deine Unity-Version installiert hast.
3.  **Build-Einstellungen konfigurieren:**
    * Gehe in Unity zu `File > Build Settings`.
    * Wähle **"Android"** als Plattform aus.
    * Stelle sicher, dass die gewünschten Szenen (z.B. deine Hauptszene) in der Liste **"Scenes In Build"** enthalten sind (falls nicht, ziehe sie einfach hinein).
    * Klicke auf **"Switch Platform"**, um Unity auf Android als Ziel umzustellen.
4.  **Spieler-Einstellungen anpassen (Optional, aber empfohlen):**
    * Klicke in den "Build Settings" auf **"Player Settings..."**.
    * Unter **"Other Settings"** > **"Identification"**:
        * Setze den **"Package Name"** (z.B. `com.deinname.stackit`). Dies muss ein eindeutiger Name sein.
        * Wähle eine **"Minimum API Level"** und **"Target API Level"** (z.B. API Level 22 für Minimum und "Automatic (highest installed)" für Target).
    * Unter **"Publishing Settings"**:
        * Du musst einen Keystore einrichten, um die App zu signieren. Dies ist für die Installation auf einem Gerät erforderlich. Klicke auf **"Create new Keystore"** und folge den Anweisungen. Speichere das Keystore-Passwort und den Alias gut ab!
5.  **APK bauen:**
    * Klicke in den "Build Settings" auf **"Build"**.
    * Wähle einen Speicherort und einen Namen für deine APK-Datei (z.B. `StackIt.apk`).
    * Unity erstellt nun die APK-Datei. Dies kann einige Minuten dauern.
6.  **APK auf dein Gerät übertragen und installieren:**
    * Verbinde dein Android-Gerät per USB mit deinem Computer.
    * Kopiere die generierte `.apk`-Datei auf dein Gerät (z.B. in den "Downloads"-Ordner).
    * Trenne das Gerät vom Computer.
    * Öffne auf deinem Gerät einen Dateimanager, navigiere zur `.apk`-Datei und tippe darauf, um sie zu installieren. Du musst möglicherweise die Installation von Apps aus "unbekannten Quellen" in deinen Geräteeinstellungen zulassen.

---

## 🤝 Contributing (Mitwirken)

Du möchtest zu "Stack It!" beitragen? Das ist großartig!

1.  **Fehler melden:** Wenn du einen Bug findest, öffne bitte ein Issue in diesem Repository.
2.  **Verbesserungen vorschlagen:** Hast du Ideen für neue Features oder Optimierungen? Diskutieren wir sie in den Issues.
3.  **Code beisteuern:**
    * Forke das Repository.
    * Erstelle einen neuen Branch für deine Änderungen (`git checkout -b feature/deine-funktion`).
    * Implementiere deine Änderungen und committe sie mit einer aussagekräftigen Nachricht.
    * Pushe deinen Branch und öffne einen Pull Request.

---

## 📄 Lizenz

Dieses Projekt steht unter Maynor Gustavo Teleguario Queche Lizenz. 


# Balloon Pop

A small 2D arcade game built with **Unity** and **C#**: pop as many balloons as you can in 60 seconds.

[Türkçe aşağıda](#türkçe)

## Gameplay

- Balloons spawn every second at a random position at the bottom of the screen and float up with a random force.
- Click (or tap) a balloon to pop it. Each pop plays an explosion animation and increases the score.
- A 60-second countdown runs during the round. When time is up, every remaining balloon bursts at once.
- The game has two scenes: a main menu (`ana_sahne`) and the game scene (`oyun`).

## How it works

| Script | Responsibility |
|---|---|
| `oyunKontrol.cs` | Game state: countdown timer, score, UI text, end-of-round clean-up |
| `balonPatlatma.cs` | Balloon spawner: random X position and random upward force (`Rigidbody2D.AddForce`) on a fixed interval |
| `balonKontrol.cs` | Per-balloon behaviour: `OnMouseDown` → spawn explosion prefab, destroy balloon, update score |
| `button.cs` | Main menu button that loads the game scene (`SceneManager.LoadScene`) |

Built with Unity's 2D physics, prefabs (`balon`, `patlama`), sprite animation and the legacy UI `Text` component.

## Run it

1. Install **Unity 2020.3.20f1** (or a later 2020.3 LTS version) via Unity Hub.
2. Open the project folder in Unity Hub.
3. Open `Assets/Sahneler/ana_sahne.unity` and press **Play**.

## About

A learning project from 2023, built while practising C# and game development with Unity. My main work today is backend and full-stack development with PHP, Laravel, JavaScript, SQL and Flutter.

---

## Türkçe

**Unity** ve **C#** ile geliştirilmiş küçük bir 2D oyun: 60 saniyede olabildiğince çok balon patlat.

- Balonlar her saniye ekranın altından rastgele bir konumda ve rastgele bir kuvvetle yükselir.
- Balona tıklayınca patlama animasyonu oynar ve skor artar.
- 60 saniyelik süre bitince ekrandaki bütün balonlar birden patlar.
- İki sahne var: ana menü (`ana_sahne`) ve oyun (`oyun`).

Çalıştırmak için Unity Hub ile **Unity 2020.3.20f1** kur, klasörü aç, `Assets/Sahneler/ana_sahne.unity` sahnesini açıp **Play**'e bas.

2023 yılında C# ve Unity ile oyun geliştirme pratiği için yaptığım bir öğrenme projesidir.

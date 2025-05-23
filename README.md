# ❄️ Windchill Factor: How Cold It Really Feels

## 📌 Beskrivning

Detta är en **C#-consoleapplikation** som beräknar den upplevda kylan baserat på aktuell utomhustemperatur och vindhastighet, ofta kallad **vindavkylningsfaktor (wind chill)**.

Programmet är utvecklat i utbildningssyfte och visar hur man:

* Använder matematiska formler i C#
* Arbetar med användarinmatning och enhetsomvandling
* Kategoriserar resultat i olika kylnivåer
* Skriver ren och kommenterad kod med **Single-line, Multi-line och XML-kommentarer**

## ⚙️ Funktionalitet

* 🔢 Användaren matar in temperatur (i °C) och vindhastighet (i **km/h** eller **m/s**)

* 📐 Programmet använder följande formel för att beräkna wind chill:

  $$
  \text{WCT} = 13.12 + 0.6215 \cdot T - 11.37 \cdot V^{0.16} + 0.3965 \cdot T \cdot V^{0.16}
  $$

  * 𝑇 = Lufttemperatur i **Celsius**
  * 𝑉 = Vindhastighet i **km/h**

* 💬 Resultatet visas med **två decimaler** och klassificeras som:

  * Cold
  * Very Cold
  * Risk of Frostbite
  * Severe Frostbite Risk

* 🔁 Programmet innehåller en meny för att:

  * 📊 Göra en ny beräkning
  * 🚪 Avsluta applikationen

## 🧰 Teknisk Information

* **Språk:** C#
* **Miljö:** .NET 6.0
* **IDE:** Visual Studio 2022

## 👨‍💻 Utvecklare

* Samir Ahmad
* Ludwig Lindfors
  📚 Grupp: Labbgrupp 32

## 🗂 Kommentarstandarder i koden

Programmet använder följande typer av kommentarer:

* `//` – *Single Line Comments*
* `/* ... */` – *Multi Line Comments*
* `///` – *XML Comments* (för metoder)

## 📚 Referenser

1. [Complete C# Masterclass – Udemy](https://www.udemy.com/course/complete-csharp-masterclass)
2. Troelsen, A., & Japikse, P. (2022). *Pro C# 10 with .NET 6*. APress. ISBN: 9781484278680
3. Land, R. (2024). *Introduktion till programmering*. Borlänge
4. [Stack Overflow](https://stackoverflow.com/)
5. [Microsoft Learn – C# Challenge](https://learn.microsoft.com/en-us/dotnet/csharp/)
6. [Wind Chill Calculator – Bergfreunde](https://www.bergfreunde.eu/wind-chill-calculator/)
7. [C# Switch Statement – W3Schools](https://www.w3schools.com/cs/cs_switch.php)
8. [C# Comments – Programiz](https://www.programiz.com/csharp-programming/comments)



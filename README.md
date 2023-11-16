# 2D RPG Name TBD

## Inhalt
1. [Spielstand Struktur](#1-spielstand-struktur)
2. [Item IDs](#2-item-ids)
3. [Gameplay Mechanincs](#3-gameplay-mechanics)
4. [Ingame Menu](#4-ingame-menu)
5. [Hauptmenü](#5-hauptmenü)

## 1. Spielstand Struktur

### Spieler
- Name des Spielers (String)
- Name der Farm (String)
- Aktuelle GameScene (String)
- Aktuelle Position (Vector2)

### Welt
- Uhrzeit (Int)
- Tag (Int)
- Jahreszeit (Int)
- Jahr (Int)

- Farm Flut Status (Bool)
- Platzierte Gegenstände
    - GameScene (String)
    - Position (Vector2)
    - ggt. Inhalt (List)


## 2. Item IDs
Item IDs sind immer 5 Stellen lang.
Die ersten zwei Ziffern geben die Item Kategorie an:

01. Crops and Seeds
02. Foragables
03. Stones and Minerals
04. Craftables
05. Potions
06. Ingredients
07. Food
08. Fish
09. Tools
10. 

## 3. Gameplay Mechanics

### I. Jahreszeiten

Jahreszeiten bestehen jeweils aus 28 Tagen, mit je 4 Wochen. Jede Jahreszeit hat ein eigenes Tileset für die Umwelt, sodass das Aussehen veränderbar ist.

#### a. Frühling

##### Crops

#### b. Sommer

##### Crops

#### c. Herbst

##### Crops

#### d. Winter

##### Crops

## 4. Ingame Menu

Das Ingame Menü besteht aus einer Reihe von Tabs.
Diese sind am oberen Rand des Menüs auszuwählen.
Folgende Tabs sind umgesetzt:
* Inventar
* Crafting
* Skilltree
* Optionen
* Exit Optionen

### Inventar

Das Inventar soll dem Spieler einen Überblick liefern, welche Items und welche Ausrüstung aktuell getragen wird. Das Spielerinventar besteht aus 30 Slots, in denen Items untergebracht werden können. Darüber hinaus verfügt der Spieler über Ausrüstungsslots für Kopfbedeckungen, Rüstungen und Schuhe(, sowie zwei RInge und ein Amulett).

Am rechten Rand des Menüs soll für das Item, über das aktuell mit der Mouse gehovert wird, eine kurze Beschreibung und das Icon (größer) angezeigt werden.

### Crafting

Das Crafting Menü soll es dem Spieler ermöglichen, Items, die im Inventar sind, zu neues Items zu kombinieren. Die Optionen hierfür sind an sich limitiert, da viele Crafting Rezepte einen geeigneten Arbeitsplatz (wie einen Ofen oder eine Werkbank) benötigen.

Von Hand craftbare Items sind folgende:

* TBD

### Skilltree

Das Skillmenü ist erneut in drei Tabs unterteilt. Der erste Tab beinhaltet den Skillbaum für alles farm- und sammel-bezogene. Der zweite Tab verbessert Kampffähigkeiten. Der letzte Tab dreht sich um Magie und Trankbrauerei.

### Optionen

Das Optionemenü soll es dem Spieler ermöglichen, einige Einstellungen vorzunehmen. Diese bestehen aus Grafikeinstellungen, sowie Ingame Einstellungen.

### Exit Optionen

Die Exit Optionen bestehen aus 2 Buttons. Ein Button beendet das Spiel ohne zu speichern, der andere speichert den aktuellen Spielstand und beendet im Anschluss die aktuelle Spielsitzung und lässt den Spieler zum Hauptmenü zurückkehren.

## 5. Hauptmenü

Das Hauptmenü besteht aus 5 Buttons

* Neues Spiel
* Fortsetzen
* Spiel laden
* Optionen
* Spiel beenden

### Neues Spiel

Mit Klick auf diesen Button wird ein neues Spiel gestartet. Der Spieler wird zur Character Creation weitergeleitet, wo der Charakter für dieses Savegame gestaltet werden kann.

#### Character Creation

In diesem Screen soll der Spieler den Character für das neue Spiel bearbeiten können.
Folgende Optionen sollen hierbei gesetzt werden können:
* Charaktername (Auch name des Savegames)
* Farmname
* Parameter für das Aussehen des Characters (TBD)


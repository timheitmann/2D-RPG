# 2D RPG Name TBD

## Inhalt
1. Spielstand Struktur
2. Item IDs
3. Gameplay Mechanincs
    1. Jahreszeiten
        1. Frühling
            * Crops
        2. Sommer
            * Crops
        3. Herbst
            * Crops
        4. Winter
            * Crops

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


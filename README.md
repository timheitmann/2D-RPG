# 2D RPG Name TBD

## Inhalt
1. Spielstand Struktur
2. Item IDs
3. Gameplay Mechanincs

3.1. Jahreszeiten

3.1.1. Frühling

3.1.1.1. Crops

3.1.2. Sommer

3.1.2.1. Crops

3.1.3. Herbst

3.1.3.1. Crops

3.1.4. Winter

3.1.4.1. Crops

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

### 3.1. Jahreszeiten

Jahreszeiten bestehen jeweils aus 28 Tagen, mit je 4 Wochen. Jede Jahreszeit hat ein eigenes Tileset für die Umwelt, sodass das Aussehen veränderbar ist.

#### 3.1.1. Frühling

##### 3.1.1.1. Crops

1. 

#### 3.1.1. Sommer

##### 3.1.1.1. Crops

#### 3.1.1. Herbst

##### 3.1.1.1. Crops

#### 3.1.1. Winter

##### 3.1.1.1. Crops


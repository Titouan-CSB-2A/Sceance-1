# formes_geometriques_Titouan

## Présentation

Ce projet en C# modélise des formes géométriques simples dans un repère orthonormé : points, cercles et rectangles. Il permet de manipuler ces objets, de calculer leur aire et leur périmètre, et d’afficher leurs propriétés.

## Fonctionnalités

- **Classe Point** : représente un point avec coordonnées (X, Y).
- **Classe Forme** : classe de base pour les formes géométriques, possède un point d’origine.
- **Classe Cercle** : hérite de `Forme`, possède un rayon, calcule aire et périmètre.
- **Classe Rectangle** : hérite de `Forme`, possède largeur et hauteur, calcule aire et périmètre.

## Utilisation

Exemple d’utilisation dans `Program.cs`
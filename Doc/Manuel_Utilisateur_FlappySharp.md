# Table des Matières

[TOC]

# Introduction

Ce document est destiné aux utilisateurs de FlappySharp. Ce projet a été réalisé dans le cadre d’un Travail Pratique Individuel pour l’obtention du CFC en informatique. Il s'agissait de faire un éditeur de jeux 2D du type Flappy Bird.

Cette documentation explique la démarche installer l'éditeur de jeux 2D et le supprimer. Elle contient également une présentation de l'interface.

# Installe et désinstaller l'éditeur

## Installation

L'installation de l'éditeur est extrêmement simple. Il suffit de télécharger le dossier du jeu, de le dézipper et ensuite de lancer FlappySharp.exe.

## Désinstallation

Pour désinstaller l'application de l'ordinateur, il suffit de supprimer le dossier. Il ira donc dans la corbeille, il vous suffira alors juste de vider la corbeille pour supprimer définitivement le dossier.

# Utiliser l'éditeur FlappySharp

Cette section de la documentation permet de vous expliquer les interfaces de l'éditeur. Puis les marches à suivre pour effectuer toutes les actions possibles. Chaque procédure est décrite en détail et est agrémentée d’une image  représentative.

# Présentation de l'interface

## La fiche frmMain

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200602010916882.png" />

Cette fenêtre est la fenêtre principale c'est ici que vous allez éditer votre jeu.

Dans cette fenêtre il y a quatre parties très importantes:

- La scène de Jeu où on place tous les éléments avant de pouvoir y jouer.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609083718706.png" style="zoom:200%"/>

- La modification des paramètres où vous pourrez modifier les paramètres du Sprite sélectionné ou supprimer le Sprite.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200608081653482.png" style="zoom:115%;"/>

- L'ajout de Sprite se fait de deux façons différentes soit vous utilisez les Sprites déjà existant soit vous en crée un nouveau.

<img src="C:\Users\Dev\Desktop\image a supr apres tpi\tempsnip3.png" style="zoom:35"/>

## La barre de menu

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609082109390.png" style="zoom:130%"/>

La barre de menus comporte plusieurs parties. 

- Il y a "Enregistrer" qui permet de sauvegarder son projet et pour cela la fenêtre frmCreationProjet s'ouvre pour indiquer le nom du projet et l'endroit où vous voulez l'enregistrer. 

- Il y a "Ouvrir" qui permet de charger un fichier XML qui contient dans l'application pour ensuite continuer de travailler dessus ou bien de pouvoir y jouer.
- Il y a "Run" qui permet d'ouvrir la forme frmPlateauJeu qui permet de jouer au jeu.

## La fiche frmAjoutSprite

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200602013951830.png" style="zoom:80%;" />

Cette fenêtre s'ouvre après avoir appuyé sur le picture avec une image de "plus". Elle vous permet de créer un Sprite en indiquant dans les champs les valeurs qu'aura le Sprite. Les valeurs que vous  pouvez définir pour le Sprite sont : le nom, qui ne peut pas être le même si le nom choisi est le même qu'un déjà existant (un chiffre s'ajoute à la fin du nom le rendre unique), la position (X et Y), la taille (Hauteur et Largeur), le calque où il sera et le ZOrder qui se place automatiquement afin qu'il n'y ait pas deux Sprite sur le même ZOrder. Et enfin il y a les images qui permettent de faire une animation du Sprite.

## La fiche frmPlateauJeu

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200605102233868.png"  style="zoom:80%;" />

Cette fenêtre après avoir appuyé sur "Run" du menuStrip. La fenêtre permet vous permet de jouer au jeu que vous venez de faire. La fenêtre affiche le nombre de fps qu'il y sur la forme.

## La fiche frmCreationProjet

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200605104125299.png" style="zoom:120%"/>

Cette fenêtre s'ouvre après avoir appuyé sur "Enregistrer" du menuStrip. La fenêtre frmCreationProjet permet de créer son projet en indiquant le chemin où il va le créer et le nom du projet. Elle va créer une arborescence pour ton projet.

## Message d'information

Des messages d'informations sont prévus pour vous guider tout au long de votre utilisation.

### Enregistrement impossible sans Sprite

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200605131644887.png" style="zoom:120%"/>

Ce message vous indique qu'il est impossible d'enregistrer son projet sans avoir de Sprite dans la scène.

# Présentation des fonctionnalités

Voici la liste des actions possibles pour l'utilisateur de FlappySharp :

- Création d'un Sprite :
  - Création d'un Sprite à partir des ressources mises à disposition
  - Création d'un Sprite à partir de vos ressources
- Modification de Sprite
- Suppression de Sprite
- Ouverture d'un projet
- Enregistrement d'un projet
- Lancement du jeu

## Création d'un sprite

La création d'un Sprite permet de l'ajouter dans le plan de jeu. Il y a deux manières différentes pour les ajoutés que je vais vous présenter.

### Création d'un Sprite à partir des ressources mise à disposition

Il suffit juste d'appuyer sur l'une de ces quatre images.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609101541610.png" style="zoom:200%"/>

### Création d'un Sprite à partir de vos ressources

Vous devez appuyer sur l'image de "plus".

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609101802435.png" style="zoom:300%"/>

La forme frmAjoutSprite s'ouvre il suffit alors de remplir les champs pour ensuite crée un Sprite sur la scène de jeu.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200602013951830.png" style="zoom:80%;" />

 ## Modification d'un Sprite

La modification permet de changer les paramètres des Sprites pour qu'il soit fonctionnel.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200608081653482.png" style="zoom:115%;"/>

Le tag pour le Sprite à une importance si vous choisissez "Player" vous pourrez contrôler. Vous pouvez aussi choisir "Ennemie" qui lui bougera tout seul. Vous pouvez aussi choisir "Fond" et "Sol" mais ils n'ont pas d'implémentation pour l'instant.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609103355723.png" style="zoom:250%"/>

Pour sauvegarder les modifications apportées au Sprite il faudra appuyer sur le button "Sauvegarder Modification".

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609103931586.png" style="zoom:250%"/>

## Suppression d'un Sprite

La suppression d'un permet de supprimer un Sprite du projet. Pour ce faire vous devez sélectionner un Sprite et appuyer sur le button "Supprimer".

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609103931586.png" style="zoom:250%"/>

## Ouverture d'un projet

L'ouverture d'un projet permet de charger un projet existant dans l'application. Pour charger un projet vous devez appuyer sur "Ouvrir" dans le menu.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609082109390.png" style="zoom:130%"/>

Vous allez ensuite avoir un explorateur de recherche qui va s'ouvrir il vous suffira de sélectionner le fichier xml de votre projet et votre projet se chargera tout seul.

## Enregistrement d'un projet

L'enregistrement d'un projet permet de sauvegarder un projet. Pour enregistrer un projet vous devez appuyer sur "Enregistrer" dans le menu.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609082109390.png" style="zoom:130%"/>

Si c'est la première fois que vous enregistrez votre projet la fenêtre frmCreationProjet va s'ouvrir il vous suffira de choisir un nom pour votre projet et son emplacement.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200605104125299.png" style="zoom:120%"/>

Enfin après l'enregistrement une arborescence se créera à l'emplacement que vous avez choisie avec un fichier xml contenant tous les Sprites ainsi qu'un dossier pour chaque Sprite contenant ces images.

## Lancement du jeu

Le lancement du jeu permet de jouer au jeu crée. Pour jouer au jeu vous devez appuyer sur "Run" dans le menu.

<img src="C:\Users\Dev\AppData\Roaming\Typora\typora-user-images\image-20200609082109390.png" style="zoom:130%"/>

Après avoir appuyé sur le button "Run" la fenêtre frmPlateauJeu s'ouvre et le jeu se lance.
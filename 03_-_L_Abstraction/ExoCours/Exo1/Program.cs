﻿using System;

/*
On désir réaliser une application de gestion de comptes bancaires.
Pour cela on a proposé d’organiser les objets de l’application en deux catégories (CompteSurCarnet et CompteSurCheque) et de les ranger dans une collection. 
Les classes CompteSurCarnet et CompteSurCheque ont des propriétés communes telles que Numéro et NomProprietaire et Solde qui donnent naissance à une troisième classe Compte 
considérée comme classe de base pour éviter les redondances.

La classe CompteSurCarnet possède, en plus des propriétés communes, la propriété NuméroCanret. 
La classe CompteSurCheque est caractérisée par le NuméroChèque et le NuméroCarte ainsi que DateFinValiditéCarte.

1) Définir la classe abstraite AbstractCompte avec deux constructeurs (par défaut et d’initialisation) et les accesseurs.
         a. Ajouter deux méthodes abstraites créditer et Débiter qui prend en paramètre la somme à ajouter au compte ou à retirer du compte. 

2) Définir la classe CompteSurCheque avec deux constructeurs (par défaut et d’initialisation) et les accesseurs. 
         a. Redéfinir la méthode créditer qui prend en paramètre la somme à ajouter au compte.
         b. Redéfinir la méthode Débiter qui prend en paramètre la somme à déduire du compte qui ne doit pas dépasser le solde sinon une exception est générée avec le message : « Solde insuffisant ». 

3) Définir la classe CompteSurCarnet avec deux constructeurs (par défaut et d’initialisation) et les accesseurs.
         a. Redéfinir la méthode créditer qui prend en paramètre la somme à ajouter au solde.
         b. redéfinir la méthode Débiter qui prend en paramètre la somme à retirer du compte qui ne doit pas dépasser le solde sinon une exception est générée avec le message : « Solde insuffisant », en plus la somme à retirer ne doit pas dépasser un plafond de 10000Dh sinon une exception est générée avec le message : « Plafond dépassé ». 

4) Définir la classe Banque contenant une collection de comptes (CompteSurCheque et CompteSurCarnet) et ajouter les méthodes suivantes :
         a. rechercher : qui prend en paramètre un numéro et retourne l’indice du compte dans la collection ou -1 s’il n’existe pas.
         b. AjouterCompteCarnet : qui prend les paramètres nécessaires à la création d’un compte sur carnet et de l’ajouter à la collection (vérifier que le numéro n’existe pas déjà avant de l’ajouter).
         c. AjouterCompteCheque : qui prend les paramètres nécessaires à la création d’un compte sur chèque et de l’ajouter à la collection (vérifier que le numéro n’existe pas déjà avant de l’ajouter).
         d. Supprimer : qui prend en paramètre un numéro et supprime le compte correspondant.
         e. La propriété Elément : qui prend en paramètre un numéro et retourne le compte correspondant à ce numéro.
*/

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random();
            Console.WriteLine(rand.Next(1,10));
        }
    }
}

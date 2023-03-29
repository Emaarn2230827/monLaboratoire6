using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    enum Statut
    {
        parfait,
        necc_reparation,
        etre_demoli
    }
    internal class Batiment
    {
        public string Coordonnees { get; set; }
        public Statut StatutBat { get; set; }
        public int Priorite { get; set; }
        public int QteRessource { get; set; }
        
        public Batiment(string coordo,Statut statutbat, int priorite, int qteressource =0)
        {
            Coordonnees = coordo;
            Priorite = priorite;
            StatutBat = statutbat;
            QteRessource = qteressource;
            
        }

        public  override string ToString()
        {
            return $"{Coordonnees}, statut: {StatutBat}, priorité: {Priorite}";
        }

    }
}

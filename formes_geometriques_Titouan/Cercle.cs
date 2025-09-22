using System;

namespace formes_geometriques_Titouan
{
    /*Classe Cercle.
        Auteur : N.Titouan
        Date de création : 16/09/2025
        Date de modification : 
        Description : Cette classe modélise un cercle dans un repère orthonormé.
    */
    /// <summary>
    /// Classe Cercle. Représente un cercle défini par son rayon.
    /// Hérite de la classe Forme.
    /// </summary>
    public class Cercle : Forme
    {
        #region Attributs
        /// <summary>
        /// Rayon du cercle.
        /// </summary>
        private double _rayon;
        #endregion

        #region Constructeur
        /// <summary>
        /// Crée un cercle aux coordonnées (x,y) avec le rayon spécifié.
        /// </summary>

        public Cercle(int x, int y, float r) : base(x, y)
        {
            _rayon = r;
        }
        #endregion

        #region Propriétés
        /// <summary>
        /// Obtient ou définit le rayon du cercle.
        /// </summary>
        public double Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Calcule et retourne l'aire du cercle.
        /// </summary>
        public override double Aire()
        {
            return (float)(Math.PI * _rayon * _rayon);
        }
        /// <summary>
        /// Calcule et retourne le périmètre du cercle.
        /// </summary>
        public override double Perimetre()
        {
            return (float)(2 * Math.PI * _rayon);
        }
        #endregion
    }
}
using System;

namespace formes_geometriques_Titouan
{
    /*Classe Rectangle.
        Auteur : N.Titouan
        Date de création : 16/09/2025
        Date de modification : 
        Description : Cette classe modélise un rectangle dans un repère orthonormé.
    */
    /// <summary>
    /// Classe Rectangle. Représente un rectangle défini par sa largeur et sa hauteur.
    /// Hérite de la classe Forme.
    /// </summary>
    public class Rectangle : Forme
    {
        #region Attributs
        /// <summary>
        /// Largeur du rectangle.
        /// </summary>
        private double _largeur;
        /// <summary>
        /// Hauteur du rectangle.
        /// </summary>
        private double _hauteur;
        #endregion

        #region Constructeur
        /// <summary>
        /// Crée un rectangle aux coordonnées (x,y) avec la largeur et la hauteur spécifiées.
        /// </summary>

        public Rectangle(int x, int y, float largeur, float hauteur) : base(x, y)
        {
            _largeur = largeur;
            _hauteur = hauteur;
        }
        #endregion

        #region Propriétés
        /// <summary>
        /// Obtient ou définit la largeur du rectangle.
        /// </summary>
        public double Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }
        /// <summary>
        /// Obtient ou définit la hauteur du rectangle.
        /// </summary>
        public double Hauteur
        {
            get { return _hauteur; }
            set { _hauteur = value; }
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Calcule et retourne l'aire du rectangle.
        /// </summary>
        public override double Aire()
        {
            return _largeur * _hauteur;
        }
        /// <summary>
        /// Calcule et retourne le périmètre du rectangle.
        /// </summary>
        public override double Perimetre()
        {
            return 2 * (_largeur + _hauteur);
        }
        #endregion
    }
}

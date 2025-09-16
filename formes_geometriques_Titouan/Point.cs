using System;

namespace formes_geometriques_Titouan
{
    /*Classe Point.
        Auteur : N.Titouan
        Date de création : 16/08/2025
        Date de modification : 
        Description : Cette classe modélise un point dans un repère orthonormé
    */
    /// <summary>
    /// Classe Point. Représente un point dans un repère orthonormé.
    /// </summary>
    class Point
    {
        #region Attributs
        private int _x;
        private int _y;
        #endregion

        #region Constructeurs

        /// <summary>
        /// Crée un point au coordonnées (0,0).
        /// </summary>
        public Point()
        {
            _x = 0;
            _y = 0;
        }
        /// <summary>
        /// Crée un point au coordonnée (x,y).
        /// </summary>

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        #endregion

        #region Propriétés
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// RenVoie un booléen en fonction de la position des deux points.
        /// </summary>

        public bool Equals(Point autrePoint)
        {
            return X == autrePoint.X && Y == autrePoint.Y;
        }
        #endregion
    }
}

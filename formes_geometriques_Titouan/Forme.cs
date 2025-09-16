using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes_geometriques_Titouan
{
    class Forme
    {
        #region Attributs
        private Point point;
        #endregion
        #region Constructeurs
        /// <summary>
        /// Crée une forme avec un point à l'origine (0,0).
        /// </summary>
        public Forme()
        {
            point = new Point();
        }
        /// <summary>
        /// Crée une forme avec un point aux coordonnées (x,y).
        /// </summary>
        public Forme(int x, int y)
        {
            point = new Point(x, y);
        }
        #endregion
        #region Propriétés
        public Point Point
        {
            get { return point; }
            set { point = value; }
        }
        #endregion
        #region Méthodes
        /// <summary>
        /// Renvoie 0 car une forme n'a pas d'aire définie.
        /// </summary>
        public float Aire()
        {
            return 0;
        }
        /// <summary>
        /// Renvoie 0 car une forme n'a pas de périmètre défini.
        /// </summary>
        public float Perimetre()
        {
            return 0;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes_geometriques_Titouan
{
    public class Forme
    {
        #region Attributs
        private Point _point;
        #endregion
        #region Constructeurs
        /// <summary>
        /// Crée une forme avec un point à l'origine (0,0).
        /// </summary>
        public Forme()
        {
            _point = new Point();
        }
        /// <summary>
        /// Crée une forme avec un point aux coordonnées (x,y).
        /// </summary>
        public Forme(int x, int y)
        {
            _point = new Point(x, y);
        }
        #endregion
        #region Propriétés
        public Point Point
        {
            get { return _point; }
            set { _point = value; }
        }
        #endregion
        #region Méthodes
        /// <summary>
        /// Renvoie 0 car une forme n'a pas d'aire définie.
        /// </summary>
        public virtual double Aire()
        {
            return 0;
        }
        /// <summary>
        /// Renvoie 0 car une forme n'a pas de périmètre défini.
        /// </summary>
        public virtual double Perimetre()
        {
            return 0;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class FramedPhoto : Photo
    {
        public enum MaterialEnum
        {
            PINE   = 0,
            OAK    = 1,
            STEEL  = 2,
            SILVER = 3,
            GOLD   = 4
        }

        public enum StyleEnum
        {
            SIMPLE   = 0,
            MODERN   = 1,
            ANTIQUE  = 2,
            VINTAGE  = 3,
            ECLECTIC = 4
        }

        private MaterialEnum _theMaterial;
        private StyleEnum _theStyle;

        public FramedPhoto(double width, double height, MaterialEnum material, StyleEnum style) : base(width, height)
        {
            _theMaterial = material;
            _theStyle = style;
        }

        public MaterialEnum Material
        {
            get
            {
                return _theMaterial;
            }
            set
            {
                _theMaterial = value;
            }
        }

        public StyleEnum Style
        {
            get
            {
                return _theStyle;
            }
            set
            {
                _theStyle = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + " Framed " +
                Material.ToString() + " " + Style.ToString();
        }
    }
}

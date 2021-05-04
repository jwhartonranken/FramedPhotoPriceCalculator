using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    class MattedPhoto : Photo
    {
        public enum ColorEnum
        {
            BLACK = 0,
            RED = 1,
            GREEN = 2,
            BLUE = 4,
            WHITE = 7
        }

        private ColorEnum _theColor;

        public MattedPhoto(double width, double height, ColorEnum theColor) : base(width, height)
        {
            _theColor = theColor;
        }

        public override string ToString()
        {
            return base.ToString() + " Matted " + Color.ToString();
        }

        public ColorEnum Color
        {
            get
            {
                return _theColor;
            }
            set
            {
                _theColor = value;
            }
        }
    }
}

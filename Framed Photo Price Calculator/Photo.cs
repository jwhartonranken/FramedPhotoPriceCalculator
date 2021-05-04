using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Photo
    {
        private double _width;
        private double _height;

        public Photo(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override string ToString()
        {
            return (Width.ToString() + " x " + Height.ToString());
        }


        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
    }
}

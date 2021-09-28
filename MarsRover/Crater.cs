using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Crater
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Crater(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
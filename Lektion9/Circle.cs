using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9
{
    public class Circle
    {
        public Circle(double radius, double centerX, double centerY)
        {
            Radius = radius;
            CenterX = centerX;
            CenterY = centerY;
        }

        //Radius of the circle
        private double __Radius;
        public double Radius { get { return __Radius; } set { __Radius = value; } }

        //The x & y value of the center point
        private double __CenterX;
        private double __CenterY;

        public double CenterX { get { return __CenterX; } set { __CenterX = value; } }
        public double CenterY { get { return __CenterY; } set { __CenterY = value; } }

        //A method to determine wether a point is in the circle
        public bool IsPointInCircle(double x, double y)
        {
            return (Math.Pow((x - CenterX), 2)) + (Math.Pow(y - CenterY, 2)) < Math.Pow(Radius, 2);
        }

        //Check wether two circels intersect
        public bool IsOverlap(Circle circle)
        {
            //Distance between centers are calculated
            double centerDist = Math.Sqrt((Math.Pow(CenterX - (circle.CenterX), 2)) + Math.Pow(CenterY - (circle.CenterY), 2));

            if (centerDist <= (Radius-circle.Radius))
            {
                return true;
            }
            else if (centerDist <= (circle.Radius - Radius))
            {
                return true;
            }
            else if (centerDist < (Radius + circle.Radius))
            {
                return true;
            }
            else if (centerDist == (Radius + circle.Radius))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

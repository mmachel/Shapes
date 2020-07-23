using System;

namespace Shapes
{
    public class Angle
    {
        private double Angulo;
        public Angle(double angulo)
        {
            Angulo = angulo;
        }
        public double angle() => Angulo * Math.PI/ 180;
    }
}
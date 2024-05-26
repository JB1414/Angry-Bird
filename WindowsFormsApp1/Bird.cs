using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1
{
    internal class Bird
    {
        public double StartX { get; private set; } = 0;
        public double StartY { get; private set; } = 0;
        public double Vx { get; private set; }
        public double Vy { get; private set; }
        public double AngleRadians { get; private set; }
        public double InitialSpeed { get; private set; }
        private double g = 9.81;
        private double gamma = 0.1;
        private double dt = 0.15;

        public Bird(double velocityMS, double angleDeg)
        {
            InitialSpeed = velocityMS;
            AngleRadians = angleDeg * Math.PI / 180.0; // Convert to radians
            Vx = InitialSpeed * Math.Cos(AngleRadians);
            Vy = InitialSpeed * Math.Sin(AngleRadians);
        }

        public PointF[] Fly()
        {
            var X = StartX;
            var Y = StartY;

            var trajectory = new List<PointF>
            {
                new PointF((float)X, (float)Y)
            };

            while (Y >= 0 && X <= 1500)
            {
                X += Vx * dt;
                Vx -= gamma * Vx * dt;
                Y += Vy * dt;
                Vy -= (g + gamma * Vy) * dt;

                if (Y < 0) break;

                trajectory.Add(new PointF((float)X, (float)Y));
            }
            return trajectory.ToArray();
        }
    }
}

﻿namespace EpitaSpaceProgram
{
    public class DamperSpring : Spring
    {
        private double dumpling;
        
        public DamperSpring(string name, double mass, double density, Vector2 initialPosition, Vector2 origin,
            double spring, double damping)
            : base(name, mass, density, initialPosition, origin, spring)
        {
            this.dumpling = damping;
        }

        public override void Update(double delta)
        {
            base.Update(delta);
            Acceleration += -dumpling * ((Position - origin) / delta);
        }
    }
}
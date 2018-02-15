namespace EpitaSpaceProgram
{
    public class DamperSpring : Spring
    {
        private double damping;
        private Vector2 origin;
        private Vector2 pos;
        private double spring;
        
        
        public DamperSpring(string name, double mass, double density, Vector2 initialPosition, Vector2 origin,
            double spring, double damping)
            : base(name, mass, density, initialPosition, origin, spring)
        {
            this.damping = damping;
            this.origin = origin;
            this.spring = spring;
            pos = initialPosition;
        }

        public override void Update(double delta)
        {
            base.Update(delta);
            ApplyForce(-spring * (Position - origin) - damping * ((Position - origin) / delta));
            origin = pos;
            pos = Position;
        }
    }
}

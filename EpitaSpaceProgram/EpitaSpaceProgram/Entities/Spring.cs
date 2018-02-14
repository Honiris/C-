using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

namespace EpitaSpaceProgram
{
    public class Spring : Body
    {
        private double spring;
        private Vector2 origin;
        
        public Vector2 Origin
        {
            get { return origin; }
        }

        public Spring(string name, double mass, double density, Vector2 initialPosition, Vector2 origin, double spring)
            : base(name, mass, density, initialPosition)
        {
            this.origin = origin;
            this.spring = spring;
        }

        public override void Update(double delta)
        {
            base.Update(delta);
            Acceleration = -spring * (Position - origin);
        }
    }
}
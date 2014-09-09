using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class Repeller : Particle, IRenderable, IAcceleratable
    {
        public Repeller(MatrixCoords position, MatrixCoords speed)
            :base (position, speed)
        {
            this.Position = position;
            this.Speed = speed;
        }       

        public override IEnumerable<Particle> Update()
        {
            this.Move();
            return new List<Particle>();
        }

        public override char[,] GetImage()
        {
            return new char[,] { { '&' } };
        }
    }
}

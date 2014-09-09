using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChaoticParticle : Particle, IRenderable, IAcceleratable
    {
        public MatrixCoords ChaoticPosition { get; private set; }
        public MatrixCoords ChaoticSpeed { get; private set; }

        public ChaoticParticle(MatrixCoords ChaoticPosition, MatrixCoords ChaoticSpeed)		
            : base(ChaoticPosition, ChaoticSpeed)
        {
            this.ChaoticPosition = ChaoticPosition;
            this.ChaoticSpeed =  ChaoticSpeed;
        }

        public virtual IEnumerable<Particle> Update()
        {
            this.Move();
            return new List<Particle>();
        }

        protected override void Move()
        {
            this.Position += this.Speed;
        }

        public MatrixCoords GetTopLeft()
        {
            return this.Position;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { '#' } };
        }

        public override bool Exists
        {
            get { return true; }
        }

        public void Accelerate(MatrixCoords acceleration)
        {
            this.Speed += acceleration;
        }
    }
}

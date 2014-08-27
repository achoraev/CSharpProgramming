using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ChickenParticle : Particle, IRenderable, IAcceleratable
    {
        static readonly Random stopGenerator = new Random();
        int sleepTime;

        public MatrixCoords ChickenPosition { get; private set; }
        public MatrixCoords ChickenSpeed { get; private set; }

        public ChickenParticle(MatrixCoords ChickenPosition, MatrixCoords ChickenSpeed)		
            : base(ChickenPosition, ChickenSpeed)
        {
            this.ChickenPosition = ChickenPosition;
            this.ChickenSpeed = ChickenSpeed;
        }

        public override IEnumerable<Particle> Update()
        {
            
            if (sleepTime > 1)
            {
                sleepTime--;
                return new List<Particle>(); 
            }
            else if (sleepTime == 1)
            {
                sleepTime--;
                List<Particle> egg = new List<Particle>();
                egg.Add(new ChickenParticle(this.ChickenPosition, new MatrixCoords(stopGenerator.Next(-5, 5), stopGenerator.Next(-5, 5))));
                this.Move();   
                return egg;                
            }
            if (stopGenerator.Next(0, 20) == 8)
            {
                sleepTime = stopGenerator.Next(5, 10);
            }
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
            return new char[,] { { '$' } };
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

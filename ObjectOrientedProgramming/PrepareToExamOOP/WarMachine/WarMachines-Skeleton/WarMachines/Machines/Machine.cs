namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Machine(string name, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Pilot cannot be null or empty!!!");
                }
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            protected set { this.attackPoints = value; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
            protected set { this.defensePoints = value; }
        }

        public IList<string> Targets
        {
            get { return new List<string>(targets);}
        }
        
        public void Attack(string target)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentNullException("Target cannot be null!!!");
            }
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var report = new StringBuilder();
            string targetsResult = this.targets.Count == 0 ? "None" : string.Join(", ", this.targets); 

            report.AppendLine(string.Format("- {0}", this.Name));
            report.AppendLine(string.Format(" *Type: {0}", this.GetType().Name)); 
            report.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            report.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            report.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            report.Append(string.Format(" *Targets: {0}", targetsResult));
            
            return report.ToString();
        }
    }
}

namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Tank: Machine, ITank, IMachine
    {       
        private const int startHealthPoints = 100;
        private const int AttackPointsModified = 40;
        private const int DefensePointsModified = 30;
        private bool defenseMode;

        public bool DefenseMode
        {
            get { return this.defenseMode; }
            protected set { this.defenseMode = value; }
        }

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, startHealthPoints, attackPoints, defensePoints)
        {
            this.ToggleDefenseMode();  
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModified;
                this.DefensePoints -= DefensePointsModified;
            }
            else
            {
                this.AttackPoints -= AttackPointsModified;
                this.DefensePoints += DefensePointsModified;
            }
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            string defense = this.DefenseMode ? "ON" : "OFF";
            result.Append(string.Format(" *Defense: {0}", defense));
            return result.ToString();
        }
    }
}

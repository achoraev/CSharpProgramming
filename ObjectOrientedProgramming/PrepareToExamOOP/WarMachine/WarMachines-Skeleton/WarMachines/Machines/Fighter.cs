namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Fighter: Machine, IFighter, IMachine
    {
        private const int startHealthPoints = 200;
        private const int AttackPointsModified = 40;
        private const int DefensePointsModified = 30;

        public bool StealthMode{ get; protected set; }          

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, startHealthPoints, attackPoints, defensePoints)
        {
            this.StealthMode = stealthMode;   
        }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            string stealth = this.StealthMode ? "ON" : "OFF";
            result.Append(string.Format(" *Stealth: {0}", stealth));
            return result.ToString();
        }
    }
}

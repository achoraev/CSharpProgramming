namespace WarMachines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public string Name
        {
            get 
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot must have a name!!!");
                }

                this.name = value;
            }
        }

        public Pilot(string name)
        {
            this.name = name;
            this.machines = new List<IMachine>();
        }
        public void AddMachine(IMachine machine)
        {
            if (machine == null)
            {
                throw new ArgumentNullException("Machine cannot be null!!!");
            }
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.Append(string.Format("{0} - ", this.Name));
            if (machines.Count == 1)
            {
                report.Append("1 machine");
            }
            else if (machines.Count > 1)
            {
                report.Append(string.Format("{0} machines", this.machines.Count())); 
            }            
            else
            {
                report.Append("no machines");
            }
            report.AppendLine();
            var sortedMachines = machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            foreach (var machine in sortedMachines)
	        {
		        report.AppendLine(machine.ToString());
	        }
            return report.ToString().TrimEnd();
        }
    }
}

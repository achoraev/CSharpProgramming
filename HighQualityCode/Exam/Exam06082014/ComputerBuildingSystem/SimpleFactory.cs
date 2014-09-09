namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SimpleFactory
    {
        public PC BuildComputers(Type computerType)
        {
            PC newComputer = null;

            // switch (computerType)
            // {
            //    case Type.PC:
            //        { return new PC(); }
            //    case Type.LAPTOP:
            //        { return new LAPTOP(); }
            //    case Type.SERVER:
            //        { return new SERVER(); }
            //    default:
            //        { return null; }
            // }
            return newComputer;
        }
    }
}
namespace RefactorIfStatements
{
    using System;
    using IfStatements;

    public class RefactorIfStatements
    {
        public static void Main()
        {
            // first statement
            Potato potato = new Potato();
            if (potato != null && !(potato.HasNotBeenPeeled && potato.IsRotten))
            {
                Cook(potato);
            }

            // second statement
            int x = 15;
            int y = 25;
            int min = int.MinValue;
            int max = int.MaxValue;
            bool shouldVisitCell = false;
            bool isInRange = (y >= min && y <= max) && (x >= min && x <= max);

            if (isInRange && shouldVisitCell)
            {
                VisitCell();
            }
        }

        private static void Cook(Potato potato)
        {
            throw new NotImplementedException();
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }
    }
}
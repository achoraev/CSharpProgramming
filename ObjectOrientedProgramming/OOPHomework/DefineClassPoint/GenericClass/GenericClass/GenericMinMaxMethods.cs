namespace GenericClass
{
    using System;

    public static class GenericMinMaxMethods
    {
        public static T Min<T>(Generic<T> genList)
            where T: IComparable
        {
            var min = genList[0];
            for (int i = 0; i < genList.NextElement - 1; i++)
            {                                
                var temp = default(T);
                if (genList[i].CompareTo(genList[i + 1]) <= 0)
                {
                    temp = genList[i];
                }
                if (temp.CompareTo(min) <= 0)
                {
                    min = temp;   
                }
                i++;
            }
            return min;
        }

        public static T Max<T>(Generic<T> genList)
            where T : IComparable
        {
            var max = genList[genList.NextElement-1];
            for (int i = 0; i < genList.NextElement-1; i++)
            {
                var temp = default(T);
                if (genList[i].CompareTo(genList[i + 1]) <= 0)
                {
                    temp = genList[i+1];
                }
                if (temp.CompareTo(max) > 0)
                {
                    max = temp;
                }
                i++;
            }
            return max;
        }
    }
}

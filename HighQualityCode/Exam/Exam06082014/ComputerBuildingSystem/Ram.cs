namespace ComputerBuildingSystem
{
    public class Ram : IMotherboard
    {
        private int value;

        public Ram(int amount)
        {
            this.Amount = amount;
        }

        public int Amount { get; set; }

        public void DrawOnVideoCard(string data)
        {
            throw new System.NotImplementedException();
        }

        public int LoadRamValue()
        {
            return this.value;
        }

        public void SaveRamValue(int newValue)
        {
            this.value = newValue;
        }
    }
}
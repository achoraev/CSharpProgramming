namespace ChefCook
{
    using System;
    using ClassChef;
    
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = this.GetBowl();
            
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);
            
            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }
        
        private Bowl GetBowl()
        {
            throw new NotImplementedException();
        }
        
        private Potato GetPotato()
        {
            throw new NotImplementedException();
        }
        
        private Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }
        
        private void Peel(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }
        
        private void Cut(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }
    }
}
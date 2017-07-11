using System;

public class Cat : Animal
{
    
    public Cat(string name, string fovouriteFood) 
    {
        this.Name = name;
        this.FavouriteFood = fovouriteFood;
    }
    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "MEEOW";
    }
}

using System;

public class Dog : Animal
{
    public Dog(string name, string fovouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = fovouriteFood;
    }
    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAFF";

    }
}


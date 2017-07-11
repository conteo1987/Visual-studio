public abstract class Animal
{
    private string name;
    private string favouriteFood;

    public  string Name { get { return name; } set { name = value; } }
    public  string FavouriteFood { get { return favouriteFood; } set { favouriteFood = value; } }


    //public Animal(string name, string favouriteFood)
    //{
    //    this.Name = name;
    //    this.FavouriteFood = favouriteFood;
    //}

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my favorite food is {this.FavouriteFood} ";
    }

}

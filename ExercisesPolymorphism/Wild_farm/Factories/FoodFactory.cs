using Wild_farm.Models;
using Wild_farm.Models.Foods;

namespace Wild_farm
{

    public class FoodFactory
    {
        public static Food GetFood(string[] foodParams)
        {
            var foodType = foodParams[0];
            var foodQuantity = int.Parse(foodParams[1]);

            if (foodType == "Meat")
            {
                return new Meat(foodQuantity);
            }

            return new Vegetable(foodQuantity);
        }
    }
}

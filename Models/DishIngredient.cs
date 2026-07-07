namespace Menu.Models
{
    public class DishIngredient
    {
        public int DishId { get; set; }
        public string Dish { get; set; }
        public int IngredientId { get; set; }

        public Ingredient? Ingredient { get; set; }
    }
}
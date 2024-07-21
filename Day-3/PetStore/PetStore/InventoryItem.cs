using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public enum FoodType
    {
        Dry, Wet
    }

    public enum AnimalType
    {
        Dog,
        Cat, Cow

    }

    public class FoodItem : InventoryItem
    {
        public string Brand { get; set; }
        public FoodType foodType { get; set; }

        public AnimalType animalType { get; set; }
    }

    public class AccessoryItem : InventoryItem
    {
        public string Size { get; set; }
        public string Color { get; set; }

    }

    public class AquariumItem : InventoryItem
    {
        public string Capacity { get; set; }
        public string Shape { get; set; }
    }
    public class CageItem : InventoryItem
    {
        public string Dimensions { get; set; }
        public string Material { get; set; }

    }
    public class ToyItem : InventoryItem
    {
        public string Material { get; set; }
        public string RecommendedAge { get; set; }
    }
}


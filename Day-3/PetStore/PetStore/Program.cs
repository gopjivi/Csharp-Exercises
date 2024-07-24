// See https://aka.ms/new-console-template for more information
using PetStore;

List<InventoryItem> inventoryItems = new List<InventoryItem>();
string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inventory.txt");

using (StreamReader reader = new StreamReader(filePath))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] parts = line.Split(',');

        int id = int.Parse(parts[0]);
        string type = parts[1];
        string name = parts[2];
        string description = parts[3];
        decimal price = decimal.Parse(parts[4]);
        int quantity = int.Parse(parts[5]);

        InventoryItem item = null;

        switch (type)
        {
            case "Food":
                item = new FoodItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Brand = parts[6],
                    foodType = (FoodType)Enum.Parse(typeof(FoodType), parts[7]),
                    animalType = (AnimalType)Enum.Parse(typeof(AnimalType), parts[8]),
                };
                break;
            case "Accessory":
                item = new AccessoryItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Size = parts[6],
                    Color = parts[7]
                };
                break;
            case "Cage":
                item = new CageItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Dimensions = parts[6],
                    Material = parts[7]
                };
                break;
            case "Aquarium":
                item = new AquariumItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Capacity = parts[6],
                    Shape = parts[7]
                };
                break;
            case "Toy":
                item = new ToyItem
                {
                    Id = id,
                    Name = name,
                    Description = description,
                    Price = price,
                    Quantity = quantity,
                    Material = parts[6],
                    RecommendedAge = parts[7]
                };
                break;
        }

        if (item != null)
        {
            inventoryItems.Add(item);
        }

        


    }
}
bool exit = false;
while (!exit)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1- Show all items");
    Console.WriteLine("2- Show an item's details");
    Console.WriteLine("3- Purchase Item");
    Console.WriteLine("4- Exit");

    Console.Write("Select an option: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ShowAllItems(inventoryItems);
            break;
        case "2":
            ShowItemDetails(inventoryItems);
            break;
        case "3":
            PurchaseItem(inventoryItems);
            break;
        case "4":
            exit = true;
            break;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}


static void ShowAllItems(List<InventoryItem> inventory)
{
    Console.WriteLine("ID\tName\t\tType");
    foreach (var item in inventory)
    {
        string itemType = item.GetType().Name;
        Console.WriteLine($"{item.Id}\t{item.Name}\t\t{itemType}");
    }
}
static void ShowItemDetails(List<InventoryItem> inventory)
{
    Console.Write("Enter the item ID: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        InventoryItem item = inventory.Find(i => i.Id == id);
       
        if (item != null)
        {
            Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Description: {item.Description}, Price: {item.Price}, Quantity: {item.Quantity}");
           
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }
    else
    {
        Console.WriteLine("Invalid ID.");
    }
}

static void PurchaseItem(List<InventoryItem> inventory)
{
    Console.Write("Enter the item Name: ");
    string itemName = Console.ReadLine();
    if(!string.IsNullOrEmpty(itemName))
    {
        InventoryItem item = inventory.Find(i => i.Name == itemName);
        if (item != null)
        {
          //  Console.WriteLine("before purchase");
         ///   Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Description: {item.Description}, Price: {item.Price}, Quantity: {item.Quantity}");

            item.Quantity--;
          //  Console.WriteLine("after purchase");
         //   Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Description: {item.Description}, Price: {item.Price}, Quantity: {item.Quantity}");

            Console.WriteLine("Amount to be paid {0}", item.Price);

        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }
    else
    {
        Console.WriteLine("Invalid ID.");
    }
}
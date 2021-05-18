using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public DateTime ExpDate { get; set; }
            public string Description { get; set; }



            public Product(string name, decimal price, DateTime expDate, string desc)
            {
                Name = name;
                Price = price;
                ExpDate = expDate;
                Description = desc;
            }
        }


        public class Budget
        {
            public decimal MyBudget { get; set; }

            public Budget(decimal total)
            {
                MyBudget = total;
            }


            public void BuyProduct(Product prod)
            {
                MyBudget -= prod.Price;
            }

            public bool CanBuy(Product prod)
                => MyBudget - prod.Price >= 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Go shopping!\n");

            #region CreatingObjects
            List<Product> shoppingList = new List<Product>() {
                new Product("Oil", 9.78M, new DateTime(2020,05,28), "For Food"),
                new Product("Tesla", 50000M, new DateTime(2100,01,01), "Best Electro Car"),
                new Product("Pelmeni", 8.5M, new DateTime(2021,11,11), "Mtiuluri"),
                new Product("Saliami", 15.36M, new DateTime(2022, 10, 27), "Beef")
            };
            shoppingList.Add(new Product("Tea", 6.55M, new DateTime(2016, 3, 3), "With Bergamot"));

            Budget myBudget = new Budget(25.33M);
            #endregion

            #region Select
            //Query
            var expiredProducts = from item in shoppingList
                                  where item.ExpDate < DateTime.Now
                                  select item;
            foreach (var item in expiredProducts)
            {
                Console.WriteLine($"{item.Name} Has Expired!");
            }

            #endregion

            #region Where
            var expired = shoppingList.Where(item => item.ExpDate < DateTime.Now);
            foreach (var item in expired)
            {
                Console.WriteLine($"{item.Name} Has Expired!");
            }
            #endregion
            

            #region Agregate
            var allProductsNames = shoppingList
                .Select(item => item.Name)
                .Aggregate((a, b) => $"{a}, {b}");
            Console.WriteLine($"My products : {allProductsNames}");

            var totalPrice = shoppingList
                .Select(item => item.Price)
                .Sum();

            var MaxPrice = shoppingList
                .Select(item => item.Price)
                .Max();

            var MinPrice = shoppingList
                .Select(item => item.Price)
                .Min();

            Console.WriteLine($"Max : ${MaxPrice}\nMin : ${MinPrice}\nTotal : ${totalPrice}\n");
            #endregion

            #region NewObject
            var newList = shoppingList
                .Select(item => new
                {
                    Name = item.Name,
                    Desc = item.Description
                })
                .Where(item => item.Name.Equals("Tesla") || item.Name.Equals("Oil"))
                .OrderByDescending(item => item.Name)
                .ToList();

            foreach (var item in newList)
            {
                Console.WriteLine($"{item.Name} -> {item.Desc}");
            }
            #endregion

            #region What Can I buy
            var available = shoppingList.Where(item => myBudget.CanBuy(item))
                .Select(item => item.Name)
                .Aggregate((pre, after) => $"{pre}, {after}");
            Console.WriteLine($"You Can buy Individually : {available}");
            #endregion
            Console.ReadKey();



        }
    }
}

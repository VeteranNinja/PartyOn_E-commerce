using System.Collections.Generic;
using System.Data.Entity;

namespace PartyOn.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Balloons"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Gifts"
                },

                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Fancy Dress"
                },

            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Helium Balloon",
                    Description = "Balloons that make your voice go high!" +
                                  "Suck it up and have some fun!! Comes in batches of 30",
                    ImagePath="helium.jpg",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Spiderman Balloons",
                    Description = "Your Friendly Neighbourhood Spiderman!",
                    ImagePath="spiderman.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Cat Balloons",
                    Description = "Yes this cat is fast, but it also floats in water.",
                    ImagePath="cat.jpg",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Super Fast Car",
                    Description = "Use this super fast car to entertain guests. Lights and doors work!",
                    ImagePath="carfaster.png",
                    UnitPrice = 8.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Old Style Racer",
                    Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." +
                                  "No batteries required.",
                    ImagePath="carracer.png",
                    UnitPrice = 34.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Ace Plane",
                    Description = "Authentic airplane toy. Features realistic color and details.",
                    ImagePath="planeace.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Glider",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="planeglider.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Paper Plane",
                    Description = "This paper plane is like no other paper plane. Some folding required.",
                    ImagePath="planepaper.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Parrot Adult Costume",
                    Description = "colourful bird costume on the parrot!",
                    ImagePath="parrotdress.jpg",
                    UnitPrice = 32.95,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Ninja Santa Costume",
                    Description = "Festive Costume with a japanese twist!",
                    ImagePath="Ninja_santa.jpg",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Where's Wally Kid's Costume",
                    Description = "We have found Wally, and he is a kid!",
                    ImagePath="kidwally.jpg",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Kids Flower Costume",
                    Description = "This costume is great for girls!",
                    ImagePath="kidflower.jpg",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },

            };

            return products;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStoreDataGenerator.DataGenerators
{
    public class CategoriesGenerator: DataGenerator
    {
        public CategoriesGenerator(ToyStoreEntities entities, IRandomDataGenerator random, int count)
            : base(entities, random, count)
        {

        }

        public override void Generate()
        {
            Console.WriteLine("Adding categories to database");

            for (int i = 0; i < this.Count; i++)
            {
                var category = new Categories()
                {
                    Name = this.RandomGenerator.GetRandomStringWithRandomLenght(10, 30)
                };

                this.DbContext.Categories.Add(category);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.DbContext.SaveChanges();
                }
            }

            Console.WriteLine("Categories added to database");
        }
    }
}

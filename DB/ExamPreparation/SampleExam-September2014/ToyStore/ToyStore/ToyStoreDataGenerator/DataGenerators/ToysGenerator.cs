using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStoreDataGenerator.DataGenerators
{
    public class ToysGenerator : DataGenerator
    {
        public ToysGenerator(ToyStoreEntities entities, IRandomDataGenerator random, int count)
            :base(entities, random, count)
        {

        }

        public override void Generate()
        {
            Console.WriteLine("Addin toys to database");

            var ageRangeIds = this.DbContext.AgeRange.Select(a => a.Id).ToList();
            var manufacturerIds = this.DbContext.Manufacturers.Select(m => m.Id).ToList();
            var categoryIds = this.DbContext.Categories.Select(c => c.Id).ToList();

            for (int i = 0; i < this.Count; i++)
            {
                var toy = new Toys()
                {
                    Name = this.RandomGenerator.GetRandomStringWithRandomLenght(10,40),
                    Price = this.RandomGenerator.GetRandomNumber(50,200),
                    AgeRangeId = ageRangeIds[this.RandomGenerator.GetRandomNumber(0, ageRangeIds.Count - 1)],
                    CategoryID = categoryIds[this.RandomGenerator.GetRandomNumber(0,categoryIds.Count - 1)],
                    ManifacturerId = manufacturerIds[this.RandomGenerator.GetRandomNumber(0,manufacturerIds.Count - 1)]
                };

                this.DbContext.Toys.Add(toy);

                if (i % 100 == 0)
                {
                    Console.Write(".");
                    this.DbContext.SaveChanges();
                }
            }

            Console.WriteLine("Toys added to database");
        }
    }
}

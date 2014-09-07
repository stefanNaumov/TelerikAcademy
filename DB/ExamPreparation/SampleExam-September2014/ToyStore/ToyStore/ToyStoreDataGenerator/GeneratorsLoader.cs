using System;
using System.Collections.Generic;
using System.Linq;
using ToyStoreDataGenerator.DataGenerators;
using ToyStore.Data;

namespace ToyStoreDataGenerator
{
    public class GeneratorsLoader
    {
        static void Main()
        {
            var dbContext = new ToyStoreEntities();
            var random = RandomDataGenerator.Instance;
            dbContext.Configuration.AutoDetectChangesEnabled = false;

            var listOfGenerators = new List<IDataGenerator>()
            {
                new CategoriesGenerator(dbContext, random, 100),
                new AgeRangeGenerator(dbContext, random, 100),
                new ManifacturersGenerator(dbContext, random, 50),
                new ToysGenerator(dbContext, random, 20000)
            };

            foreach (var generator in listOfGenerators)
            {
                generator.Generate();
                dbContext.SaveChanges();
            }


        }
    }
}

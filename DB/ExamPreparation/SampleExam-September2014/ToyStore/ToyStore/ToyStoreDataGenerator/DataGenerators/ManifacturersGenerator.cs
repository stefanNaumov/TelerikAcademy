using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStoreDataGenerator.DataGenerators
{
    public class ManifacturersGenerator : DataGenerator
    {
        public ManifacturersGenerator(ToyStoreEntities entities, IRandomDataGenerator random, int count)
            :base(entities, random, count)
        {

        }

        public override void Generate()
        {
            Console.WriteLine("Adding Manifacturers to database");

            var uniqueManifacturersNames = new HashSet<string>();

            while (uniqueManifacturersNames.Count < this.Count)
            {
                uniqueManifacturersNames.Add(this.RandomGenerator.GetRandomStringWithRandomLenght(5,40));
            }

            int counter = 0;

            foreach (var manifacturerName in uniqueManifacturersNames)
            {
                var manifacturer = new Manufacturers()
                {
                    Name = manifacturerName,
                    Country = this.RandomGenerator.GetRandomStringWithRandomLenght(3, 40)
                };

                this.DbContext.Manufacturers.Add(manifacturer);

                if (counter % 100 == 0)
                {
                    Console.Write(".");
                    this.DbContext.SaveChanges();
                }

                counter++;
            }
        }
    }
}

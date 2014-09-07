using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStoreDataGenerator.DataGenerators
{
    public class AgeRangeGenerator : DataGenerator
    {
        public AgeRangeGenerator(ToyStoreEntities entities, IRandomDataGenerator random, int count)
            :base(entities, random, count)
        {

        }

        public override void Generate()
        {
            Console.WriteLine("Adding age ranges to database");
            int counter = 0;

            for (int i = 0; i < this.Count; i++)
            {
                for (int j = i + 1; j < i + 10; j++)
                {
                    var ageRange = new AgeRange()
                    {
                        MinAge = i,
                        MaxAge = j
                    };

                    this.DbContext.AgeRange.Add(ageRange);

                    counter++;

                    if (i % 100 == 0)
                    {
                        Console.Write(".");
                        this.DbContext.SaveChanges();
                    }

                    if (counter >= this.Count)
                    {
                        return;
                    }
                }
            }

            Console.WriteLine("Age ranges added to databse");
        }
    }
}

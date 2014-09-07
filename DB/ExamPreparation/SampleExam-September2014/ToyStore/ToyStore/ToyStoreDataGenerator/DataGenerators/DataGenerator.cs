using System;
using System.Collections.Generic;
using System.Linq;
using ToyStore.Data;

namespace ToyStoreDataGenerator.DataGenerators
{
    public abstract class DataGenerator : IDataGenerator
    {
        private ToyStoreEntities toyStoreEntitues;
        private IRandomDataGenerator randomGenerator;
        private int count;

        public DataGenerator(ToyStoreEntities entities, IRandomDataGenerator randomGenerator, int count)
        {
            this.toyStoreEntitues = entities;
            this.randomGenerator = randomGenerator;
            this.count = count;
        }

        public ToyStoreEntities DbContext
        {
            get { return this.toyStoreEntitues; }
        }

        public IRandomDataGenerator RandomGenerator
        {
            get
            {
                return this.randomGenerator;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public abstract void Generate();
    }
}

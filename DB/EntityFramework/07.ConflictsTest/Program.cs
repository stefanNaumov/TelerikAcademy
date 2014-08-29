using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Try to open two different data contexts and perform concurrent changes on the same records. 
//What will happen at SaveChanges()? How to deal with it?

namespace _07.ConflictsTest
{
    class Program
    {
        static void Main()
        {
            NorthwindEntities firstEntity = new NorthwindEntities();

            NorthwindEntities secEntity = new NorthwindEntities();

            using (firstEntity)
            {
                using (secEntity)
                {
                    Region firstReg = new Region()
                    {
                        RegionDescription = "VillageOne"
                    };
                    Region secReg = new Region()
                    {
                        RegionDescription = "VillageOne"
                    };

                    firstEntity.Regions.Add(firstReg);
                    secEntity.Regions.Add(secReg);

                    firstEntity.SaveChanges();
                    secEntity.SaveChanges();
                }
            }
        }
    }
}

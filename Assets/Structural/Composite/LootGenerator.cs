using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Composite
{
    public class LootGenerator
    {
        const int BagChance = 7;

        public ILoot Generate(int firstCount, int defaultCount)
        {
            var items = FillLootBag(firstCount, defaultCount);
            return new LootBag(items);
        }

        List<ILoot> FillLootBag(int times, int defaultCount)
        {
            List<ILoot> loot = new List<ILoot>();

            for (int i = 0; i <  times; i++)
            {
                if (Random.Range(0, 100) < BagChance)
                {
                    var bag = Generate(defaultCount, defaultCount);
                    loot.Add(bag);
                }

                else
                {
                    var coins = new Coins(GetRandomCoinsCount());
                    loot.Add(coins);
                }
            }

            return loot;
        }

        int GetRandomCoinsCount()
        {
            return 100; //Dummy. Much easier to test.
        }
    }
}

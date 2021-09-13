using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBase.Tests
{
    [TestClass()]
    public class CocktailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var cocktail = new CocktailSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 100000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            cocktail.Items.AddRange(items);
            var sorted = items.OrderBy(x => x).ToArray();

            //act
            cocktail.Sort();

            //asser
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], cocktail.Items[i]);
            }
        }
    }
}
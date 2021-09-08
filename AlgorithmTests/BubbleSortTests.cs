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
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            var bubble = new BubbleSort<int>();

            var rnd = new Random();
            for(int i = 0; i < 1; i++)
            {
                // bubble.Items.Add(rnd.Next(0, 100));
                bubble.Items.Add(98);
                bubble.Items.Add(90);
                bubble.Items.Add(77);
                bubble.Items.Add(69);
                bubble.Items.Add(56);
                bubble.Items.Add(40);
                bubble.Items.Add(35);
                bubble.Items.Add(33);
                bubble.Items.Add(24);
                bubble.Items.Add(12);

            }

            bubble.Sort();
        }
    }
}
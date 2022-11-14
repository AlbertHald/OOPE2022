using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lektion9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion9.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void IsPointInCircleTest()
        {
            Circle testCircle = new Circle(2,1,1);
            bool expected = true;
            double testX = 1;
            double testY = 1;
            bool result = testCircle.IsPointInCircle(testX,testY);
            Assert.AreEqual(expected, result);

            //Test with negative numbers
            Circle testCircle2 = new Circle(2,-1,-1);
            bool expected2 = true;
            double test2X = -1;
            double test2Y = -1;
            bool result2 = testCircle2.IsPointInCircle(test2X, test2Y);
            Assert.AreEqual(expected2, result2);
        }

        [TestMethod()]
        public void IsOverlapTest()
        {
            Assert.Fail();
        }
    }
}
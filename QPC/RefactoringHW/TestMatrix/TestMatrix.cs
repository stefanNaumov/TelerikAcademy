using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestMatrix
{
    using Matrix;
    [TestClass]
    public class TestMatrix
    {
        [TestMethod]
        //[ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestDimensions()
        {
            Matrix.GenerateMatrix("-2");
        }
    }
}

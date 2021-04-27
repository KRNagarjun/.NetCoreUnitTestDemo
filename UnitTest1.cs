using System;
using Xunit;

namespace SampleTests
{
    public class UnitTest1
    {
        [Fact]
        public void ArithmeticTests()
        {
            int i = 200;
            int j = 0;
            Assert.Throws<InvalidOperationException>(()=> i / j);
        }

        [Fact]
        public void ArrayTests()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Assert.Throws<IndexOutOfRangeException>(() => arr[5] = 6);
        }
    }
}

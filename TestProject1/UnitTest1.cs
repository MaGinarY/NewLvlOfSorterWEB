using WebApplication2;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void SorterTest()

        {
            double[] notSortedArrayDouble = { 5, 10, 1, 2 };
            double[] expected = { 1, 2, 5, 10 };


            var sortedArray = Sorter.SortDouble(notSortedArrayDouble);


            Assert.AreEqual(expected, sortedArray);
        }

        [Test]
        public void SorterTestInt()
        {
            int[] notSortedArray = { 5, 10, 1, 2 };
            int[] expectedInt = { 1, 2, 5, 10 };

            var sortedArrayInt = Sorter.Sort(notSortedArray);

            Assert.AreEqual(expectedInt, sortedArrayInt);
        }


        [Test]
        public void SorterTestChar()
        {
            char[] notSortedArrayChar = { 'b', 'a', 'd', 'c', };
            char[] expectedChar = { 'a', 'b', 'c', 'd' };

            var sortedArrayChar = Sorter.SortChar(notSortedArrayChar);

            Assert.AreEqual(expectedChar, sortedArrayChar);
        }

        [Test]
        public void SorterTestString()
        {
            string notSortedArrayString = "BANKAI";
            string expectedString = "AABIKN";

            var sortedArrayString = Sorter.SortString(notSortedArrayString);

            Assert.AreEqual(expectedString, sortedArrayString); 

        }
    }
}
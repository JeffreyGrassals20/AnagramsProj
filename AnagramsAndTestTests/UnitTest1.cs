using NUnit.Framework;
using AnagramsAndTest;

namespace AnagramsAndTestTests
{
    public class Tests
    { 
       
        [Test]
        public void Test1()
        {
            bool result = AnagramsAndTest.Program.IsAnagram("Rat", "Tar");

            Assert.IsTrue(result);
        }
    }
}
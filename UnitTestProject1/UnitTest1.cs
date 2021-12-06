using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Program program;

        [TestInitialize]
        public void Setup()
        {
            program = new Program();
        }
    }
}

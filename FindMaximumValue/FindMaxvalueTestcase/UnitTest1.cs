namespace FindMaxvalueTestcase
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
            int a = 20, b = 30, c = 4;
            
            FindMaximumValue.findmaximumInteger findmaximumInteger = new FindMaximumValue.findmaximumInteger();
            
            var findmaxvalue = findmaximumInteger.findMax(a,b,c);
            
            Assert.AreEqual(b,findmaxvalue);

        }
        [Test]
        public void Test2()
        {
            int a = 200, b = 30, c = 4;

            FindMaximumValue.findmaximumInteger findmaximumInteger = new FindMaximumValue.findmaximumInteger();

            var findmaxvalue = findmaximumInteger.findMax(a, b, c);

            Assert.AreEqual(a, findmaxvalue);

        }
        [Test]
        public void Test3()
        {
            int a = 200, b = 30, c = 400;

            FindMaximumValue.findmaximumInteger findmaximumInteger = new FindMaximumValue.findmaximumInteger();

            var findmaxvalue = findmaximumInteger.findMax(a, b, c);

            Assert.AreEqual(c, findmaxvalue);

        }
    }
}
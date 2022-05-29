namespace FindMaxvalueTestcase
{
    public class TestsInteger
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
    
    public class TestFloat
        
    {
        [Test]
        public void Testfloat1()
        {
            float A = 30.5F, B = 20.5F, C = 10.5F;
            FindMaximumValue.findmaximumInteger findmaximumInteger = new FindMaximumValue.findmaximumInteger();
            var findmaxvalue = findmaximumInteger.FindMaxFloat(A, B, C);
            Assert.AreEqual(A, findmaxvalue);
        }
        [Test]
        public void Testfloat2()
        {
            float A = 10.5F, B = 30.5F, C = 20.5F;
            FindMaximumValue.findmaximumInteger findmaximumInteger = new FindMaximumValue.findmaximumInteger();
            var findmaxvalue = findmaximumInteger.FindMaxFloat(A, B, C);
            Assert.AreEqual(B, findmaxvalue);
        }
        [Test]
        public void Testfloat3()
        {
            float A = 10.5F, B = 20.5F, C = 30.5F;
            FindMaximumValue.findmaximumInteger findmaximumInteger = new FindMaximumValue.findmaximumInteger();
            var findmaxvalue = findmaximumInteger.FindMaxFloat(A, B, C);
            Assert.AreEqual(C, findmaxvalue);
        }
    }

}
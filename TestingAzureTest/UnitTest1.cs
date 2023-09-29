namespace TestingAzureTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            
            Adding adding = new Adding();
            Assert.Equal(3, adding.TryAdd(1, 2));
        }
    }
}
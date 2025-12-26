using Tyuiu.KislayaVA.Sprint6.Task6.V18.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Вера Кислая\source\repos\Tyuiu.KislayaVA.Sprint6\Files\TestDataTask6.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "an bbbn n aaaaaaaaaaaaan";
            Assert.AreEqual(wait, res);
        }
    }
}

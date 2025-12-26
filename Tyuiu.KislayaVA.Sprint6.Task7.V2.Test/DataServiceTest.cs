using Tyuiu.KislayaVA.Sprint6.Task7.V2.Lib;
namespace Tyuiu.KislayaVA.Sprint6.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            string path = @"C:\Users\Вера Кислая\source\repos\Tyuiu.KislayaVA.Sprint6\Files\TestDataTask7.csv";
            string fileData = File.ReadAllText(path);
            int[,] result = ds.GetMatrix(path);
            int[,] wait =
            {
                {1, 1, 2, 3, 4},
                {555, 1, 555, 1, 555},
                {1, 1, 1, 1, 1},
                {2, 4, 4, 4, 2},
                {5, 1, 3, 5, 2}

            };
            CollectionAssert.AreEqual(wait, result);
        }
    }
}

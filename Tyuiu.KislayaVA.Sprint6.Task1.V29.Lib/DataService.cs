using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KislayaVA.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1 != 0)
                {
                    vallueArray[count] = Math.Round(Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x, 2);
                    count++;
                }
                else
                {
                    vallueArray[count] = 0;
                    count++;
                }
            }
            return vallueArray;
        }
    }
}

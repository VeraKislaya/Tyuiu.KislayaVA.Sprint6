using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KislayaVA.Sprint6.Task5.V7.Lib
{
    public class DataService : ISprint6Task5V7

    {
        public double[] LoadFromDataFile(string path)
        {

            List<double> res = new List<double>();
            using (StreamReader sReader = new StreamReader(path))
            {
                string line;
                while ((line = sReader.ReadLine()) != null)
                {
                    line = line.Replace(".", ",");
                    string[] num = line.Split(' ');
                    double[] data = new double[num.Length];
                    foreach (string s in num)
                    {
                        double d = double.Parse(s);
                        if (d > 5)
                        {
                            res.Add(d);
                        }
                        else continue;
                    }

                }

            }
            double[] result = res.ToArray();
            return result;


        }
    }
}

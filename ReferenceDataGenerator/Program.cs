using System;
using System.IO;
using System.Text;

namespace ReferenceDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] cashRefData = new int[100][];
            int[][] equityRefData = new int[100][];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                cashRefData[i] = new int[100];
                Random random = new Random();

                for (int j = 0; j < 100; j++)
                {
                    if (i < 10)
                    {
                        cashRefData[i][j] = random.Next(-50, 50);
                    }
                    else if(i >= 10 && i < 20)
                    {
                        cashRefData[i][j] = random.Next(-25, 150);
                    }
                    else if (i >= 20 && i < 40)
                    {
                        cashRefData[i][j] = random.Next(-10, 300);
                    }
                    else if (i >= 40)
                    {
                        cashRefData[i][j] = random.Next(0, 600);
                    }
                    //cashRefData[i][j] = random.Next(-90, 300);
                    if (j == 0)
                    {
                        sb.Append(cashRefData[i][j]);
                    }
                    else
                    {
                        sb.Append("," + cashRefData[i][j]);
                    }
                }
                sb.AppendLine();


            }
            string filePath = @"C:\DevFolder\CashRefData.csv";

            File.WriteAllText(filePath, sb.ToString());
            sb.Clear();
            for (int i = 0; i < 100; i++)
            {
                equityRefData[i] = new int[100];
                Random random = new Random();

                for (int j = 0; j < 100; j++)
                {
                    if (i < 10)
                    {
                        equityRefData[i][j] = random.Next(-50, 50);
                    }
                    else if (i >= 10 && i < 20)
                    {
                        equityRefData[i][j] = random.Next(-25, 150);
                    }
                    else if (i >= 20 && i < 40)
                    {
                        equityRefData[i][j] = random.Next(-10, 300);
                    }
                    else if (i >= 40)
                    {
                        equityRefData[i][j] = random.Next(-10, 600);
                    }
                    if (j == 0)
                    {
                        sb.Append(equityRefData[i][j]);
                    }
                    else
                    {
                        sb.Append("," + equityRefData[i][j]);
                    }
                }
                sb.AppendLine();


            }
            string equityFilePath = @"C:\DevFolder\EquityRefData.csv";
            File.WriteAllText(equityFilePath, sb.ToString());
        }
    }
}

﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KruchininEP.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int i = 1;

            while (i <= 10)
            {
                sum = sum + Math.Pow(1.0 / i, 2);
                i++;
            }

            return Math.Round(sum, 3);
        }
    }
}
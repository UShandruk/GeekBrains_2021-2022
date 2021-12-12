using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class DataStorage
    {
        public static List<PointClassFloat> GetPointClassFloatList()
        {
            List<PointClassFloat> pointClassFloatList = new List<PointClassFloat>();
            pointClassFloatList.Add(new PointClassFloat(1.1f, 5.4f));
            pointClassFloatList.Add(new PointClassFloat(20.5f, 4.9f));
            return pointClassFloatList;
        }

        public static List<PointStructDouble> GetPointStructDoubleList()
        {
            List<PointStructDouble> pointStructDoubleList = new List<PointStructDouble>();
            pointStructDoubleList.Add(new PointStructDouble(1.1, 5.4));
            pointStructDoubleList.Add(new PointStructDouble(20.5, 4.9));
            return pointStructDoubleList;
        }

        public static List<PointStructFloat> GetPointStructFloatList()
        {
            List<PointStructFloat> pointStructFloatList = new List<PointStructFloat>();
            pointStructFloatList.Add(new PointStructFloat(1.1f, 5.4f));
            pointStructFloatList.Add(new PointStructFloat(20.5f, 4.9f));
            return pointStructFloatList;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public struct Point
    {
        public float X;
        public float Y;
    }

    public struct Category
    {
        public string Label;
        public float Value;
    }

    public struct Seria<T>
    {
        public T[] Points;
        public int Count;
    }

    public struct Graph<T>
    {
        public string Name;
        public string Description;
        public GraphType Type;
        public Seria<T>[] Series;

        public static GraphType ConvertGraphType(string type)
        {
            switch (type)
            {
                case "Линия": return GraphType.Line;
                case "Точечная диаграмма": return GraphType.Scatter;
                case "Столбчатая диаграмма": return GraphType.Bar;
                default: return GraphType.None;
            }
        }

        public static string ConvertGraphType(GraphType type)
        {
            switch (type)
            {
                case GraphType.Line: return "Линия";
                case GraphType.Scatter: return "Точечная диаграмма";
                case GraphType.Bar: return "Столбчатая диаграмма";
                default: return "";
            }
        }
        

        public static string[] AllTypesNames()
        {
            Array values = Enum.GetValues(typeof(GraphType));
            List<string> names = new List<string>();

            foreach (object value in values)
            {
                GraphType type = (GraphType)value;
                if (type != GraphType.None)
                {
                    names.Add(ConvertGraphType(type));
                }
            }

            return names.ToArray();
        }

        public static string[] AllTypesNames(Func<GraphType, bool> filter)
        {
            Array values = Enum.GetValues(typeof(GraphType));
            List<string> names = new List<string>();

            foreach (object value in values)
            {
                GraphType type = (GraphType)value;
                if (filter(type) && type != GraphType.None)
                {
                    names.Add(ConvertGraphType(type));
                }
            }

            return names.ToArray();
        }

        public static bool IsCategoricalType(GraphType type)
        {
            GraphType[] CategoricalTypes = new GraphType[] { GraphType.Bar};
            return CategoricalTypes.Contains(type);
        }

    }

    public enum GraphType
    {
        None = 0,
        Line = 1,
        Scatter = 2,
        Bar = 3
    }

}

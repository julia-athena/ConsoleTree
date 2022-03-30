using System.Text;

namespace Tree
{
    internal class ConsoleTree
    {
        private int Size;
        public ConsoleTree(int size)
        {
            Size = size;
        }

        public string AsStringOne()
        {
            var sb = new StringBuilder("");
            for (int i = 1; i <= Size; i++)
            {
                sb.AppendLine(new String('*', i));
            }
            return sb.ToString();
        }
        public string AsStringTwo()
        {
            Size = Size % 2 == 0 ? Size + 1 : Size;
            var level = Size / 2 + 1;
            var format = "{0," + level.ToString() + "}" + "{1," + "-" + level.ToString() + "}";
            var sb = new StringBuilder("");
            for (int i = 1; i <= level; i++)
            {
                sb.AppendLine(String.Format(format, new String('*', i), new String('*', i - 1)));
            }
            return sb.ToString();
        }
    }
}

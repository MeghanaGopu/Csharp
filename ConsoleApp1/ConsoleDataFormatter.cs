using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConsoleDataFormatter
    {
        private const int TableWidth = 90;
        

        public static void PrintSeperatorLine()
        {
            Console.WriteLine(new string('-', TableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int columnWidth = (TableWidth - columns.Length) / columns.Length;
            const string columnSeperator = "|";
            string row = columns.Aggregate(columnSeperator, (seperator, columnText) => seperator + GetCenterAlignedText(columnText, columnWidth) + columnSeperator);
            Console.WriteLine(row);

        }

        private static string GetCenterAlignedText(string columnText, int columnWidth)
        {
            columnText = columnText.Length > columnWidth ? columnText.Substring(0, columnWidth - 3) + "..." : columnText;

            return string.IsNullOrEmpty(columnText)
                ? new string(' ', columnWidth)
                : columnText.PadRight(columnWidth - ((columnWidth - columnText.Length) / 2)).PadLeft(columnWidth);

        }

    
    }
}

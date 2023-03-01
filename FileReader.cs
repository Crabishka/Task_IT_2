using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_IT_2
{
    class FileReader
    {


        public String GetLine(String path, int k)
        {
            using(var reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int i = 1;
                while (line != null && i < k)
                {
                    if (i < k)
                    {
                        line = reader.ReadLine();
                    } else if (i == k)
                    {
                        line = reader.ReadLine();
                        break;
                    }
                    i++;
                }
                return line is null ? "" : line;
            }
        }
    }
}

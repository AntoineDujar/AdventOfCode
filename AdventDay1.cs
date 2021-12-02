/*using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace testing
{
    class AdventDay1
    {
        public static void Main()
        {
            List<int> i = new List<int>();
            int counter = 0;

            using (StreamReader sr = new StreamReader("inputday1.txt"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    i.Add(Convert.ToInt32(line));

                }
            }

            List<int> u = new List<int>(i.Count);

            for (int y = 0; y < i.Count; y ++)
            {
                //Console.Write("["+y+"]");
                //Console.WriteLine(i[y]);
                if(y>1)
                {
                    u.Add(i[y] + i[y - 1] + i[y - 2]);
                }
            }

            for (int yy = 0; yy < u.Count; yy++)
            {
                Console.WriteLine(u[yy]);
                if(yy > 0)
                {
                    if(u[yy] > u[yy-1])
                    { counter++; }
                }
            }

            Console.WriteLine(counter);
            
        }
    }
}
*/
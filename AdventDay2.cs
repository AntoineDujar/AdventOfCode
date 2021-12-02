using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace testing
{
    class AdventDay2
    {
        public static void Main()
        {
            List<string> i = new List<string>();

            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            using (StreamReader sr = new StreamReader("inputday2.txt"))
            {
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(line);
                    i.Add(line);

                }
            }

            List<int> u = new List<int>(i.Count);

            for (int y = 0; y <i.Count; y++)
            {
                char c = i[y][i[y].Length - 1];
                u.Add(Convert.ToInt32(Convert.ToString(c)));
                //Console.WriteLine(u[y]);
                i[y] = i[y].Replace(i[y][i[y].Length - 1],'e');
            }

            for (int x = 0; x < i.Count; x++)
            {
                if(i[x] == "forward e")
                {
                    horizontal = horizontal + u[x];
                    depth = depth + (aim * u[x]);
                } else
                {
                    if(i[x] == "down e")
                    {
                        //depth = depth + u[x];
                        aim = aim + u[x];
                    } else
                    {
                        if (i[x] == "up e")
                        {
                            //depth = depth - u[x];
                            aim = aim - u[x];
                        }
                        
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine("Horizontal depth = {0}",horizontal);
            Console.WriteLine("Depth = {0}",depth);
            Console.WriteLine("Final Depth = {0}", depth*horizontal);
            Console.WriteLine("Aim is = {0}", aim);
        }
    }
}
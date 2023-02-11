using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestPair
{
    public class highestPairClass
    {
        public object results(string paired)
        {
            if (paired == "")
            {
                Console.WriteLine(false);

                return false;
            }
            else
            {
                Console.WriteLine("[true, \"{0}\"]", paired);

                return new object[] { true, paired };
            }
        }

        public string paired(string[] array)
        {
            bool boolean = false;
            string paired = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (boolean == true)
                {
                    break;
                }
                else
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            paired = array[i];
                            boolean = true;
                            break;
                        }
                    }
                }
            }
            return paired;
        }

        public object highestPair(string[] array)
        {
            string pair = paired(array);

            object result = results(pair);

            return result;
        }
    }
}

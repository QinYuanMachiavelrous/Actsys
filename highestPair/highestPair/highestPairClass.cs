using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestPair
{
    public class highestPairClass
    {
        public object results(string paired) //8) results method is used to determine whether any pair is found.
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

        public string paired(string[] array) //4) paired method here is to go through the cards and see which one pairs and then check if the ranking of the pairs. 
        {
  
            string paired = "";
            string stringsofar = "";

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        paired = array[i];
                        break;
                    }

                    else
                    {
                        continue;
                    }

                }

                stringsofar = checkifhighest(paired, stringsofar); //5) checkifhighest is the method used to sort out ranking of the pairs.

            }
            return stringsofar;
        }


        public string checkifhighest(string paired, string stringsofar)
        {
            Cards cardranking = new Cards(); //6) Instantiate the sorted list from Cards.cs

            if (stringsofar == "" || cardranking.cards[paired] > cardranking.cards[stringsofar]) //7) Condition here to check the ranking.
            {
                return paired;
            }
            else
            {
                return stringsofar;
            }
            
        }

        public object highestPair(string[] array) //3) highestPair method is here! 
        {
            string pair = paired(array);

            object result = results(pair);

            return result;
        }
    }
}

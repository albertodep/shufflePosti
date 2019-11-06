using System;

namespace Shuffle_Posti
{
    class Program
    {
        static void Main(string[] args)
        {

            static void appendGenderPrefix(string name, bool IsMale)
                {
                string prefix;
                if (Ismale)
                    prefix = "Mr ";
                else
                    prefix = "Miss ";
                }
            Console.WriteLine(prefix + name);

            string monoLinePrefix = (Ismale ? "Mr ": "Miss ");
            Console.WriteLine(monoLinePrefix);

            appendGenderPrefix("Giovanni")



            string[] arrayStudents = { 
                "Simone G",
                "Giulia O",
                "Andrea B",
                "Andrea G",
                "Andrea C",
                "Lorena S",
                "Elia G",
                "Stefano M",
                "Stefano B",
                "Alessio T",
                "Alberto D",
                "Paolo I" };

            Random rand = new Random();

            for (int i = 0; i < arrayStudents.Length - 1; i++)
            {
                int j = rand.Next(i, arrayStudents.Length);
                string temp = arrayStudents[i];
                arrayStudents[i] = arrayStudents[j];
                arrayStudents[j] = temp;
                //Console.WriteLine(arrayStudents[i]);
                //Console.WriteLine(arrayStudents[j]);
            }

            //int k;
            //for(k=0; k < arrayStudents.Length; k++)
            //{
            //    Console.WriteLine(arrayStudents[k]  + " " +   arrayStudents[k+1] ); 
            //    k++;
            //}

            int z = arrayStudents[0].Length;
                Console.WriteLine(z);


            int k;
            for (k = 0; k < arrayStudents.Length; k++)
            {
                Console.WriteLine(arrayStudents[k] + " " + arrayStudents[k + 1] + " ____ " + arrayStudents[k+2] + " " + arrayStudents[k + 3]);
                k = (k+3);
            }


        }
    }
}

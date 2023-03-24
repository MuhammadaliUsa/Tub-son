
namespace Tub_son
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, countt=0;
            Console.Write("Enter the number: ");
            number=int.Parse(Console.ReadLine());
            for (int i = 1; i <=number;i ++)
            {
                  if(number%i==0)
                  {
                    countt++;
                  }


            }
            if(countt==2) 
            {

                Console.WriteLine("Tub son!");

            }
            else
            {
                Console.WriteLine("Tub emas!");
            }
        }
    }
}
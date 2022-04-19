namespace ConsoleApp1
{
    class Program
    {
        internal static void emp()
        {   //constraints 
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random obj = new Random();
            int empcheck = obj.Next(0, 2);

            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("present ");
                emphrs = 8;

            }
            else if(empcheck == IS_PART_TIME) { emphrs = 4; }
            else
            {
                Console.WriteLine("not present");
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" + empwage);
        }

    }
}
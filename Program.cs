namespace assignment_c__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region asks the user to input three points
            Console.WriteLine("Enter coordinates for point 1 (x1 y1):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinates for point 2 (x2 y2):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinates for point 3 (x3 y3):");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            // Use cross multiplication to check collinearity
            double leftSide = (y2 - y1) * (x3 - x2);
            double rightSide = (y3 - y2) * (x2 - x1);
            if (leftSide == rightSide)
            {
                Console.WriteLine("these points lie on a single straight line.");

            }
            else
            {
                Console.WriteLine("these points do not lie on a single straight line.");
            }


            #endregion

            #region the time taken for the task
            Console.WriteLine("Enter Time taken for the task by hours");
            double timeTaken = double.Parse(Console.ReadLine());
            if (timeTaken >= 2 && timeTaken <= 3)
            {
                Console.WriteLine("you are highly efficient.");
            }
            else if (timeTaken >= 3 && timeTaken <= 4)
            {
                Console.WriteLine("you are instructed to increase your speed.");
            }
            else if (timeTaken >= 4 && timeTaken <= 5)
            {
                Console.WriteLine("you are provided with training to enhance your speed.");
            }
            else
            {
                Console.WriteLine("you are required to leave the company.");
            }
            #endregion



        }
    }
}

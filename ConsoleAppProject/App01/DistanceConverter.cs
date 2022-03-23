namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;

        private double feet;

        public void Run()
        {
            InputMiles();
            CalulateFeet();
            OutputFeet();
        }
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string.value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        private void CalulateFeet()
        {

        }
        private void OutputFeet()
        {

        }
    }
}

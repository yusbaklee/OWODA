namespace OWO_DA
{
    public class Transporter
    {
        public string member;
        public double Vehicle(int vType)
        {
            double total = 0;
            for(int i = 0; i < 5; i++)
            {

                double fee;

                Console.WriteLine("OWO DA APP");
                Console.WriteLine("Tricyle=1");
                Console.WriteLine("Motorcyle=2");
                Console.WriteLine("Minibus=3");
                Console.WriteLine("Bus=4");
                Console.WriteLine("What is the Vehicle Type? ");
                int vehicleType = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many trips? ");
                int trips = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Are you a member? Y/N");
                member = Console.ReadLine();

                if (vType == 1)
                {
                    fee = 100;
                }
                else if (vType == 2)
                {
                    fee = 200;
                }
                else if (vType == 3)
                {
                    fee = 250;
                }
                else if (vType == 4)
                {
                    fee = 300;
                }
                else
                {
                    fee = 200;
                }

                if (member == "Y")
                {
                    fee = fee * 0.7;
                }
                else
                {
                    fee = fee;
                }

                fee = fee * trips;

                total += fee;

                Console.WriteLine("total fee is " + fee);

            }

            Console.WriteLine("total amount collected today is " + total);

            


            return 0;
        }




        static void Main(string[] args)
        {
            var finalAnswer = new Transporter();

            double final = finalAnswer.Vehicle(1);



        }

    }
}

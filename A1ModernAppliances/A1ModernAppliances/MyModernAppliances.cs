using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    internal class MyModernAppliances : ModernAppliances
    {
        public override void Checkout()
        {
            Console.WriteLine("Enter the item number of an appliance: ");
            long itemNumber;
            string userInput = Console.ReadLine();
            itemNumber = long.Parse(userInput);
            List<Appliance> found = new List<Appliance>();
            foreach (Appliance appliance in Appliances)
            {
                if (appliance.ItemNumber == itemNumber)
                {
                    found.Add(appliance);
                    break;
                }
            }
            if (found.Count == 0)
            {
                Console.WriteLine("No appliances found with that item number");
                return;
            }

            Appliance check = found[0];
            if (check.IsAvailable)
            {
                check.Checkout();
                Console.WriteLine($"Appliance with item number {itemNumber} has been checked out");
            }
            else
            {
                Console.WriteLine("The appliance is not available to be checked out.");
            }

        }

        public override void Find()

        {
            Console.WriteLine("Enter brand to search for:");
            string userEnteredBrand;
            userEnteredBrand = Console.ReadLine();
            List<Appliance> found = new List<Appliance>();
            foreach (var appliance in Appliances)
            {
                if (appliance.Brand == userEnteredBrand)
                {
                    found.Add(appliance);
                }
            }
            DisplayAppliancesFromList(found, 0);
        }
        public override void DisplayRefrigerators()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any\n2 - Double doors\n3 - three doors\n4 - Four doors ");
            Console.WriteLine("Enter numbers of doors:");
            string enteredNumber;

            string userInput = Console.ReadLine();

            int numberOfDoors = Convert.ToInt32(userInput);

            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;

                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors)
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
        }
        public override void DisplayVacuums()
        {
            Console.WriteLine("Possible options:");

            Console.WriteLine("0 - Any\n1 - residential\n2 - Commercial");

            Console.WriteLine("Enter grade:");


            string userInputGrade = Console.ReadLine();


            string grade;

            if (userInputGrade == "0")
            {
                grade = "Any";
            }
            else if (userInputGrade == "1")
            {
                grade = "Residential";
            }
            else if (userInputGrade == "2")
            {
                grade = "Commercial";
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            Console.WriteLine("Possible options:");


            Console.WriteLine("0 - Any\n1 - 18 Volt\n2 - 24 Volt");

            Console.WriteLine("Enter volatage:");

            string userInputVoltage = Console.ReadLine();

            short Voltage;

            if (userInputVoltage == "0")
            {
                Voltage = 0;
            }
            else if (userInputVoltage == "1")
            {
                Voltage = 18;
            }
            else if (userInputVoltage == "2")
            {
                Voltage = 24;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }


            List<Appliance> found = new List<Appliance>();


            foreach (var appliance in Appliances)
            {
                if (appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;

                    if ((grade == "Any" || grade == vacuum.Grade) && (Voltage == 0 || Voltage == vacuum.BatteryVoltage))
                    {
                        found.Add(vacuum);
                    }
                }

            }

            DisplayAppliancesFromList(found, 0);
        }


        public override void DisplayMicrowaves()
        {
            Console.WriteLine("Possible options:");


            Console.WriteLine("0 - Any\n1 - Kitchen\n2 - Work site");


            Console.WriteLine("Enter room type:");


            string userInput = Console.ReadLine();
            char roomType;


            if (userInput == "0")
            {
                roomType = 'A';
            }
            else if (userInput == "1")
            {
                roomType = 'K';
            }
            else if (userInput == "2")
            {
                roomType = 'W';
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }



            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if (roomType == 'A' || roomType == microwave.RoomType)
                    {
                        found.Add(microwave);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
        }


        public override void DisplayDishwashers()
        {
            Console.WriteLine("Possible options:");


            Console.WriteLine("0 - Any\n1 - Quiestest\n2 - Quieter\n3 - Quiet\n4 - Moderate");

            Console.WriteLine("Enter sound rating:");

            string userInput = Console.ReadLine();

            string soundRating;

            if (userInput == "0")
            {
                soundRating = "Any";
            }
            else if (userInput == "1")
            {
                soundRating = "Qt";
            }
            else if (userInput == "2")
            {
                soundRating = "Qr";
            }
            else if (userInput == "3")
            {
                soundRating = "Qu";
            }
            else if (userInput == "4")
            {
                soundRating = "M";
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (soundRating == "Any" || dishwasher.SoundRating == soundRating)
                    {
                        found.Add(dishwasher);
                    }
                }
            }


            DisplayAppliancesFromList(found, 0);
        }



        public override void RandomList()
        {
            Console.WriteLine("Appliance Types");

            Console.WriteLine("0 - Any\n1 - Refrigerators\n2 - Vacuums\n3 - Microwaves\n4 - Dishwashers");

            Console.WriteLine("Enter type of appliance:");

            string userInputType = Console.ReadLine();

            Console.WriteLine("Enter number of appliances:");

            string numberOfAppliancesInput = Console.ReadLine();

            int userInputNumberOfAppliances = Convert.ToInt32(numberOfAppliancesInput);

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances)
            {
                if (userInputType == "0")
                {
                    found.Add(appliance);
                }
                else if (userInputType == "1" && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (userInputType == "2" && appliance is Vacuum)
                {
                    found.Add(appliance);
                }
                else if (userInputType == "3" && appliance is Microwave)
                {
                    found.Add(appliance);
                }
                else if (userInputType == "4" && appliance is Dishwasher)
                {
                    found.Add(appliance);
                }
            }

            found.Sort(new RandomComparer());


            DisplayAppliancesFromList(found, userInputNumberOfAppliances);
        }
    }
}

using FinchAPI;
using System;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with the helper methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Velis, John
    // Dated Created: 1/22/2020
    // Last Modified: 1/25/2020
    //
    // **************************************************

    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) ");
                Console.WriteLine("\td) ");
                Console.WriteLine("\te) ");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        DisplayTalentShowMenuScreen(finchRobot);
                        break;

                    case "c":
                        
                        break;

                    case "d":
                       
                        break;

                    case "e":

                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }



        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void DisplayTalentShowMenuScreen(Finch myFinch)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Lights and Sounds");
                Console.WriteLine("\tb) On the Move");
                Console.WriteLine("\tc) Patterns of Geometry");
                Console.WriteLine("\td) ");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        LightsAndSounds(myFinch);
                        break;

                    case "b":
                        OnTheMove(myFinch);
                        break;

                    case "c":

                        break;

                    case "d":

                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        //static void DisplayLightAndSound(Finch myFinch)
        //{
        //    Console.CursorVisible = false;

        //    DisplayScreenHeader("Light and Sound");

        //    Console.WriteLine("\tThe Finch robot will now show off its glowing talent!");
        //    DisplayContinuePrompt();

        //    for (int lightSoundLevel = 200; lightSoundLevel < 255; lightSoundLevel++)
        //    {
        //        myFinch.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
        //        myFinch.noteOn(lightSoundLevel * 10);
        //    }

        //    DisplayMenuPrompt("Talent Show Menu");
        //}

        static void LightsAndSounds(Finch myFinch)
        {
            Console.CursorVisible = false;

            bool quitLightsAndSoundsMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Lights and Sounds Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Mario Theme");
                Console.WriteLine("\tb) Mario 3 Theme");
                Console.WriteLine("\tc) ");
                Console.WriteLine("\td) ");
                Console.WriteLine("\tq) Talent Show Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        MarioOne(myFinch);
                        break;

                    case "b":
                        MarioThree(myFinch);
                        break;

                    case "c":
                        ColorScale(myFinch);
                        break;

                    case "d":

                        break;

                    case "q":
                        quitLightsAndSoundsMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitLightsAndSoundsMenu);
        }

        static void ColorScale(Finch myFinch)
        {

        }

        static void MarioOne(Finch myFinch)
        {
            int userColorOne;
            int userColorTwo;
            int userColorThree;
            string userResponse;

            Console.CursorVisible = true;

            Console.WriteLine("Yo Mario, Choose a color!");
            Console.WriteLine("Type a number between 0 - 255 for each section.");
            Console.WriteLine("For example: Red is 255-0-0, Green is 0-255-0, Blue is 0-0-255, Yellow is 255, 255, 0.");

            Console.Write("First Number:");

            userResponse = Console.ReadLine();
            userColorOne = int.Parse(userResponse);

            Console.Write($"Second Number: ({userColorOne},    ,    )");

            userResponse = Console.ReadLine();
            userColorTwo = int.Parse(userResponse);

            Console.Write($"Second Number: ({userColorOne}, {userColorTwo},    )");

            userResponse = Console.ReadLine();
            userColorThree = int.Parse(userResponse);

            Console.WriteLine($" Your Color is ({userColorOne}, {userColorTwo}, {userColorThree})");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(175);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(175);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(300);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(167);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(175);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(175);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(175);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(375);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(375);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(25);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(25);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(330);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(466);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(42);
            // .42

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(330);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(466);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(42);
            // .42

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(375);
            // .375

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(42);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(622);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(167);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(415);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            //wait .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(42);
            //wait .42

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(622);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(167);
            // .167

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            //.125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(625);
            // .625

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(42);
            // .42

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(622);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(167);
            // .167

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(415);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(622);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(113);
            // .1125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(42);
            // .42

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(622);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(167);
            // .167

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(415);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(42);
            // .42

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(622);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(167);
            // .167

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(625);
            // .625

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(698);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(42);
            // .42

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(622);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(167);
            // .167

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(415);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(125);
            // .125

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(622);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.wait(250);
            // .250

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(125);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

        }

        static void MarioThree(Finch myFinch)
        {
            int userColorOne;
            int userColorTwo;
            int userColorThree;
            string userResponse;

            Console.CursorVisible = true;

            Console.WriteLine("Yo Mario, Choose a color!");
            Console.WriteLine("Type a number between 0 - 255 for each section.");
            Console.WriteLine("For example: Red is 255-0-0, Green is 0-255-0, Blue is 0-0-255.");

            Console.Write("First Number:");

            userResponse = Console.ReadLine();
            userColorOne = int.Parse(userResponse);

            Console.Write($"Second Number: ({userColorOne},    ,    )");

            userResponse = Console.ReadLine();
            userColorTwo = int.Parse(userResponse);

            Console.Write($"Second Number: ({userColorOne}, {userColorTwo},    )");

            userResponse = Console.ReadLine();
            userColorThree = int.Parse(userResponse);

            Console.WriteLine($" Your Color is ({userColorOne}, {userColorTwo}, {userColorThree})");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(480);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1568);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1568);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1568);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(370);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(370);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(196);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(84);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(831);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(980);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(988);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);
            //time sleep?

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1180);
            myFinch.wait(10);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1174);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1480);
            myFinch.wait(10);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1568);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);
            //time sleep?

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(988);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(587);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(349);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(330);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(532);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(466);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1760);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1568);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(349);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(415);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1397);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(349);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(330);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(311);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(330);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(400);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(523);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(880);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1760);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(494);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();


            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(1568);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(349);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(440);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(659);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(699);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(740);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(784);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(392);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(196);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(196);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(196);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(185);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(196);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(185);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(196);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(208);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(220);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(233);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            myFinch.setLED(userColorOne, userColorTwo, userColorThree);
            myFinch.noteOn(247);
            myFinch.wait(200);
            myFinch.noteOff();
            myFinch.setLED(0, 0, 0);

            //for (int frequency = 0; frequency < 20000; frequency = frequency + 100)
            //{
            //    myFinch.noteOn(frequency);
            //    myFinch.wait(2);
            //    myFinch.noteOff();
            //}

            //for (int count = 0; count < 10; count++)
            //{
            //    myFinch.noteOn(261);
            //    myFinch.wait(200);
            //    myFinch.noteOff();
            //    myFinch.wait(200);
            //}
        }

        static void OnTheMove(Finch myFinch)
        {
            Console.CursorVisible = true;

            bool quitOnTheMoveMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("On The Move Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Back and Forth");
                Console.WriteLine("\tb) Circles");
                Console.WriteLine("\tc) Waddle");
                Console.WriteLine("\td) ");
                Console.WriteLine("\tq) Talent Show Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        BackAndForth(myFinch);
                        break;

                    case "b":
                        Circles(myFinch);
                        break;

                    case "c":
                        Waddle(myFinch);
                        break;

                    case "d":

                        break;

                    case "q":
                        quitOnTheMoveMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitOnTheMoveMenu);
        }

        static void BackAndForth(Finch myFinch)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Forwards then Backwards");

            Console.WriteLine("\tThe Finch robot will now move Back and Forth!");
            DisplayContinuePrompt();

            myFinch.setMotors(255, 255);
            myFinch.wait(2000);
            myFinch.setMotors(-255, -255);
            myFinch.wait(2000);
            myFinch.setMotors(0, 0);
            myFinch.wait(500);

            DisplayMenuPrompt("On the Move Menu");
        }

        static void Circles(Finch myFinch)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Back and Forth");

            Console.WriteLine("\tThe Finch robot will now move Back and Forth!");
            DisplayContinuePrompt();

            myFinch.setMotors(-255, 255);
            myFinch.wait(2000);
            myFinch.setMotors(255, -255);
            myFinch.wait(2000);
            myFinch.setMotors(0, 0);

            DisplayMenuPrompt("On the Move Menu");
        }

        static void Waddle(Finch myFinch)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Back and Forth");

            Console.WriteLine("\tThe Finch robot will now move Back and Forth!");
            DisplayContinuePrompt();

            myFinch.setMotors(-255, 200);
            myFinch.wait(500);
            myFinch.setMotors(200, -255);
            myFinch.wait(500);
            myFinch.setMotors(-255, 200);
            myFinch.wait(500);
            myFinch.setMotors(200, -255);
            myFinch.wait(500);
            myFinch.setMotors(-255, 200);
            myFinch.wait(500);
            myFinch.setMotors(200, -255);
            myFinch.wait(500);
            myFinch.setMotors(0, 0);
            myFinch.wait(500);

            DisplayMenuPrompt("On the Move Menu");
        }
        #endregion       

        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}
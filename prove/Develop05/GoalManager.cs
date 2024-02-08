using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>(); // List to save the Goals for the session.
    private int _score; // Keeping score.

    public GoalManager() // Constructor set in 0 for default.
    {
        _score = 0;
    }

    public void Start() // Start de menu for te program.
    {
        Console.WriteLine("Welcome to the Eternal Quest Program"); // Welcome message.
        string choice; // Creating a variable for the choice on the menu.

        do // Prompt the user to make a decision based on the following options.
        {
            DisplayPlayerInfo(); // Display player info: score.
            Console.WriteLine("\nMenu Options:"); // Explanatory message.
            Console.WriteLine("  1. Create New Goal \n  2. List Goals \n  3. Save Goals \n  4. Load Goals \n  5. Record Event \n  6. Quit"); // Options.
            Console.Write("Select a choice from the menu: "); // Prompting.

            choice = Console.ReadLine(); // Saving user's input.
            
            switch (choice) // Using the switch to visualize the options in an easier way with the decision on the choice.
            {
                case "1": // 
                    CreateGoal();
                    break;

                case "2": // 
                    ListGoalDetails();
                    break;

                case "3": // 
                    SaveGoals();
                    break;

                case "4": // 
                    LoadGoals();
                    break;
                
                case "5": // 
                    RecordEvent();
                    break;

                case "6": // 
                    Console.WriteLine("Bye, see you later!"); // Goodbye message.
                    break;

                default:
                Console.ForegroundColor = ConsoleColor.Red; // Change letters color to red.
                Console.WriteLine("That's not a valid option."); // In case the user input doesn't satisfy the options, display a message to prompt the user for a valid option.
                Console.ResetColor(); // Change color back to system default.
                    break;
            }

            if (choice != "6") // If the user didn't quit. After the action from the menu, ask to come back to the main menu.
            {
                Console.Write("\nPress enter to go back to Main Menu "); // Prompting to press enter (any key + enter should do).
                Console.ReadLine(); // To stop the program until press enter.
                GamingAnimation animation = new GamingAnimation(); // Creating a new animation object.
                animation.ChargingDots(2); // Displaying a 3 dots animation like "charging animation".
                Console.Clear(); // Clean the console for menu to display.
            }

            else // If the user quitted, continue with the exit. 
            {
                continue;
            }

        } while (choice != "6"); // Stop if they input "6" (Quit).
    
    }

    public void CreateGoal() // Create a new goal.
    {
        string choice; // Creating a variable for the choice on the submenu.

        do // Prompt the user to make a decision based on the following options.
        {
            Console.WriteLine("\nThe types of Goals are:"); // Explanatory message.
            Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal"); // Options.
            Console.Write("Which type of goal would you like to create? "); // Prompting.
            choice = Console.ReadLine(); // Saving user's input.
            
            if (choice == "1" || choice == "2" || choice == "3") // If the choice is between the options, create the goal.
            {
                Goal goal = GetGoalInfo(choice); // Create a new Goal and get its respective information.
                _goals.Add(goal); // Add the Goal to the current Goals list.
            }

            else // If the choice is not between the options, display a message.
            {
                Console.ForegroundColor = ConsoleColor.Red; // Change letters color to red.
                Console.WriteLine("That's not a valid option."); // In case the user input doesn't satisfy the options, display a message to prompt the user for a valid option.
                Console.ResetColor(); // Change color back to system default.
            }

        } while (choice != "1" && choice != "2" && choice != "3"); // Stop if they input a valid option, else repeat.

        GamingAnimation animation = new GamingAnimation();  // Creating a new animation object.
        Console.ForegroundColor = ConsoleColor.Green; // Change letters color to green.
        Console.WriteLine("\nYour Goal has been created!"); // Message of successfulness creating the Goal.
        Console.ResetColor(); // Change color back to system default.
        animation.Spinner(2); // Displaying a spinner animation like "charging animation".
    }

    public void ListGoalDetails() // List the goals in a specific format.
    {
        if (_goals.Count == 0) // If there's nothing in the current list of Goals, display a message.
        {
            NoGoalMessage(); // Display message for no Goal: Prompt the user to create Goals firts.
        }

        else // if the Goals list is not empty. Display the goals in a specific format.
        {
            Console.WriteLine("\nThe Goals are: \n"); // Title to present the goals.
            int i = 0; // Index for the display of the list.

            foreach (Goal goal in _goals) // For each Goal in the current list.
            {
                i++; // Add 1 to the index, so it starts in 1.

                if (goal.IsComplete()) // If the Goal is complete. Mark with [X].
                {
                    Console.WriteLine($"{i}. [X] {goal.GetDetailsString()}");
                }

                else // If the Goal is not complete. Leave it blanck [ ].
                {
                    Console.WriteLine($"{i}. [ ] {goal.GetDetailsString()}");
                }
            }
        }
    }

    public void SaveGoals() // Save to file the current session info.
    {
        if (_goals.Count == 0) // If there's nothing in the current list of Goals, display a message.
        {
            NoGoalMessage(); // Display message for no Goal: Prompt the user to create Goals firts.
        }

        else // if the Goals list is not empty. Save to file the info.
        {
            Console.Write("What is the filename for the goal file? "); // Prompting the user to set a name for the file.
            string file = Console.ReadLine(); // Saving the file name.

            using (StreamWriter outputFile = new StreamWriter(file)) // Open a file to save.
            {
                outputFile.WriteLine(_score); // Writing he score in the first line os the document.

                foreach (Goal goal in _goals) // Go through every Goal in the current list.
                {
                    string goaltoFile = goal.GetStringRepresentation(); // Get each Goal as a string line with the right format.
                    outputFile.WriteLine(goaltoFile); // Write the line in the file and save it.
                }
            }

            Console.WriteLine($"\nSaving your journal in {file}"); // Message for aesthetic.
            GamingAnimation animation = new GamingAnimation(); // Creating a new animation object.
            animation.ChargingBar(4); // Displaying a charging bar.
            animation.ColorfulMessage("Saving successfull."); // Displaying a colorful message to inform the succesfulness of the action.
        }
    }

    public void LoadGoals() // Load a previous session from a file.
    {
        Console.Write("What is the filename for the goal file? "); // Prompting the user to input the file name.
        string file = Console.ReadLine(); // Saving the file name.

        Console.WriteLine($"\nLoading your Journal from {file}"); // Message for aesthetic.
        
        string[] lines = System.IO.File.ReadAllLines(file); // Open file, read each line (which are lineal Goals), make a list of (lineal) goals.

        _score += int.Parse(lines[0]); // Read the first line and add it to the current score.

        for (int i = 1; i < lines.Length; i++) // For each line, skipping the first line, in the file.
        {
            string[] parts = lines[i].Split(" //#// "); // Split the line in parts on every separator: " //#// ". 

            string goalType = parts[0]; // Part 1 = Index 0 = Goal.
            string attributes = parts[1]; // Part 2 = Index 1 = Attributes of the Goal Class.

            Goal goal = GetGoalFromFile(goalType, attributes); // Get the information for the goals list.
            _goals.Add(goal); // Add the new goal to the list.
        }

        GamingAnimation animation = new GamingAnimation();  // Creating a new animation object.
        animation.ChargingBar(4); // Displaying a charging bar.
        animation.ColorfulMessage("Loading successfull."); // Displaying a colorful message to inform the succesfulness of the action.
    }

    public void RecordEvent()
    {
        GamingAnimation animation = new GamingAnimation(); // Creating a new animation object.

        if (_goals.Count == 0) // If there's nothing in the current list of Goals, display a message.
        {
            NoGoalMessage(); // Display message for no Goal: Prompt the user to create Goals firts.
        }

        else // if the Goals list is not empty. record event.
        {
            ListGoalNames(); // Get the list of the Goals names.
            Console.Write("Which goal did you accomplish? "); // Title to ask the user for the event.

            int goalIndex = int.Parse(Console.ReadLine()); // Saving the goal index.
            int realIndex = goalIndex - 1; // Calculating the goal position on the current list of goals.
            int points = _goals[realIndex].RecordEvent(); // Getting the reward of the event.

            if (points < 0) // If the points for the goal were negative. Message of sorry displaying the points on red.
            {
                int pointsAbs = Math.Abs(points);
                Console.Write("\nSorry, bad news! You have lost ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{pointsAbs}");
                Console.ResetColor();
                Console.WriteLine(" points.");
            }

            else // If the points for the goal were positive. Message of colorfull congratulations displaying the points on green.
            {
                Console.WriteLine();
                animation.ColorfulMessage("Congratulations!");
                Console.Write(" You have earned ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{points}");
                Console.ResetColor();
                Console.WriteLine(" points!");
            }

            _score += points; // Adding the points to the current score.

            Console.WriteLine($"\nYou now have {_score} points."); // Message to tell the user how many point they have.
        }
    }

 // Private functions to make it possible for the menu to work in a cleaner way.

    private Goal GetGoalInfo(string type) // Get goal info and setting the corresponding Goal type.
    {
        Goal goal; // Creating a Goal object.

        Console.Write("What is the name of your goal? "); // Asking for name.
        string name = Console.ReadLine(); // Saving the name.

        Console.Write("What is a short description of it? "); // Asking for description.
        string description = Console.ReadLine(); // Saving description.

        Console.Write("What is the amount of points associated whit this goal? "); // Asking for points.
        int points = int.Parse(Console.ReadLine()); // Saving points.

        if (type == "1") // If it is a Simple Goal. 
        {
            goal = new SimpleGoal(name, description, points, false); // Setting Simple Goal.
        }

        else if (type == "2") // If it is an Eternal Goal.
        {
            goal = new EternalGoal(name, description, points); // Setting Eternal Goal.
        }

        else // If it is a Checklist goal.
        {
            Console.Write("How many times does this goal need to be acomplished for a bonus? "); // Asking for target.
            int target = int.Parse(Console.ReadLine()); // Save target.

            Console.Write("What is the bonus for acomplishing it that many times? "); // Asking for bonus points.
            int bonus = int.Parse(Console.ReadLine()); // Saving bonus points.

            goal = new ChecklistGoal(name, description, points, 0, target, bonus); // Setting Checklist Goal.
        }
    
        return goal; // Return the correct type of Goal.
    }

    private Goal GetGoalFromFile(string goalType, string attributes) // Getting the correct goal using a string line as input.
    {
        Goal goal; // Creating Goal Object.

        string[] parts = attributes.Split(new string[] {" /// "}, StringSplitOptions.None); // Split the line in parts using " /// " as separator.

        string nameAttribute = parts[0]; // Part 1 = Index 0 = Name.
        string descriptionAttribute = parts[1]; // Part 2 = Index 1 = Description.
        int pointsAttribute = int.Parse(parts[2]); // Part 3 = Index 2 = Points.

        if (goalType == "SimpleGoal") // If it is a Simple Goal.
        {
            bool statusAttribute = Convert.ToBoolean(parts[3]); // Part 4 = Index 3 = Complete status.
            goal = new SimpleGoal(nameAttribute, descriptionAttribute, pointsAttribute, statusAttribute); // Setting Simple Goal.
        }

        else if (goalType == "EternalGoal") // If it is an Eternal Goal.
        {
            goal = new EternalGoal(nameAttribute, descriptionAttribute, pointsAttribute); // Setting Eternal Goal.
        }

        else // If it is a Checklist goal.
        {
            int amountCompletedAttribute = int.Parse(parts[3]); // Part 4 = Index 3 = Amount Completed.
            int targetAttribute = int.Parse(parts[4]); // Part 5 = Index 4 = Target. 
            int bonusAttribute = int.Parse(parts[5]); // Part 6 = Index 5 = Bonus. 
            goal = new ChecklistGoal(nameAttribute, descriptionAttribute, pointsAttribute, amountCompletedAttribute, targetAttribute, bonusAttribute); // Setting Checklist Goal.
        }
    
        return goal; // Return the correct type of Goal.
    }

    private void DisplayPlayerInfo() // Display player info in a specific format.
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    private void ListGoalNames() // List the goals just by name.
    {
        Console.WriteLine("\nThese are the current goals\n"); // Title to present the goals.
        int j = 0; // Index for the display of the list.

        foreach (Goal goal in _goals) // For each Goal in the current list.
        {
            j++; // Add 1 to the index, so it starts in 1.

            Console.WriteLine($"{j}. {goal.GetName()}"); // Display just the goal name.
        }

        Console.WriteLine(); // Line for aesthetic.
    }

    private void NoGoalMessage() // If the goals list is empty, display a message to prompt the user to create goals.
    {
        Console.WriteLine("\nSorry, there are no Goals currently. Please create some and come back later!");       
    }

}
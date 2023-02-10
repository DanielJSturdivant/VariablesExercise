using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vaiable Declarations
            int age;
            string name;
            bool isAlive;
            char favoriteOption;
            double activityLevel;
            decimal progressCompleted;

            // Variable Initializations
            age = 24;
            name = "Daniel";
            isAlive = true;
            favoriteOption = 'e';
            activityLevel = 10.6;
            progressCompleted = 0.004m;

            Console.WriteLine($"{name} {age} is he alive: {isAlive}");

            Console.WriteLine($"{favoriteOption} was selected by {name} at {activityLevel} to achieve {progressCompleted}");
        }
    }
}

/*
    Creativity and Exceeding Requirements:
    - Added a Leveling system based on score (every 1000 points = new level)
    - Display current level as "Ninja Unicorn" theme
    - Extra congratulations message when ChecklistGoal bonus is earned
    - Clean menu and good user feedback throughout
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

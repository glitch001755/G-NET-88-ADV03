namespace C__Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager 
            //List<int> Grades = [85, 92, 78, 95, 88, 70, 100, 65];
            //Console.WriteLine($"List of Grades  =>  {string.Join(",", Grades)}");
            //Console.WriteLine($"Count = {Grades.Count}\nFirst Grade = {Grades[0]}\nLast Grade = {Grades[^1]}");
            //Grades.Sort();
            //Console.WriteLine($"List of Grades Sorted  =>  {string.Join(",", Grades)}");
            //Console.WriteLine($"First Grade Above 90 is => {Grades.Find(x => x > 90)}");
            //List<int> FailingGrades = Grades.FindAll(x => x < 75);
            //Console.WriteLine($"List of Failing Grades  =>  {string.Join(",", FailingGrades)}");
            //Grades.RemoveAll(x => x < 75);
            //Console.WriteLine($"List of Grades After Removing Failing Grades  =>  {string.Join(",", Grades)}");
            //if (Grades.Exists(x => x == 100))
            //    Console.WriteLine("Yes there is Grade Equall 100 ");
            //List<string> StrngGrades = Grades.ConvertAll(x => $"Grade: {x}");
            //Console.WriteLine($"List of String Grades  =>  {string.Join(",", StrngGrades)}");
            #endregion
            #region Exercise 2: Leaderboard 
            //SortedList<int, string> scores = new();
            //scores.Add(500, "Ahmed");
            //scores.Add(200, "Sara");
            //scores.Add(800, "Ali");
            //scores.Add(350, "Mona");

            //Console.WriteLine("--- scores (Sorted) ---");
            //foreach (KeyValuePair<int, string> item in scores)
            //{
            //    Console.WriteLine($"Score: {item.Key} => Player: {item.Value}");
            //}
            //Console.WriteLine($"First Key => {scores.Keys[0]} :: First Value => {scores.Values[0]} ");

            //Console.WriteLine($"Scores have 500 ? => {scores.ContainsKey(500)} ");

            //if (scores.TryGetValue(999, out string? playerName))
            //{
            //    Console.WriteLine($"The payer with score 999 is {playerName}");
            //}
            //else
            //{
            //    Console.WriteLine("Score 999 not found.");
            //}

            //scores.Remove(200);

            //Console.WriteLine("--- Updated scores List (Sorted) ---");
            //foreach (KeyValuePair<int, string> item in scores)
            //{
            //    Console.WriteLine($"Score: {item.Key} => Player: {item.Value}");
            //}
            #endregion
        }
    }
}

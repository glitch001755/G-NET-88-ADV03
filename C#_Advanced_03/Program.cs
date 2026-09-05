namespace C__Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager 
            List<int> Grades = [85, 92, 78, 95, 88, 70, 100, 65];
            Console.WriteLine($"List of Grades  =>  {string.Join(",", Grades)}");
            Console.WriteLine($"Count = {Grades.Count}\nFirst Grade = {Grades[0]}\nLast Grade = {Grades[^1]}");
            Grades.Sort();
            Console.WriteLine($"List of Grades Sorted  =>  {string.Join(",", Grades)}");
            Console.WriteLine($"First Grade Above 90 is => {Grades.Find(x => x > 90)}");
            List<int> FailingGrades = Grades.FindAll(x => x < 75);
            Console.WriteLine($"List of Failing Grades  =>  {string.Join(",", FailingGrades)}");
            Grades.RemoveAll(x => x < 75);
            Console.WriteLine($"List of Grades After Removing Failing Grades  =>  {string.Join(",", Grades)}");
            if (Grades.Exists(x => x == 100))
                Console.WriteLine("Yes there is Grade Equall 100 ");
            List<string> StrngGrades = Grades.ConvertAll(x => $"Grade: {x}");
            Console.WriteLine($"List of String Grades  =>  {string.Join(",", StrngGrades)}");
            #endregion
        }
    }
}

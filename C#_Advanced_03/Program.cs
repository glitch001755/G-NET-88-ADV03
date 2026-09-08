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
            #region Exercise 3: Phone Book 
            //Dictionary<string, string> PhoneBook = new()
            //{
            //    ["osama"] = "010205555",
            //    ["ahmed"] = "011205115",
            //    ["ziad"] = "012207744",
            //    ["alaa"] = "013206644",
            //};
            //PhoneBook["mohamed"] = "0144578612";
            //try
            //{
            //    PhoneBook.Add("osama", "010205555");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //if (PhoneBook.TryAdd("anas", "0154656544"))
            //{
            //    Console.WriteLine("Added Succesfully");
            //}
            //else
            //{
            //    Console.WriteLine("Not Added");
            //}

            //bool exists = PhoneBook.ContainsKey("osos");
            //Console.WriteLine($"Does \"osos\" exist in phone book? {exists}");



            //if (PhoneBook.TryGetValue("osos", out string? number))
            //{
            //    Console.WriteLine("found");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found Contact With Name \"osos\"");
            //}

            //Console.WriteLine("Keys (Names):");
            //Console.WriteLine(string.Join(", ", PhoneBook.Keys));

            //Console.WriteLine("Values (Phone Numbers):");
            //Console.WriteLine(string.Join(", ", PhoneBook.Values));

            #endregion
            #region Exercise 4: Unique Email Validator 
            //HashSet<string> Emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};

            //Console.WriteLine(Emails.Count); // 2 because we ignore the case sensitive so  "ahmed@test.com" = "AHMED@test.com" and ignore the second one , "sara@test.com" = "Sara@Test.Com" the same thing.


            //HashSet<int> A = [1, 2, 3, 4, 5];
            //HashSet<int> B = [4, 5, 6, 7, 8];
            //A.UnionWith(B);
            //Console.WriteLine($"A U B => [{string.Join(" , ", A)}]");
            //A.IntersectWith(B);
            //Console.WriteLine($"A n B => [{string.Join(" , ", A)}]");
            //A.ExceptWith(B);
            //Console.WriteLine($"A - B => [{string.Join(" , ", A)}]");
            //HashSet<int> C = [1, 2];
            //Console.WriteLine($"[1,2] is Subset of [1,2,3,4,5] =>  {C.IsSubsetOf(A)}");


            #endregion
        }
    }
}

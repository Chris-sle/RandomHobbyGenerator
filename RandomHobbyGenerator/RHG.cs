namespace RandomHobbyGenerator
{
    internal class RHG
    {
        public static void Run()
        {
            Console.WriteLine("Who would like a new hobby?");
            string userName = Console.ReadLine();
            string hobby = FindRandomHobby(userName);
            Console.WriteLine($"{hobby}");
            Console.WriteLine("Go again? [Y/N]");
            string answer = Console.ReadLine().Trim().ToLower();
            ContinueOrEndApp(answer);
        }

        private static void ContinueOrEndApp(string? answer)
        {
            if(answer == "y") Run();
            Environment.Exit(0);
        }

        private static string FindRandomHobby(string username)
        {
            string[] hobby =
            {
                $"gamer, {username} can now become whatever you want!", 
                $"A jogger? {username} are now one of those people",
                $"A Cyclist? We all hope {username}'s bike gets stolen",
                $"{username} is now a ballplayer, kick it or throw it! we really don't care. . .",
                $"{username} is now a fisherman, oh please bring home some delicious fish!"
            };
            Random rand = new Random();
            var randomNumber = rand.Next(0, hobby.Length);

            if(randomNumber == 0) return hobby[randomNumber];
            if(randomNumber == 1) return hobby[randomNumber];
            if(randomNumber == 2) return hobby[randomNumber];
            if(randomNumber == 3) return hobby[randomNumber];
            if(randomNumber == 4) return hobby[randomNumber];
            return "Ops, something wrong happened!";
        }
    }
}

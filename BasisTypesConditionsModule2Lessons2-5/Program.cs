namespace BasisTypesConditionsModule2Lessons2_5
{
    public class Program
    {
        const string RELAXING_MUSIC = "Możesz posłuchać spokojnej muzyki.";
        const string WALK = "Na złość dobry jest szybki marsz.";
        const string BOOK = "Z pewnością dziś poczytasz dobrą książkę.";
        const string MIND = "Poćwicz umysł. Co powiesz na układanie puzzli?";
        const string TV = "Obejrzyj komedię";
        const string GYMNASTICS = "Przydadzą Ci się ćwiczenia rozciągające.";

        public enum Mood
        {
            Cheerful,
            Joyful,
            Happy,
            Neutral,
            Sad,
            Mad,
        }

        public static readonly Dictionary<string, Program.Mood> MoodDescription = new ()
        {
            { "pogodny", Mood.Cheerful },
            { "radosny", Mood.Joyful },
            { "szczęśliwy", Mood.Happy },
            { "neutralny", Mood.Neutral },
            { "smutny", Mood.Sad },
            { "wściekły", Mood.Mad }
        };

        static void Main(string[] _)
        {
            Console.WriteLine("Program Propozycji Aktywności w zależności od Nastroju :-)");
            Console.WriteLine();
            Console.WriteLine("Jak się dziś czujesz?");
            Console.WriteLine($"Wybierz jedną odpowiedź najbardziej zbliżoną do Twojego obecnego nastroju:");
            Console.WriteLine();

            foreach (var description in MoodDescription.Keys)
            {
                Console.WriteLine($"{description}");
            }

            Console.WriteLine();
            string? userMood = Console.ReadLine()?.ToLower();

            if (userMood != null && MoodDescription.TryGetValue(userMood, out Mood currentMood))
            {
                Console.WriteLine("Dziękuję. Teraz mogę zaproponować Ci adekwatną formę aktywności.");

                string activity = currentMood switch
                {
                    Mood.Cheerful => BOOK,
                    Mood.Joyful => RELAXING_MUSIC,
                    Mood.Happy => GYMNASTICS,
                    Mood.Neutral => MIND,
                    Mood.Sad => TV,
                    Mood.Mad => WALK,
                    _=> "Nie rozpoznaję Twojego nastroju."
                };

                Console.WriteLine(activity);
            }
            else 
            {
                Console.WriteLine("Błąd. Podaj swój nastrój wybierając zbliżoną wartość w zestawie.");
            }
        }
    }
}

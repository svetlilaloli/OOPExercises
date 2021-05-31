namespace AuthorProblem
{
    [Author("John")]
    public class Program
    {
        [Author("Smith")]
        public static void Main()
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
        [Author("James")]
        public static void JustMethod()
        {

        }
    }
}

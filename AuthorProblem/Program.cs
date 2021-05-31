namespace AuthorProblem
{
    [Author("Svetlana")]
    public class Program
    {
        [Author("Vassileva")]
        public static void Main()
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
        [Author("Svetlana")]
        public static void JustMethod()
        {

        }
    }
}

namespace Frends.TestTask.DoNothing
{
    public class TestTask
    {
        /// <summary>
        /// Not a real task. 
        /// </summary>
        public static string DoNothing()
        {
            var foo = true;
            return $"{foo.ToString()}";
        }
    }
}


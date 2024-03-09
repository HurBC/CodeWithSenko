namespace CodeWithSenko
{
    interface ICreateExample
    {
        abstract static void CreateExample();
    }

    internal class Program
    {
        static void Main( string[] args )
        {

            String[] strings = { "Hello", "World"};

            DataStrucs.CWSArrays.PrintArray( strings );

            List<string> names = new List<string>
            {
                "Senko San",
                "Freddy Fazbear",
                "Clancy"
            };

            DataStrucs.CWSLists.PrintList( "New List", names );

        }
    }
}

namespace CodeWithSenko.Interfaces
{
    interface ITransmision
    {

        void StartTransmission();

        void StopTransmission();

    }

    interface IGoToNextSection
    {
        void PassSection();
    }

    interface INews : ITransmision, IGoToNextSection
    {
        string NewsName { get; set; }

        interface IReporter
        {
            void Report( string message );
        }
    }

    public class News : INews, INews.IReporter
    {

        public string NewsName { get; set; }

        public void StartTransmission() => Console.WriteLine( "Transmission has started" );

        public void StopTransmission() => Console.WriteLine( "Transmission has stopped" );

        public void PassSection() => Console.WriteLine( "Moving on to the next section..." );

        public void Report( string message ) => Console.WriteLine( "Reporting" );

    } 

}

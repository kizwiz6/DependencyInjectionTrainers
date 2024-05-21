namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using trainer:");
            Trainer trainer = new Trainer(new LoudSpeaker());
            trainer.BeginTraining();
        }
    }
}

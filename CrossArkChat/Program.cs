namespace CrossArkChat
{
    using System.Threading.Tasks;

    internal class Program
    {
        private static void <Main>(string[] args)
        {
            Main(args).GetAwaiter().GetResult();
    }

    private static Task Main(string[] args) =>
        Startup.RunAsync(args);
}
}


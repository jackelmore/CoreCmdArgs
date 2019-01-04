using System;
using PowerArgs;

namespace CoreCmdArgs
{
    public class MyArgs
    {
        [ArgRequired(PromptIfMissing = false)]
        public string StringArg { get; set; }
        [ArgRange(1, 10)]
        public int IntArg { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                var parsed = Args.Parse<MyArgs>(args);
                Console.WriteLine("You entered string '{0}' and int '{1}'", parsed.StringArg, parsed.IntArg);
            }
            catch (ArgException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ArgUsage.GenerateUsageFromTemplate<MyArgs>());
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

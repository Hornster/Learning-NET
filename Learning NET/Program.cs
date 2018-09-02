using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TelepromterConsole;

namespace Learning_NET
{
    class Program
    {
        //The source file.
        const string fileNameConst = "exampleData.txt";
        //The amount of characters (max) allowed in one line.
        const int threshold = 70;
        //The delay between the words popping up.
        const int taskDelay = 200;
        static void Main(string[] args)
        {
            RunTeleprompter().Wait();
            int a = 3;
            a += 4;
        }

        static async Task RunTeleprompter()
        {
            var config = new TeleprompterConfig();
            var teleprompterTask = ShowTeleprompter(config);
            var inputTask = GetInput(config);

            await Task.WhenAny(teleprompterTask, inputTask);
        }

        static async Task ShowTeleprompter(TeleprompterConfig config)
        {
            var lines = ReadFile(fileNameConst);
            foreach (var line in lines)
            {
                Console.Write(line);
                if(!string.IsNullOrWhiteSpace(line))
                {
                    await Task.Delay(config.DelayInMiliseconds);
                }
            }
            config.SetDone();
        }
        private static async Task GetInput(TeleprompterConfig config)
        {
            Action work = () =>
            {
                do
                {
                    var key = Console.ReadKey(true);
                    if (key.KeyChar == '>')
                    {
                        config.UpdateDelay (-10);
                    }
                    else if (key.KeyChar == '<')
                    {
                        config.UpdateDelay(10);
                    }
                } while (!config.Done);
            };
            await Task.Run(work);
        }

        static IEnumerable<string> ReadFile(string fileName)
        {
            string line;
            //Disposes all objects created here (the objects need to impelemt the IDisposable() interface, with Dispose() method.).
            var reader = File.OpenText(fileName);
            
                while((line = reader.ReadLine()) != null)
                {
                    var words = line.Split(' ');
                    var lineLength = 0;
                    foreach (var word in words)
                    {
                        yield return word + " ";
                        lineLength += word.Length + 1;
                        if (lineLength > threshold)
                        {
                            yield return Environment.NewLine;
                            lineLength = 0;
                        }

                     }
                    yield return Environment.NewLine;

                }
            
        }
    }
}

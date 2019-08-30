namespace Db4o.Tutorial.Core
{
  using System;

  using F1.Chapter1;
  using F1.Chapter2;
  using F1.Chapter3;
  using F1.Chapter4;
  using F1.Chapter5;
  using F1.Chapter6;
  using F1.Chapter8;
  using F1.Chapter9;

  using Console = System.Console;

  class App
    {
        [STAThread]
        static void Main(string[] args)
        {
            System.Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            FirstStepsExample.Main(args);
            StructuredExample.Main(args);
            OMEExample.Main(args);
            CollectionsExample.Main(args);
            InheritanceExample.Main(args);
           
            TransparentActivationExample.Main(args);
            TransparentPersistenceExample.Main(args);
            
            System.Console.WriteLine("Client-Server");
            ClientServerExample.Main(args);
            System.Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
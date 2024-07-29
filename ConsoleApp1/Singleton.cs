

namespace console
{
    public sealed class Program
    {
        private static readonly object lockObj = new object();
        private Program() { }
        private static Program instance = null;

        public static Program GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new Program();
                            Console.WriteLine("Created");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Not Created");
                }

                    return instance;
            }
        
        }
    }

    public class Test {

        //public static void Main(string[] args)
        //{
        //    var singletonInstance = Program.GetInstance;

        //   var singletonInstance1 = Program.GetInstance;
        //    var singletonInstance2 = Program.GetInstance;

        //}
    
    }
}





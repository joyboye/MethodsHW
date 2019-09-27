using System;

namespace MethodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.newMethod();
            prog.floatMethod(100f, 50f);

            int[] numb = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9 };
            prog.intMethod(numb);
        }
       public void newMethod()
        {
            Console.WriteLine("The newMethod is good to go");
        }
        public void floatMethod(float para1,float para2)
        {
            var result = para1 / para2;
            Console.WriteLine(result);
        }
        public void intMethod(int[] intLoop)
        {
            foreach (int i in intLoop)
            {
                if (i == 7)
                {
                    Console.WriteLine("lucky you");
                }
                else
                {
                    Console.WriteLine("unlicky number ");
                }
            }
        }
        
    }
}

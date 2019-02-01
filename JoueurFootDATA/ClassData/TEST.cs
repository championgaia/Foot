using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoueurFootDATA.ClassData
{
    public class TEST
    {
        public class TestA
        {
            public List<int> ListeIntA1;
            public static List<int> ListeIntA2;
            public int MethodeA1()
            {
                return 0;
            }
            public static int MethodeA2()
            {
                return 0;
            }
        }
        public static class TestB
        {
            public static List<int> ListeIntB;
            public static int MethodeB2()
            {
                return 0;
            }
        }
        public void TestC()
        {
            TestA testA = new TestA();
            testA.MethodeA1();
            TestA.MethodeA2();
            Console.WriteLine(TestA.ListeIntA2);
        }
    }
}

using System;

namespace Inheritence_Test
{
    public enum BoardIdEnum
    {
        DUT1 = 0,
        DUT2 = 1,
        DUT3 = 2,
        DUT4 = 3,
        DUT5 = 4,
        DUT6 = 5,
        DUT7 = 6,
        DUT8 = 7,
        DUT9 = 8,
        DUT10 = 9,
        DUT11 = 10,
        DUT12 = 11,
        DUT13 = 12,
        DUT14 = 13,
        DUT15 = 14,
        DUT16 = 15,
        DUT17 = 16,
        DUT18 = 17,
        DUT19 = 18,
        DUT20 = 19,
        DUT21 = 20,
        DUT22 = 21,
        DUT23 = 22,
        DUT24 = 23,
        DUT25 = 24,
        DUT26 = 25,
        DUT27 = 26,
        DUT28 = 27,
        DUT29 = 28,
        DUT30 = 29,
        DUT31 = 30,
        DUT32 = 31,
        DUT33 = 32,
        DUT34 = 33,
        DUT35 = 34,
        DUT36 = 35,
        DUT37 = 36,
        DUT38 = 37,
        DUT39 = 38,
        DUT40 = 39,
        DUT41 = 40,
        DUT42 = 41,
        DUT43 = 42,
        DUT44 = 43,
        DUT45 = 44,
        DUT46 = 45,
        DUT47 = 46,
        DUT48 = 47,
        DUT49 = 48,
        DUT50 = 49,
        DUT51 = 50,
        DUT52 = 51,
        DUT53 = 52,
        DUT54 = 53,
    }

    public class DioLine<T>
    {
        private BoardIdEnum _boardId;
        public BoardIdEnum getBoardID()
        {
            return _boardId;
        }
        public DioLine (T board, BoardIdEnum boardId, byte portValue)
        {
            _boardId = boardId;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BoardIdEnum Boardid;
            var DioLineTest = new DioLine<BoardIdEnum>(BoardIdEnum.DUT1, BoardIdEnum.DUT11, 10);

            Console.WriteLine(DioLineTest.getBoardID());

            foreach(BoardIdEnum inputTest in Enum.GetValues(typeof(BoardIdEnum)))
            {
                string dataTest = inputTest.ToString().StartsWith("DUT3") ? inputTest.ToString() + "fried" : inputTest.ToString() + "chicken";
                Console.WriteLine(dataTest);
            }

            //Console.WriteLine(BoardIdEnum.DUT1);
            //Test test = new Test();
            //TestInh2 testInh2 = new TestInh2(4, 2, 3);
            //Console.WriteLine("result nya adalah :" + testInh2.result);

        }
    }
    class Test
    {
        internal int result = 0;

        public Test()
        {
        }

        public Test(int a, int b, int c)
        {
            result = a + b + c;
        }
        public Test(int a, int b)
        {
            result = a - b;
        }

    }

    class TestInh1 : Test
    {

        internal TestInh1 (int a, int b, int c) :
            base (a,b,c)
        {
            result = result + a - b + c;
        }

        internal TestInh1(int a, int b) :
            base(a, b)
        {
            result = result + a - b;
        }

    }

    class TestInh2 : TestInh1
    {

        internal TestInh2(int a, int b, int c) :
            base(a, b, c)
        {
            result = result * a * b * c;
        }

        internal TestInh2(int a, int b, int c, int d) :
            base(a, b)
        {
            result = result * a * c;
        }

    }

}

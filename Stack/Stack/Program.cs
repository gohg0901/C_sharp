using System;

namespace Test_Stack
{
    class Stack
    {
        //data member
        int[] s = new int[10];
        public int top;

        //member function
        public void push(int i)
        {

            this.top = this.top + 1; //java, c#, c++ 에서 this 생략가능
            s[top] = i;
        }

        public int pop()
        {

            this.top = this.top - 1;
            return s[top + 1];
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Stack p1;
            Stack p2;
            Stack p3;

            p1 = new Stack(); //type casting
            p2 = new Stack();
            p3 = new Stack();

            p1.top = -1;
            p2.top = -1;
            p3.top = -1;

            p1.push(8);
            p1.push(9);
            p1.push(3);
            x = p1.pop();
            x = p1.pop();
            Console.WriteLine(x);

            p2.push(100);
            p2.push(300);
            x = p2.pop();
            x = p2.pop();
            Console.WriteLine(x);

        }
    }
}
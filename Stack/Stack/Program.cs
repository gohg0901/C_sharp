using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace stack
{
    class Stack
    {
        static int MAX = 1000;  //static data member , 전역변수 , static 영역에 저장됨

        //data member
        private int[] s = new int[MAX];
        private int top;
        private int size;
        
        public Stack(int n)
        {
            top = -1;
            size = n;
        }
                
        public Stack() //constructor 생성자, 객체를 만들때 초기화 용으로 사용 , 자동호출 , default constructor
        {
            Console.WriteLine("Hello");
            size = MAX;
            top = -1;
        }
        
        public void overflowError()
        {
            Console.WriteLine("Stack overflow occurs!!");
            Environment.Exit(-1);
        }
                
        public void emptyerror()
        {
            Console.WriteLine("Stack empty error occurs!!");
            Environment.Exit(-1);
        }
               
        //member function..
        public void push(int x)
        {
            if (top >= size - 1) overflowError();   //overflow
            this.top = this.top + 1;
            this.s[this.top] = x;
        }
        
        public int pop()
        {
            if (top == -1) emptyerror();
            top--;

            return s[top + 1];
        }
        
        public int peek()
        {
            if (top == -1) emptyerror();
            return s[top];
        }
        
        public bool isEmpty()
        {
            if (top == -1) return true;
            return false;
        }

        public int count()
        {
            return top + 1;
        }
        
        //housekeeping function
        private void initialize()
        {
            for (int i = 0; i < MAX; i++)
            {
                s[i] = 0;
            }
        }

        public void reset()
        {
            initialize();
            top = -1;
        }
    }
       
    class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack(10);  //객체를 생성한다 
            Stack b = new Stack(50);  // object instantiation



            a.push(10);     //message sending
            a.push(20);

            int x = a.pop();

            a.push(30);
            a.push(40);



            x = a.peek(); //stack 맨 끝에 뭐있는지 알려줌

            a.reset();

            int n = a.count();

            a.push(1000);

            b.push(100);
            b.push(200);
            b.push(300);
            b.push(400);
            int y = b.pop();

            bool z = b.isEmpty();
            Console.WriteLine(x + "," + y + "," + z + "," + n);
        }
    }
}
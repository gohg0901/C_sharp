using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Stack
    {
        // Attributes
        static int MAX = 100;
        /** an array to save stack contents 
         */
        private int[] _s;
        /** the index to point top of stack
         */
        private int _top;
        /** size of the stack
         */
        private int _size;
        // Operations
        /** initialization procedure for new stack
         */
        private void initialize()
        {
            // NOTE: We don't have to do this initialization with Java
            for (int i = 0; i < _size; i++)
            {
                _s[i] = 0;
            }
        }
        /** this function is called for stack overflow exception
         */
        private void overflowError()
        {
            Console.WriteLine("Stack overflow error occurs.");
            Environment.Exit(-1);
        }
        /** this function is called for stack empty exception
         */
        private void emptyError()
        {
            Console.WriteLine("Stack empty error occurs.");
            Environment.Exit(-1);
        }
        /** the constructor for stack object
         */
        public Stack()
            : this(MAX)
        {
        }
        /** the constructor for stack object
         */
        public Stack(int n)
        {
            if (n > MAX)
            {
                Console.WriteLine("Stack size must be less than " + MAX + ".");
                Environment.Exit(-1);
            }
            _s = new int[MAX];
            _size = n;
            _top = -1;
            initialize();
        }
        /**	the function to insert new item on stack
         */
        public void push(int item)
        {
            if (_top >= _size - 1) overflowError();
            _top++;
            _s[_top] = item;
        }
        /** the function to delete an item at the top position of the stack
         */
        public int pop()
        {
            if (_top == -1) emptyError();
            int value = _s[_top];
            _top--;
            return (value);
        }
        /** the function to get the top element of the stack
         */
        public int peek()
        {
            if (_top == -1) emptyError();
            return (_s[_top]);
        }
        /** the fuction to clear an exisiting stack
         */
        public void reset()
        {
            _top = -1;
            initialize();
        }
    }

    class LineBuffer
    {
        public static int ID_PLUSE = 1;
        public static int ID_MINUS = 2;
        public static int ID_MULTIPLY = 3;
        public static int ID_DIVIDE = 4;
        public static int ID_OPERAND = 5;
        public static int ID_EOD = 6;
        public static int ID_ERROR = 7;

        int _tokenValue;
        int _index;
        String[] _tokens;

        public LineBuffer(String text)
        {
            
            char[] separator = new char[1];
            separator[0] = ' ';

            _tokens = text.Split(separator);
            _index = 0;
            _tokenValue = 0;
        }

        public int getNextToken()
        {
            if (_index >= _tokens.Length) return ID_EOD;

            if (_tokens[_index].Equals("+"))
            {
                _index++;
                return ID_PLUSE;
            }

            if (_tokens[_index].Equals("-"))
            {
                _index++;
                return ID_MINUS;
            }

            if (_tokens[_index].Equals("*"))
            {
                _index++;
                return ID_MULTIPLY;
            }

            if (_tokens[_index].Equals("/"))
            {
                _index++;
                return ID_DIVIDE;
            }

            _tokenValue = int.Parse(_tokens[_index]);
            _index++;
            return ID_OPERAND;
        }

        public int getTokenValue()
        {
            return _tokenValue;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            String aLine;
            Stack operands = new Stack();

            while (true)
            {

                aLine = Console.ReadLine();

                LineBuffer buffer = new LineBuffer(aLine);  //tokenize <- 토큰 한줄화

                while (true)
                {
                    int tokenID = buffer.getNextToken();

                    if (tokenID == LineBuffer.ID_PLUSE)
                    {
                        int x = operands.pop();
                        int y = operands.pop();
                        int z = x + y;
                        operands.push(z);
                    }

                    else if (tokenID == LineBuffer.ID_MINUS)
                    {
                        int x = operands.pop();
                        int y = operands.pop();
                        int z = y - x;
                        operands.push(z);
                    }

                    else if (tokenID == LineBuffer.ID_MULTIPLY)
                    {
                        int x = operands.pop();
                        int y = operands.pop();
                        int z = y * x;
                        operands.push(z);
                    }

                    else if (tokenID == LineBuffer.ID_DIVIDE)
                    {
                        int x = operands.pop();
                        int y = operands.pop();
                        int z = y / x;
                        operands.push(z);
                    }

                    else if (tokenID == LineBuffer.ID_OPERAND)
                    {
                        int a = buffer.getTokenValue();
                        Console.WriteLine("a = " + a);
                        operands.push(a);
                    }

                    else if (tokenID == LineBuffer.ID_EOD)
                    {
                        int a = operands.pop();
                        Console.WriteLine(" = " + a);
                        break;
                    }

                }
            }
        }
    }
}
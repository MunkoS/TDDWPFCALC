using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Operator
    {
        public char Symbol;
        public Func<int, int, int> Function;

        public Operator(char symbol,Func<int,int,int> function)
        {
            Symbol = symbol;
            Function = function;
        }
    }


    public class Calc
    {

        Operator[] _operators = new Operator[]
        {
            new Operator('+',(left,right)=> {return left+right; }),
            new Operator('-',(left,right)=> {return left-right; }),
            new Operator('/',(left,right)=> {return left/right; }),
            new Operator('*',(left,right)=> {return left*right; }),
        };



        public int Calculate(string input)
        {
            foreach (var op in _operators)
            {

                if (input.Contains(op.Symbol))
                {
                    string[] parts = input.Split(new char[] { op.Symbol }, StringSplitOptions.RemoveEmptyEntries);
                    int left = Convert.ToInt32(parts[0]);
                    int right = Convert.ToInt32(parts[1]);

                    return op.Function(left, right);
                }
            }
           
            throw new InvalidOperationException(); 
        }
    }
}

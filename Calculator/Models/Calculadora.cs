using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    class Calculadora
    {
        public int currentState { get; set; }
        public string mathOperator { get; set; }
        public double firstNumber { get; set; }
        public double secondNumber { get; set; }

    }
}

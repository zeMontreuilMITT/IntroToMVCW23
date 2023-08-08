using Microsoft.AspNetCore.Mvc;

namespace IntroToMVCW23.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Add(int operandOne, int operandTwo)
        {
            CalculatorResultViewModel vm = new CalculatorResultViewModel
            {
                OperandOne = operandOne,
                OperandTwo = operandTwo,
                Solution = operandOne + operandTwo,
                Operation = "plus"
            };

            return View("Solution", vm);
        }

        public IActionResult Subtract(int operandOne, int operandTwo)
        {
            CalculatorResultViewModel vm = new CalculatorResultViewModel
            {
                OperandOne = operandOne,
                OperandTwo = operandTwo,
                Solution = operandOne - operandTwo,
                Operation = "minus"
            };

            return View("Solution", vm);
        }

        public IActionResult Divide(int operandOne, int operandTwo)
        {
            CalculatorResultViewModel vm = new CalculatorResultViewModel
            {
                OperandOne = operandOne,
                OperandTwo = operandTwo,
                Solution = operandOne / operandTwo,
                Operation = "divided by"
            };

            return View("Solution", vm);
        }

        public IActionResult Multiply(int operandOne, int operandTwo)
        {
            CalculatorResultViewModel vm = new CalculatorResultViewModel
            {
                OperandOne = operandOne,
                OperandTwo = operandTwo,
                Solution = operandOne * operandTwo,
                Operation = "times"
            };

            return View("Solution", vm);
        }
    }

    public class CalculatorResultViewModel
    {
        public double OperandOne { get; set; } = 0;
        public double OperandTwo { get; set; } = 0;
        public double Solution { get; set; }
        public string Operation { get; set; }

        public CalculatorResultViewModel()
        {

        }

        public CalculatorResultViewModel(double opOne, double opTwo, double solution, string operation)
        {
            OperandOne = opOne;
            OperandTwo = opTwo;
            Solution = solution;
            Operation = operation;
        }
    }
}

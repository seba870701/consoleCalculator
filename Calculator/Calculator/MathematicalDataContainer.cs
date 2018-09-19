using System.Collections.Generic;

namespace Calculator
{
    public class MathematicalDataContainer
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string MathOperation { get; set; }
        public bool CorrrectInput { get; set; }
        public double Result { get; set; }
        public List<double> Numbers { get; set; }
    }
}


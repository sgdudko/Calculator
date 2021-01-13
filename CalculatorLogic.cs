using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator
{
    class CalculatorLogic : INotifyPropertyChanged
    {
        #region Fields
        private string _expression = null;
        public string Expression
        {
            get
            {
                return _expression;
            }
            set
            {
                _expression = value;
                OnPropertyChanged("Expression");
            }
        }
        private bool _isButtonEqualsPressed;
        public bool IsButtonEqualsPressed
        {
            get
            {
                return _isButtonEqualsPressed;
            }
            set
            {
                _isButtonEqualsPressed = value;
            }
        }
        private string[] _operands { get; set; } = null;
        private double[] _operandsDouble { get; set; } = null;
        private char[] _operations { get; set; } = null;
        private int[] _indexOfOperations { get; set; } = null;
        private bool[] _IsItPrimaryOperation { get; set; } = null;
        #endregion

        #region Methods
        /// <summary>
        /// Method splits a string into operands and operation signs.
        /// </summary>
        private void StringSplittings()
        {
            // Splitting a string into operands
            _operands = Expression.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.RemoveEmptyEntries);
            _operandsDouble = new double[_operands.Length];
            for (int i = 0; i < _operands.Length; i++)
            {
                _operandsDouble[i] = Double.Parse(_operands[i]);
            }

            // Extraction of symbols from a string
            _indexOfOperations = new int[_operands.Length - 1];
            _operations = new char[_operands.Length - 1];
            _IsItPrimaryOperation = new bool[_operands.Length - 1];
            var temporalExpression = Expression;
            for (int i = _operands.Length - 1; i > 0; i--)
            {
                _indexOfOperations[i - 1] = temporalExpression.LastIndexOfAny(new char[] { '+', '-', '*', '/' });
                _operations[i - 1] = Expression[_indexOfOperations[i - 1]];
                temporalExpression = temporalExpression.Remove(_indexOfOperations[i - 1], temporalExpression.Length - _indexOfOperations[i - 1]);

                // Separation of operations by their priority
                if (_operations[i - 1] == '*' || _operations[i - 1] == '/')
                {
                    _IsItPrimaryOperation[i - 1] = true;
                }
            }
        }

        /// <summary>
        /// Method performs mathematical operations.
        /// </summary>
        public string Equate()
        {
            this.StringSplittings();
            double sum = 0;

            bool[] isThisPartCounted = new bool[_operands.Length];
            // Performing multiplication and division operations
            for (int i = 0; i < _operations.Length; i++)
            {
                if (_IsItPrimaryOperation[i] == true)
                {
                    switch (_operations[i])
                    {
                        case '*':
                            {
                                _operandsDouble[i + 1] = _operandsDouble[i] * _operandsDouble[i + 1];
                                isThisPartCounted[i] = true;
                                break;
                            }
                        case '/':
                            {
                                _operandsDouble[i + 1] = _operandsDouble[i] / _operandsDouble[i + 1];
                                isThisPartCounted[i] = true;
                                break;
                            }
                    }
                }
            }
            // Accounting for the first member
            int k = 0;
            while (isThisPartCounted[k] == true)
            {
                k++;
            }
            sum += _operandsDouble[k];
            // Performing addition and subtraction operations
            for (int i = 0; i < _operations.Length; i++)
            {
                if (_IsItPrimaryOperation[i] == false)
                {
                    switch (_operations[i])
                    {
                        case '+':
                            {
                                int j = i + 1;
                                while (isThisPartCounted[j] == true && j < _operations.Length)
                                {
                                    j++;
                                }
                                sum += _operandsDouble[j];
                                break;
                            }
                        case '-':
                            {
                                int j = i + 1;
                                while (isThisPartCounted[j] == true && j < _operations.Length)
                                {
                                    j++;
                                }
                                sum -= _operandsDouble[j];
                                break;
                            }
                    }
                }
            }
            for (int i = 0; i < _IsItPrimaryOperation.Length; i++)
            {
                _IsItPrimaryOperation[i] = false;
            }

            _isButtonEqualsPressed = true;
            return sum.ToString();
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
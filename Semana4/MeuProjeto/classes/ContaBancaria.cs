namespace Namespace;

    public class ContaBancaria{
    private double _saldo;

        public double Saldo{
            get {return _saldo; }
            set
            {
                if (value > 0)
                    _saldo = value;
                else
                    throw new ArgumentException("O saldo não pode ser negativo");
            }
        }
    }


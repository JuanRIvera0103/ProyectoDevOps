namespace ProyectoDevOps
{
    public class CuentaBanco
    {
        public double balance { get; set; }

        public CuentaBanco()
        {
        }

        public CuentaBanco(double balance)
        {
            this.balance = balance;
        }

        public void Agregar(double monto)
        {
            if (monto < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(monto));
            }

            balance += monto;
        }

        public void Retirar(double monto)
        {
            if (monto < 0 || monto > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(monto));
            }

            balance -= monto;
        }

        public void TransferirFondos(CuentaBanco cuenta, double monto)
        {
            if (cuenta is null)
            {
                throw new ArgumentNullException(nameof(cuenta));
            }

            Retirar(monto);
            cuenta.Agregar(monto);
        }
    }
}

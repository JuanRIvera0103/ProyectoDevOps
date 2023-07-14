namespace ProyectoDevOps
{
    public class CuentaBanco
    {
        public double balance { get; set; }

        public string Propietario { get; set; }

        public bool esta_bloqueada { get; set; }

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

        public string retornartextofondos()
        {
            if (balance > 0)
            {
                return "Hay fondos";
            }
            else if (esta_bloqueada)
            {
                return "Fondos bloqueados";
            }
            else
            {
                return "No hay fondos";
            }
        }
    }
}

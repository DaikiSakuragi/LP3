public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set;}
    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        VerificacaoValor(valor);
        ValidarValor(valor);
        Saldo = Saldo - valor;
    }

    public void Depositar(double valor){
        VerificacaoValor(valor);
        
        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        this.Sacar(valor);
        conta.Depositar(valor);
    }

    private void VerificacaoValor(double valor)
    {
        if(valor <= 0.0)
            throw new ArgumentException("Esta conta não possui saldo");
    }

    private void ValidarValor(double valor)
    {
        if(valor > Saldo)
        {
            throw new ArgumentException("O valor que está sendo transferido é maior que o valor que a conta possui atualmente ");
        }
    }
}
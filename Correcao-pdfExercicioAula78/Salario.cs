<<<<<<< HEAD
public class Salario
{
    public double Salario { get; set; }

    public Salario(double salario)
    {
        Salario = salario;
    }

=======
/*
Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.

*/
using System.Globalization;

public class Salario
{

    public int Id { get; set; }    
    public string Nome { get; set; }

    public double SalarioInformado { get; private set; }

    public Salario(int id, double salarioInformado, string nome)
    {
        Id = id;
        Nome = nome;
        SalarioInformado = salarioInformado;
    }

    public void aumentoSalarial(double porcentagem)
    {
        SalarioInformado =  SalarioInformado + SalarioInformado * porcentagem / 100.0;
    }

    public override string ToString()
    {
        return $"{Id}, {Nome}, {SalarioInformado.ToString("F2", CultureInfo.InvariantCulture)}";
    }


>>>>>>> 78a3eb8 (Subindo Exercícios)
}
// See https://aka.ms/new-console-template for more information

//Esse é um objeto criado através da classe animal, usando método contrutor. O Objeto é um elemento real com os atributos da classe preenchidos
Animal cachorro1 = new("Rex", "Cachorro");

cachorro1.ExibirDados();

//A classe define um diagrama, um conjunto de códigos que pode ser usadao para criar objetos
public class Animal
{
    //Os atributos são características que objetos criados pela classe podem ter
    protected String Nome { get; set; }
    protected String Tipo { get; set; }

    //O método construtor é uma função que pode ser chamada para criar um objeto baseado na classe
    public Animal(String nome, String tipo)
    {
        Nome = nome;
        Tipo = tipo;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}.");
        Console.WriteLine($"Tipo: {Tipo}.");
    }
}

using System;

 class Alunos { 
    public static void Main() {
        string[] nomes;
        nomes = new string[5];
        double[] notas = new double[5];
        double soma = 0, media;
        for (int i = 0 ; i <= 4 ; i++){
            Console.WriteLine("Entre com o nome do aluno nº "+(i+1));
            nomes[i] = Console.ReadLine();
            Console.WriteLine("Entre com a nota do aluno nº "+(i+1));
            notas[i] = Console.Read();
            soma = soma + notas[i];
        }
        media = soma / 5;
        Console.WriteLine("A média dos alunos é: "+ media);
        Console.WriteLine("Lista dos alunos cuja nota é superior a média da turma");
        for(int i = 0; i <= 4; i++) {
            if(notas[i] > media)
                Console.WriteLine(nomes[i]);    
        }
    }
}
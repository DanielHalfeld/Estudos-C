using System;

class Aula09{
    public static void Main(){

        int num = 10;

        num = num << 1;
        // o << é um operador bitwise que desloca as casas binárias do número em questão para a esquerda de acordo com o valor dado (1 no caso)

        Console.WriteLine(num);

        num = num >> 1;
        // o >> é um operador bitwise que desloca as casas binárias do número em questão para a direita de acordo com o valor dado (1 no caso)

        Console.WriteLine(num);
    }
}

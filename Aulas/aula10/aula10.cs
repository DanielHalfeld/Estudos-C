using System;



class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main(){

        //DiasSemana ds = DiasSemana.Domingo;
        //DiasSemana ds = (DiasSemana)0;
        int ds = (int)DiasSemana.Domingo;
        
        Console.WriteLine(ds);

        }
}
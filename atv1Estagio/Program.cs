 using System;

namespace atvEstagio
 {
     class Program
     {
         static void Main(string[] args)
         {
            Calculo();
         }

         static void Calculo(){
            int indice = 13;
            int soma = 0;
            int K = 0;

            while(K < indice){
                K ++;
                soma = soma + K;
            }

            Console.WriteLine(soma);
         }
}    }
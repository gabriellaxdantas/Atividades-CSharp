﻿int comparacoes = 0,  n=10;

    for (int i = 0; i < n; i++){
        if (n == 10)
            comparacoes+=1;
        if ( n == 9)
            comparacoes+=1;
        if (n > 10)
            comparacoes+=1;
        if (n < 9 )
            comparacoes+=1;
        
    }
    comparacoes = comparacoes - 1;
    Console.WriteLine("O número de comparações é: {0}", comparacoes);

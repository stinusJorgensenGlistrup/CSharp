// der ønskes at finde fibonaccitalllet fra dens position i rækkefølgen
int RecursiveFibonacci(int first, int second, int count)
{
    count--;
    int next = first + second;
    
    if(count == 0) {
        return(next);
    }else{
        return RecursiveFibonacci(second, next, count);
    }
}
int lastFibo = RecursiveFibonacci(1,1,7);
Console.WriteLine("Last fibo number was " + lastFibo);
Console.ReadLine(); 

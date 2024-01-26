int M = GetNumber();
int N = GetNumber();
Print(M,N);

int GetNumber(){
    Console.WriteLine("Enter the number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Print(int M, int N){
    if(M<=N){
        Console.WriteLine(M);
        Print(++M, N);
    }
}

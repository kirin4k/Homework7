int n = GetNumber();
int m = GetNumber();
Console.WriteLine(Ackerman(n,m));

int GetNumber(){
    Console.WriteLine("Enter the postive number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Ackerman(int n, int m){
    if(n==0){
        return m+1;
    }
    else if (m==0){
        return Ackerman(n-1,1);
    }
    else
    return Ackerman(n-1, Ackerman(n,m-1));
}

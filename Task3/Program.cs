int[] array = {1,5,9,7,10};
Reverse(array);

void Reverse(int[] arr, int i = 0){;
    if(i<arr.Length){
        Reverse(arr, i+1);
         Console.WriteLine(arr[i]);
    }

}
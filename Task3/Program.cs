int[] array = {1,5,9,7,10,55,183,2,45};
Reverse(array);

void Reverse(int[] arr, int i = 0){
    if(i<arr.Length){
        Reverse(arr, i+1);
         Console.Write(arr[i] + " /");
    }

}
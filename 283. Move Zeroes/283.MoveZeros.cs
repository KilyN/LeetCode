public class Solution {
    public void MoveZeroes(int[] arr) {
        
        int length = arr.Length;
       
        Queue<int> q = new Queue<int>();
        
        int count = 0;
        
        foreach(int item in arr){
            if (item == 0){count++;}
            if(item!=0){
                q.Enqueue(item);  
            }
        }
     
        while(count>0){
            q.Enqueue(0);
            count--;
        }
        for(int i=0;i<length;i++){
            arr[i]=q.Dequeue();
        }
      
      
    }
}
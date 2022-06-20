public class Solution {
   
    public void Rotate(int[] arr, int k) {
           
        int length = arr.Length;
      
        if(length==1) return;
        while(k>length){
             k=k-length;
        }  
       
       Queue<int> q = new Queue<int>();
       
        for(int i=length-k;i<length;i++){
            q.Enqueue(arr[i]);
        }
   
        
        for(int i=0;i<length-k; i++){
            arr[length-1-i] = arr[length-1-k-i];
        }
        
        int qLength = q.Count;
        for(int i=0; i < qLength; i++){
        arr[i]=q.Dequeue();
        }

    }
    
}
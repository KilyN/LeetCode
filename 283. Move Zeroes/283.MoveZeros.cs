public class Solution {
    public int[] TwoSum(int[] num, int target) {
        
         int left = 0, right = num.Length-1;
      
        int looking = 0;
        for(int i = 0;i<num.Length;i++){
           left = i+1;
            while(left<=right){
                int mid = left+(right-left)/2;
                looking = target - num[i];
           
                if(looking==num[mid]){
                    return new int[2]{i+1,mid+1};
                    break;
                }else if(looking<num[mid]){
                    right = mid -1;
                }else{
                    left = mid +1;
                }
            }
        }
        return new int[2]{0,0};
        
        
    }
}
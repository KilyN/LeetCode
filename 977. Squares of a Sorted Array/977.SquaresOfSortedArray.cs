public class Solution {
    public int[] SortedSquares(int[] nums) {
        
        bool swapped;
        
        for(int i=0;i<nums.Length;i++){
            nums[i] = nums[i]*nums[i];
        }
        
        for(int i=0;i<nums.Length-1;i++){
            swapped = false;
            for(int j=0;j<nums.Length-i-1;j++){
                if(nums[j]>nums[j+1]){
                    int temp = nums[j];
                    nums[j]= nums[j+1];
                    nums[j+1]= temp;
                    swapped = true;
                }
            }
            if(swapped == false){
                break;
            }
        }
        
    return nums;
        
    }
}
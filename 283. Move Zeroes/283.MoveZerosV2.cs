public class Solution {
    public void MoveZeroes(int[] nums) {
        
        int zeroCarrier = 0;
        
        for(int i = 0;i<nums.Length;i++){
              if(nums[i]!=0){
                int temp = nums[zeroCarrier];
                nums[zeroCarrier]=nums[i];
                nums[i]=temp;

                zeroCarrier++;
            }
            
        }
        
    }
}
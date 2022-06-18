public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int result = 0;
        for(int i = 0; i < nums.Length;i++){
            if(target <= nums[i]){
                return result = i;
                break;
            }
            else{
                result = nums.Length;
            }
        }
        return result;
    }
}
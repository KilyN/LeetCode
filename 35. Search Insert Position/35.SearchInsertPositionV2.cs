public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int left = 0, right = nums.Length-1;

        while(left<=right){
            
            int mid = left+(right-left)/2;
            if(target == nums[mid]){
                return mid;
                break;
            }
            if(target > nums[mid]){
                left = mid +1;
            }else{
                right = mid -1;
            }
        }
        
        return left;
    }
}
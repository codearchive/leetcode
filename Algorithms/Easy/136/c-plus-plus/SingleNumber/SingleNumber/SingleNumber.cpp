#include <iostream>
#include <vector>

class Solution {
public:
    int singleNumber(std::vector<int>& nums)
    {
        int res = nums[0];
        for (int i = 1; i < nums.size(); ++i)
        {
            res ^= nums[i];
        }
        return res;
    }
};

int main()
{
    std::vector<int> input_arr = { 1,2,4,1,2 };
    Solution sln;
    std::cout << sln.singleNumber(input_arr) << std::endl;
}
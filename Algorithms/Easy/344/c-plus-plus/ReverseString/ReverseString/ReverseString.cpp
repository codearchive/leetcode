#include <iostream>
#include <vector>

class Solution {
public:
    void reverseString(std::vector<char>& s) {
        const int s_size = s.size();
        for (int i = 0; i < s_size / 2; ++i)
        {
            const auto temp = s[i];
            s[i] = s[s_size - 1 - i];
            s[s_size - 1 - i] = temp;
        }
    }
};

void print_string(const std::vector<char>& str)
{
    for (auto c : str)
        std::cout << c << ' ';
    std::cout << std::endl;
}

int main()
{
    Solution sln;
    std::vector<char> str = { 'h', 'e', 'l', 'l', 'o' };
    std::cout << "\tinput: ";
    print_string(str);
    sln.reverseString(str);
    std::cout << "\toutput: ";
    print_string(str);

    return 0;
}

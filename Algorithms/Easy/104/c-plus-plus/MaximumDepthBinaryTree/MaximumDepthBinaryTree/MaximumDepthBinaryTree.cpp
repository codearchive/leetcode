#include <iostream>
#include <queue>

struct TreeNode {
    int val;
    TreeNode *left;
    TreeNode *right;
    TreeNode(int x) : val(x), left(NULL), right(NULL) {}
};

class Solution
{
public:
    Solution()
    {
        root = NULL;
    }

    TreeNode* root;

    // Insert function for special case (binary tree search) 
    TreeNode* insert(const int& new_value, TreeNode* root)
    {
        if (root == NULL)
        {
            root = new TreeNode(new_value);
        }
        else if (new_value < root->val)
        {
            root->left = insert(new_value, root->left);
        }
        else if (new_value > root->val)
        {
            root->right = insert(new_value, root->right);
        }
        return root;
    }

    int maxDepth(TreeNode* root)
    {
        if (root == NULL)
        {
            return NULL;
        }
        int res = 0;
        std::queue<TreeNode*> q;
        q.push(root);

        while (!q.empty())
        {
            ++res;
            for (int i = 0, n = q.size(); i < n; ++i)
            {
                TreeNode* tmp = q.front();
                q.pop();
                if (tmp->left != NULL)
                {
                    q.push(tmp->left);
                }
                if (tmp->right != NULL)
                {
                    q.push(tmp->right);
                }
            }
        }
        return res;
    }

    /*int maxDepth(TreeNode* root)
    {
        return root == NULL ? 0 : std::max(maxDepth(root->left), maxDepth(root->right)) + 1;
    }*/
};

int main()
{

    Solution sln;
    std::vector<int> arr = { 11, 10, 15, 8, 9, 12, 16 };
    for (int i = 0; i < arr.size(); ++i)
    {
        sln.root = sln.insert(arr[i], sln.root);
    }
    std::cout << sln.maxDepth(sln.root);
    return 0;

}

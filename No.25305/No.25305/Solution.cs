﻿int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = input[0];
int k = input[1];

int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - 1 - i; j++)
    {
        if (nums[j] < nums[j+1])
        {
            int tmp = nums[j];
            nums[j] = nums[j+1];
            nums[j+1] = tmp;
        }
    }
}

Console.WriteLine(nums[k - 1]);
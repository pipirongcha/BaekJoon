using System.Security.AccessControl;

int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = nk[0];
int k = nk[1];
int res = 0;
bool pause = false;

MergeSort(nums, 0, n-1);

void MergeSort(int[] nums, int front, int terminal)
{
    if(front >= terminal)
    {
        return;
    }
    int mid = (front+terminal)/2;

    MergeSort(nums, front, mid);
    MergeSort(nums, mid+1, terminal);
    Merge(nums, front, mid, terminal);
}

void Merge(int[] nums, int front, int mid, int terminal)
{
    if (!pause)
    {
        int[] tmp = new int[terminal-front+1];
        int i = front;
        int j = mid + 1;
        int idx = 0;

        while (i <= mid && j <= terminal)
        {
            if (nums[i] <= nums[j])
            {
                tmp[idx++] = nums[i++];
            }
            else
            {
                tmp[idx++] = nums[j++];
            }

        }
        while (i <= mid)
        {
            tmp[idx++] = nums[i++];
        }
        while (j <= terminal)
        {
            tmp[idx++] = nums[j++];
        }

        for (int l = 0; l < tmp.Length; l++)
        {
            k--;
            if(k == 0)
            {
                res = tmp[l];
                pause = true;
                break;
            }
            nums[front + l] = tmp[l];
        }

    }
}


if (k > 0)
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine(res);
}


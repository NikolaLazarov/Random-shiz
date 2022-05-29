string t = "The sun is 400 times bigger then the moon and π is equal to 3.1415";
string s = "";
char[] nums = t.ToCharArray();
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == '.' || nums[i] >= (char)48 && nums[i] <= (char)57)
    {
        s += nums[i];
        if (nums[i] != nums[nums.Length - 1])
        {
            if (nums[i + 1] != '/' && nums[i + 1] < (char)46 || nums[i + 1] > (char)57)
            {
                s += " ";
            }
        }
    }
}
Console.WriteLine("The string:\n" + t);
Console.WriteLine("\nThe extracted numbers:\n" + s);
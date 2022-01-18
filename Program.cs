int [] numbers = new int[] {1,2,3,4,5,6,7,8,9};
Console.WriteLine("[{0}]->", string.Join(" ", numbers));
Console.WriteLine("->");
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    Console.WriteLine("[{0}]", string.Join(" ", numbers[i]));
}
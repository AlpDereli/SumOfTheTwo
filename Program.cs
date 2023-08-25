// See https://aka.ms/new-console-template for more information
List<int> ilist = new List<int>();

Console.WriteLine("Please enter integer numbers with one space between and please enter even number of numbers(12 11 9 2...): ");
string s = Console.ReadLine();
string[] arr = s.Split();
foreach (string ss in arr)
{
    int s1 = int.Parse(ss);
    ilist.Add(s1);
}
for (int i = 0; i < ilist.Count; i+=2)
{
    int sum = 0;
    if (ilist[i] == ilist[i+1])
    {
        int subs = ilist[i]*2;
        sum = subs * subs;
    }
    else
    {
        sum = ilist[i] + ilist[i+1];
    }
    Console.Write(sum + " ");
}


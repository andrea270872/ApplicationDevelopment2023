class Program
{
	static List<int> numList = new List<int>();
	static void Main(string[] args)
	{
		LoadList(10);
		foreach (int i in numList)
		{
			Console.WriteLine(i);
		}
		Console.ReadLine();
	}
	static void LoadList(int iMax)
	{
		for (int i = 1; i <= iMax; i++)
		{
			numList.Add(i);
		}
	}
}
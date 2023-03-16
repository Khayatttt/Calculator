class Calculator
{
	static void main (string[] args)
	{
		int a = 10;
		int b = 6;
		Console.writeline("Hasil Penambahan: {0} + {1} = {2}", a,b, Penambahan (a,b));
		Console.writeline("Hasil Pengurangan: {0} - {1} = {2}", a,b, Pengurangan (a,b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar")';
		Console.ReadKey();
	}
	
	static int penambahan (int a, int b)
	{
		return a + b;
		
	}
	
	static int pengurangan (int a, int b)
	{
		return a - b;
}
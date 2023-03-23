using System;
//using NumSharp;

public class Program
{
	public static void Main()
	{
		int[] a=new int[8];    //1-D array must have size
		a[0]=1;
		for (int i=0;i<a.Length;i++)
		{
			a[i]=i;
		}
		foreach (int j in a)
		{
			Console.Write(j+" ");
		}
		Console.WriteLine();
		int[] c=new int[8];
		int[] d=new int[8];
		int[][] b=new int[3][]; //2-D array needs only one input size

		b[0]=a;
		b[1]=c;
		b[2]=d;
		Console.WriteLine(b[0][1]);

		for (int i=0;i<c.Length;i++)
		{
			c[i]=10-i;
		}
		Console.WriteLine(c.GetValue(0)); //SetValue & GetValue can only access value at certain coordinate(s). eg. if only 1-D, then only one parameter will be accepted, vice-versa.

    Console.WriteLine("==================================");
    //converting string to int
		string numString="123;1235;465;654;973;56787;565";
		string[] nums=numString.Split(';');

		int counter=0;
		int sum=0;
		while (counter<nums.Length)
		{
			int num=Convert.ToInt32(nums[counter]);
			sum=sum+num;
			counter++;
		}
		Console.WriteLine(sum);

    Console.WriteLine("==================================");
    //creating jaggedarray and matrices
		char[] arrA=new char[]{'r','e','t','y'};
		char[] arrB=new char[]{'c','v','b','g','z'};
		char[] arrC=new char[]{'a','c','f','j','y','e'};
		char[] arrD=new char[]{'z','k'};

		char[][] arrJagged=new char[4][]{arrA, arrB, arrC, arrD}; //can pass variable directly

		for (int i=0;i<arrJagged.Length;i++)
		{
			for (int j=0; j<arrJagged[i].Length;j++)
			{
				Console.Write(arrJagged[i][j]+" ");
			}
			Console.WriteLine();
		}
		/*Console.WriteLine("===================================");
		var matrixA=np.zeros(2,3);
		Console.WriteLine(matrixA.ToString());
		Console.WriteLine("===================================");
		NDArray a=new double[,]{{1,2,3},{4,5,6}};
		NDArray b=new double[,]{{4,2},{1,5},{5,6}};
		Console.WriteLine(a.dot(b).ToString());*/
	}
}

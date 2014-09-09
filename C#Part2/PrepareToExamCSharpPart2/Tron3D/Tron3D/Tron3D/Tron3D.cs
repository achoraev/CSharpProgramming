using System;
using System.Collections.Generic;
using System.Text;

class Tron3D
{
  static void Main()
  {
	// input
	string [] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
	ulong x = ulong.Parse(input[0]);
	ulong y = ulong.Parse(input[1]);
	ulong z = ulong.Parse(input[2]);
	StringBuilder inputMovesRed = new StringBuilder();
    StringBuilder inputMovesBlue = new StringBuilder();
	int [,,] cube = new int [x,y,z];
	//int startPosRed = x/2, y/2;
	//int startPosBlue = x/2, y/2;
	int countMovesRed = 3;
	inputMovesRed.Append(Console.ReadLine().TrimEnd());
    inputMovesBlue.Append(Console.ReadLine().TrimEnd());
   //solution
   
   
   
   //print
   if (countMovesRed == 3)
   {
		Console.WriteLine("RED");
		Console.WriteLine(countMovesRed);
   }
   else if (countMovesRed == 3)
   {
		Console.WriteLine("BLUE");
		Console.WriteLine(countMovesRed);
   }
   else 
   {
		Console.WriteLine("DRAW");
		Console.WriteLine(countMovesRed);
   }
  }
}

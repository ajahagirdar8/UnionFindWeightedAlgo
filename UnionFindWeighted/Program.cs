using System;

namespace QuickUnion
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			QuickUnionWtd qu = new QuickUnionWtd (6);

			bool b = qu.isConnected (1, 2);

			Console.WriteLine ("1, 2 " + b);

			qu.Union (1, 2);
			Console.WriteLine ("1, 2 " + b);

		    b = qu.isConnected (2, 3);

			Console.WriteLine ("2, 3 " + b);

			qu.Union (2, 3);
			Console.WriteLine ("2, 3 " + b);

			Console.WriteLine ("Size[1] " + qu.getTreeSize (1));
			Console.WriteLine ("Size[2] " + qu.getTreeSize (2));
			Console.WriteLine ("Size[3] " + qu.getTreeSize (3));

		}
	}
}

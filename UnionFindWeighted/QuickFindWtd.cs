using System;

namespace QuickUnion
{
	public class QuickUnionWtd
	{
		int[] ID;
		int[] Size;

		public QuickUnionWtd (int N)
		{
			ID = new int[N];
			Size = new int[N];

			for (int i = 0; i < N; i++) {

				ID [i] = i;
				Size[i]= 1;
			}
		}

		public int getTreeSize(int n)
		{
			return Size [n];
		}
		public int getRoot(int p)
		{
			while (ID [p] != p)
				p = ID [p];

			return p;
		}

		public bool isConnected(int p, int q)
		{
			return getRoot (p) == getRoot (q);
		}

		public void Union(int p, int q)
		{
			int rootP = getRoot (p);
			int rootQ = getRoot (q);

			if (Size [rootP] == Size [rootQ])
				ID [rootP] = rootQ;
			else if (Size [rootP] > Size [rootQ]) {
				ID [rootQ] = rootP;
				Size [rootP] += Size [rootQ];
			} else {
				ID [rootP] = rootQ;
				Size [rootQ] += Size [rootP];
			}

		}
			

	}
}


using System;
using System.Collections.Generic;

namespace Tasks
{
    public static class ArrayOperations
    {
		/// <summary>
		/// Removes even-counted elements from input array.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">Input array</param>
		/// <returns>
		/// New array without even-counted elements.
		/// </returns>
		/// <exception cref="NullReferenceException">
		/// If array is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// If array element is null.
		/// </exception>
		public static T[] RemoveEvenCounted<T>(T[] array)
        {
			Dictionary<T, bool> d = new Dictionary<T, bool>(array.Length);

			for (int i = 0; i < array.Length; i++) // O(n)
			{
				if (d.ContainsKey(array[i])) // O(1)
					d[array[i]] = !d[array[i]];
				else
					d.Add(array[i], true); // O(1)		
			}

			T[] output = new T[array.Length];
			int n = 0;

			for (int i = 0; i < array.Length; i++) //O(n)
			{
				if (d[array[i]]) //O(1)
					output[n++] = array[i];
			}

			Array.Resize(ref output, n); //O(n)

			return output;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="array">Input array</param>
		/// <returns>
		/// Returns maximum length of continuous sequence of equals elements in input array.
		/// </returns>
		/// <exception cref="NullReferenceException">
		/// If input array is null.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// If element in input array is null.
		/// </exception>
		public static int MaxEqualSequenceLength<T>(T[] array)
		{
			if (array.Length == 0)
				return 0;
			
			T v = array[0];
			int maxc = 1;
			int c = 1;

			object q;

			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == null)
					throw new ArgumentNullException(i + " element is null");

				if (array[i].Equals(v)) c++;
				else
				{
					v = array[i];
					if (maxc < c) maxc = c;
					c = 1;
				}
			}

			return maxc > c ? maxc : c;
		}
	}
}

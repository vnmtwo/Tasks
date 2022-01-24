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
		/// <param name="array"></param>
		/// <returns>
		/// New array without even-counted elements.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// If array is null.
		/// If array element is null.
		/// </exception>
		public static T[] RemoveEvenCounted<T>(T[] array)
        {
			if (array == null)
				throw new ArgumentNullException("Input array is  null");

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
	}
}

using System;
using System.Collections.Generic;

namespace Utils
{
	internal static class EnumerableExtensions
	{
		public static void Each<T>(this IEnumerable<T> instance, Action<T> action)
		{
			foreach (T item in instance)
			{
				action(item);
			}
		}
	}
}
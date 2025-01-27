﻿
public static class ListExtensions
{
    public static int? FindIndexInSorted<T>(
         this IList<T> list, T itemToFind) where T : IComparable<T>
    {
        int leftBound = 0;
        int rightBound = list.Count - 1;

        while (leftBound < rightBound)
        {
            int middleIndex = (leftBound + rightBound) / 2;
            if (list[middleIndex].Equals(itemToFind))
            {
                return middleIndex;
            }
            else if (itemToFind.CompareTo(list[middleIndex]) < 0)
            {
                rightBound = middleIndex - 1;
            }
            else if(itemToFind.CompareTo(list[middleIndex]) > 0) 
            {
               leftBound = middleIndex + 1;
            }

        }

        return null;
    }

}

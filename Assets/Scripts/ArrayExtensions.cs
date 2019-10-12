using UnityEngine;

public static class ArrayExtensions
{
    public static T RandomItem<T>(this T[] array)
    {
        var idx = Random.Range(0, array.Length);
        return array[idx];
    }
}

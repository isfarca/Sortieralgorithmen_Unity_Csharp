using UnityEngine;

public class ArraySort : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Declare variables
        int[] values = GetRandomArray(5);

        // Output original array
        Debug.Log("---------- Original ----------");
        for (int i = 0; i < values.Length; i++)
            Debug.LogFormat("Array index ' {0} ': ' {1} '", i, values[i]);

        // Swap zero and one index of the original array
        Debug.Log("---------- Swapped ----------");
        Swap(values, 0, 1);
        for (int i = 0; i < values.Length; i++)
            Debug.LogFormat("Array index ' {0} ': ' {1} '", i, values[i]);

        // Sort array and Output sortial array
        Debug.Log("---------- BubbleSorted ----------");
        BubbleSort(values);
        for (int i = 0; i < values.Length; i++)
            Debug.LogFormat("Array index ' {0} ': ' {1} '", i, values[i]);

        Debug.Log("---------- SelectionSorted ----------");
        SelectionSort(values);
        for (int i = 0; i < values.Length; i++)
            Debug.LogFormat("Array index ' {0} ': ' {1} '", i, values[i]);
    }

    /// <summary>
    /// Sorting array with 'Bubble Sort'-Algorithm.
    /// </summary>
    /// <param name="array">Transfer the current array from main function.</param>
    void BubbleSort(int[] array)
    {
        // Declare variables
        int loops = array.Length;

        while (loops != 0)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    Swap(array, i, i + 1);
            }

            loops--;
        }
    }

    /// <summary>
    /// Sorting array with 'Selection Sort'-Algorithm.
    /// </summary>
    /// <param name="array">Transfer the current array from main function.</param>
    void SelectionSort(int[] array)
    {
        // Declare variables
        int minimumValuePointer;

        for (int firstPointer = 0; firstPointer < array.Length; firstPointer++)
        {
            minimumValuePointer = firstPointer;

            for (int secondPointer = firstPointer + 1; secondPointer < array.Length; secondPointer++)
            {
                if (array[minimumValuePointer] > array[secondPointer])
                    minimumValuePointer = secondPointer;
            }

            if (minimumValuePointer != firstPointer)
                Swap(array, firstPointer, minimumValuePointer);
        }
    }

    /// <summary>
    /// Swap the values from two variables.
    /// </summary>
    /// <param name="array">Transfer the current array from main function.</param>
    /// <param name="a">Minimum index.</param>
    /// <param name="b">Maximum index</param>
    void Swap(int[] array, int a, int b)
    {
        // Declare variables
        int temp = array[a];

        array[a] = array[b];
        array[b] = temp;
    }

    /// <summary>
    /// Set length from array and random values in array.
    /// </summary>
    /// <param name="length">Length from array.</param>
    /// <returns>Filled array.</returns>
    int[] GetRandomArray(int length)
    {
        // Declare variables
        int[] temp = new int[length];

        for (int i = 0; i < temp.Length; i++)
            temp[i] = Random.Range(0, 100);

        return temp;
    }
}
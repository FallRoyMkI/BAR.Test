namespace BAR.Models;

public struct CustomStructure
{
    public int Length { get; private set; }
    private int[] _array;

    public CustomStructure()
    {
        Length = 0;
        _array = Array.Empty<int>();
    }
    public int[] Result()
    {
        int[] resultArray = new int[Length];
        for (int i = 0; i < Length; i++)
        {
            resultArray[i] = _array[i];
        }
        return resultArray;
    }

    public void AddRangeInEnd(int[] numbers)
    {
        foreach (var number in numbers)
        {
            AddElementInEnd(number);
        }
    }

    public void SortAsc()
    {
        for (int i = 0; i < Length; i++)
        {
            for (int j = 0; j < Length - 1 - i; j++)
            {
                if (_array[j + 1] < _array[j])
                {
                    (_array[j], _array[j + 1]) = (_array[j + 1], _array[j]);
                }
            }
        }
    }

    private void AddElementInEnd(int number)
    {
        if (Length == _array.Length) { UpSize(); }

        _array[Length] = number;
        Length++;
    }
    private void UpSize()
    {
        int newLength = (int)((Length + 1) * 1.3);
        int[] newArray = new int[newLength];
        for (int i = 0; i < _array.Length; i++)
        {
            newArray[i] = _array[i];
        }
        _array = newArray;
    }
}
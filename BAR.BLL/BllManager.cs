using BAR.Contracts;
using BAR.Models;
using System.Text.Json;

namespace BAR.BLL;

public class BllManager : IBllManager
{
    private readonly Client _client = new();

    public bool GetAbsSumForEverySecondOddNumberInArray(int[] array)
    {
        int resultSum = 0;
        int counter = 0;

        foreach (var number in array)
        {
            if (number % 2 != 1) continue;

            counter++;
            if (counter % 2 == 0)
            {
                resultSum += Math.Abs(number);
            }
        }

        string json = JsonSerializer.Serialize(resultSum);
        return _client.GetSumResponse(json);
    }

    public bool IsStringPalindrome(string line)
    {
        int length = line.Length;
        bool result = true;

        for (int i = 0; i < length / 2; i++)
        {
            if (line[i] == line[length - 1 - i]) continue;
            result = false;
            break;
        }

        string json = JsonSerializer.Serialize(result);
        return _client.GetPalindromeResponse(json);
    }

    public bool CustomSort(int[] args)
    {
        CustomStructure arrayList = new();
        arrayList.AddRangeInEnd(args);
        arrayList.SortAsc();

        string json = JsonSerializer.Serialize(arrayList.Result());
        return _client.GetSortResponse(json);
    }
}
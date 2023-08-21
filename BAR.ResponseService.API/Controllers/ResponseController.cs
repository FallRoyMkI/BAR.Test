using Microsoft.AspNetCore.Mvc;

namespace BAR.ResponseService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ResponseController : ControllerBase
{
    [HttpPost("/GetSumResponse")]
    public IActionResult GetSumResponse([FromBody] int sum)
    {
        string response = $"����� ���� ������ �������� ��������� ��������� ������� = {sum}";
        Console.WriteLine(response);
        return Ok();
    }

    [HttpPost("/GetPalindromeResponse")]
    public IActionResult GetPalindromeResponse([FromBody] bool isPalindrome)
    {
        string response = isPalindrome ? "��������� ������ �������� �����������" : "��������� ������ �� �������� �����������";
        Console.WriteLine(response);
        return Ok();
    }

    [HttpPost("/GetSortResponse")]
    public IActionResult GetSortResponse([FromBody] int[] array)
    {
        Console.WriteLine("������ � ��������������� ����:");
        array.ToList().ForEach(item => Console.Write($"{item} "));
        Console.WriteLine();
        return Ok();
    }
}
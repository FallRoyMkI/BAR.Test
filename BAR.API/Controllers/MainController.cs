using BAR.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BAR.API.Controllers;

[ApiController]
[Route("[controller]")]
public class MainController : ControllerBase
{
    private readonly IBllManager _bllManager;

    public MainController(IBllManager bllManager)
    {
        _bllManager = bllManager;
    }

    [HttpPost("/GetAbsSumForEverySecondOddNumberInArray")]
    public IActionResult GetAbsSumForEverySecondOddNumberInArray([FromBody] int[] array)
    {
        try
        {
            bool result = _bllManager.GetAbsSumForEverySecondOddNumberInArray(array);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return BadRequest();
        }
    }

    [HttpPost("/IsStringPalindrome")]
    public IActionResult IsStringPalindrome([FromBody] string line)
    {
        try
        {
            bool result = _bllManager.IsStringPalindrome(line);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return BadRequest();
        }
    }

    [HttpPost("/CustomSort")]
    public IActionResult CustomSort([FromBody] int[] array)
    {
        try
        {
            bool result = _bllManager.CustomSort(array);
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return BadRequest();
        }
    }
}
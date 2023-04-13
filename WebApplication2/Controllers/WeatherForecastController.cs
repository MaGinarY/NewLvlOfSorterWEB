using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AreaColculatorController : ControllerBase
    {        
        [HttpGet("Square")]
        public int Square(int A, int B)
        {            
            return A * B;
        }
        [HttpGet("circle")]
        public double circle(double R, double p = 3.14)
        {
            return R * p;
        }
    }
    [ApiController]
    [Route("[controller]")]
    public class SorterinhoController : ControllerBase
    {
        [HttpPost("SorterOfDouble")]
        public double[] SortDouble(double[] notSortedArray)
        {
            var sortedArray = Sorter.SortDouble(notSortedArray);
            return sortedArray;

        }
        [HttpPost("SorterOfInt")]        
        public int[] Sort(int[] notSortedArray)
        {
            var sortedArray = Sorter.Sort(notSortedArray);
            return sortedArray;
        }

        [HttpPost("SorterOfChar")]
        public char[] SortChar(char[] notSortedChar)
        {
            var sortedArray = Sorter.SortChar(notSortedChar);
            return sortedArray;
        }
        [HttpPost("SorterOfString")]
        public string SortString(string notSortedString)
        {
            var sortedArray = Sorter.SortString(notSortedString);
            return sortedArray;
        }
    } 
}
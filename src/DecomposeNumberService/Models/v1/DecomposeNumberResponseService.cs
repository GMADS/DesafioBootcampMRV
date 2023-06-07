using System.Collections.Generic;

namespace DecomposeNumber.Services.Models.v1
{
    public class DecomposeNumberResponseService
    {
        public DecomposeNumberResponseService(List<int> dividerNumber, List<int>dividerNumbersPrime)
        {
            DividerNumbers = dividerNumber;
            DividerNumbersPrime = dividerNumbersPrime;
        }
        public List<int> DividerNumbers { get; set; }
        public List<int> DividerNumbersPrime { get; set; }
    }
}

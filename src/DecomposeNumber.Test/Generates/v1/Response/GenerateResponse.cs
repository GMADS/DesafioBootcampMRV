using DecomposeNumber.Services.Models.v1;
using DecomposeNumber.Services.Shared.v1;
using System.Collections.Generic;

namespace DecomposeNumber.Test.Generates.v1.Response
{
    public static class GenerateResponse
    {
        public static DecomposeNumberResponseService GetGenerateResponseSuccess()
        {
            var dividerNumbers = new List<int>()
            {
                1,
                2,
                5,
                10
            };

            var dividerNumbersPrime = new List<int>()
            {
                2,
                3,
                5,
                7
            };

            return new DecomposeNumberResponseService(dividerNumbers, dividerNumbersPrime);
        }

        public static object GetGenerateResponseFailed() =>
            ErrorMessageConst.FailureDecompose;
    }
}

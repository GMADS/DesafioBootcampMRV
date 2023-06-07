using DecomposeNumber.Service.Interface.v1;
using DecomposeNumber.Services.Models.v1;
using DecomposeNumber.Services.Shared.v1;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DecomposeNumber.Services.Services.v1
{
    public class DecomposeNumberService : IDecomposeNumberService
    {
        public async Task<DecomposeNumberResponseService> GetDivisorNumbersAsync(int number)
        {
            if (number == 0)
                throw new System.Exception(ErrorMessageConst.FailureDecompose);

            return await CheckDividerNumbersAsync(number);

        }

        private async Task<DecomposeNumberResponseService> CheckDividerNumbersAsync(int number)
        {
            var getNumberPrime = new List<int>();
            var getNumberdivider = new List<int>();
            

            for (int unity = 1; unity <= number; unity++)
            {
                var checkDivisor = number % unity;

                if (checkDivisor == 0)
                    getNumberdivider.Add(unity);

                getNumberPrime.AddRange(await CheckDividerNumbersPrimeAsync(unity));
            }

            return new DecomposeNumberResponseService(getNumberdivider, getNumberPrime);
        }
            
        private async Task<List<int>> CheckDividerNumbersPrimeAsync(int unity)
        {
            if (unity < 0)
                return new List<int>();

            var amountOfDivider = 0;
            var numbersPrime = new List<int>();

            for (int divider = 1; divider <= unity; divider++)
            {
                if (unity % divider == 0)
                    amountOfDivider++;
            }

            if (amountOfDivider == 2)
                numbersPrime.Add(unity);

            return await Task.FromResult(numbersPrime);
        }
    }
}

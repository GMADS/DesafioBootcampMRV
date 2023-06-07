using DecomposeNumber.Services.Services.v1;
using DecomposeNumber.Test.Generates.v1.Request;
using DecomposeNumber.Test.Generates.v1.Response;
using System;
using Xunit;

namespace DecomposeNumber.Test
{
    public class Tests
    {
        static DecomposeNumberService _decomposeNumberService = new DecomposeNumberService();

        [Fact]
        public async void TesteSuccess()
        {
            var result = await _decomposeNumberService.GetDivisorNumbersAsync(GenerateRequest.GetNumberGenerateSuccess());

            var resultExpected = GenerateResponse.GetGenerateResponseSuccess();

            Assert.Equal(resultExpected.DividerNumbers, result.DividerNumbers);
            Assert.Equal(resultExpected.DividerNumbersPrime, result.DividerNumbersPrime);
        }

        [Fact]
        public async System.Threading.Tasks.Task TesteFailed()
        {
            var resultExpected = GenerateResponse.GetGenerateResponseFailed();

            var result = await Assert.ThrowsAsync<Exception>(() => _decomposeNumberService.GetDivisorNumbersAsync(GenerateRequest.GetNumberGenerateFailed()));            

            Assert.Equal(resultExpected, result.Message);
        }
    }
}

using DecomposeNumber.Services.Models.v1;
using System.Threading.Tasks;

namespace DecomposeNumber.Service.Interface.v1
{
    public interface IDecomposeNumberService
    {
        Task<DecomposeNumberResponseService> GetDivisorNumbersAsync(int number);
    }
}

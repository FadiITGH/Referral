using Referral.Models;

namespace Referral.BackEnd.Interfaces
{
    public interface IEmp
    {
        public Task<bool> CheckIfUserExistsInDB(string RefImagePath);
        public Task<string> AddNewRefToSystem(ReferralModel NewRef);
    }
}

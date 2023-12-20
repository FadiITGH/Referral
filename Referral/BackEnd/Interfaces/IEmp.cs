using Referral.Models;

namespace Referral.BackEnd.Interfaces
{
    public interface IEmp
    {
        public Task<bool> CheckIfUserExistsInDB(string RefImagePath);
        public Task<string> AddNewRefToSystem(ReferralModel NewRef);
        public Task<List<ReferralModel>> GetListOfAllRefs();
        public Task<string> DeleteRef(int EmpId);
        public Task<string> DeleteListOfRefs(List<int> ListOfDeletedRefs);
    }
}

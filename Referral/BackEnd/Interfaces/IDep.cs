using Referral.Models;

namespace Referral.BackEnd.Interfaces
{
    public interface IDep
    {

        public Task<string> AddNewDep(DepModel NewDep);
        public Task<List<DepModel>> GetAllDepts();


    }
}

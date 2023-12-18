using Microsoft.EntityFrameworkCore;
using Referral.BackEnd.Interfaces;
using Referral.Data;
using Referral.Models;

namespace Referral.BackEnd.Repos
{
    public class EmpRepo : IEmp
    {
        private readonly ApplicationDbContext _db;

        public EmpRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<string> AddNewRefToSystem(ReferralModel NewRef)
        {
            await _db.ReferralTable.AddAsync(NewRef);
            await _db.SaveChangesAsync();
            return "تم الحفظ";
        }

        public async Task<bool> CheckIfUserExistsInDB(string RefImagePath)
        {
            var CheckIfUserExists = await _db.ReferralTable.FirstOrDefaultAsync(a => a.RefImagePath == RefImagePath);
            if (CheckIfUserExists is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

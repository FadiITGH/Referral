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

        

        public async Task<string> DeleteRef(int EmpId)
        {
            try
            {
                var DeletedRef = await _db.ReferralTable.FirstOrDefaultAsync(a => a.Id == EmpId);
                _db.ReferralTable.Remove(DeletedRef);
                await _db.SaveChangesAsync();
                return $"تم حذف {EmpId} ";
            }
            catch (Exception error)
            {
                return error.Message;
                
            }
            

        }

        public async Task<string> DeleteListOfRefs(List<int> ListOfDeletedRefs)
        {
            try
            {
                var ListOfDeletedRef = new List<ReferralModel>();
                foreach (var item in ListOfDeletedRefs)
                {
                    var Emp = await _db.ReferralTable.FirstOrDefaultAsync(a => a.Id == item);
                    ListOfDeletedRef.Add(Emp);
                }
                _db.ReferralTable.RemoveRange(ListOfDeletedRef);
                await _db.SaveChangesAsync();
                return "تم حذف مجموعة الاحالات المرضية";

            }
            catch (Exception error)
            {

                throw;
            }
        }

        public async Task<List<ReferralModel>> GetListOfAllRefs()
        {
            var ListOfRefs = await _db.ReferralTable.Include(a=>a.DeptTable).ToListAsync();
            return ListOfRefs;
        }
    }
}

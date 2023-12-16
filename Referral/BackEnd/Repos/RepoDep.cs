using Microsoft.EntityFrameworkCore;
using Referral.BackEnd.Interfaces;
using Referral.Data;
using Referral.Models;

namespace Referral.BackEnd.Repos
{
    public class RepoDep : IDep
    {

        private ApplicationDbContext _Db;
        public RepoDep(ApplicationDbContext Db) 
        { 
            _Db = Db;
        }


        //public Task<string> ListOfAllDepts { get; set; }

        public async Task<string> AddNewDep (DepModel NewDep)
        {
            var CheckIfDepExistInDatabase = await _Db.DepTable.FirstOrDefaultAsync(a=>a.DepName == NewDep.DepName);  
        
            if (CheckIfDepExistInDatabase is null)
            {
               await _Db.DepTable.AddAsync(NewDep);
               await _Db.SaveChangesAsync();
               return $"تم اضافة قسم {NewDep.DepName} بنجاح...";
            }
            else
            {
               return "هذا القسم مضاف مسبقاً...";
            }
        }
        public async Task<List<DepModel>> GetAllDepts()
        {
           var ListOfAllDepts = await _Db.DepTable.ToListAsync();
            return ListOfAllDepts;
        }
    }
}

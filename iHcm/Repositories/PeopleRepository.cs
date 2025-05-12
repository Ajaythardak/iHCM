using iHcm.Data;
using iHcm.Models;
using Microsoft.EntityFrameworkCore;

namespace iHcm.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        private PeopleDbContext _context;
        public PeopleRepository(PeopleDbContext peopleDbContext) 
        {
            _context = peopleDbContext;
        }

        public async Task<List<People>> GetPeopleRecords()
        {
            return await _context.People.AsNoTracking().ToListAsync();
        }
        public async Task<People> GetPeopleById(Guid id)
        {
            return await _context.People.FindAsync(id);
        }
        public async Task<People> SavePeopleRecord(PeopleDto people)
        {
            var peopleNew = new People()
            {
                Name = people.Name,
                EmailId = people.EmailId
            };
            _context.People.Add(peopleNew);
            await _context.SaveChangesAsync();
            return peopleNew; 
        }

        
    }
}

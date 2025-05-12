using iHcm.Models;

namespace iHcm.Repositories
{
    public interface IPeopleRepository
    {
        Task<List<People>> GetPeopleRecords();
        Task<People> GetPeopleById(Guid id);
        Task<People> SavePeopleRecord(PeopleDto people);
    }
}

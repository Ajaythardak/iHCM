using iHcm.Models;

namespace iHcm.Services
{
    public interface IPeopleService
    {
        Task<List<People>> GetPeople();
        Task<People> GetPeopleById(Guid id);
        Task<People> AddPeople(PeopleDto people);
    }
}

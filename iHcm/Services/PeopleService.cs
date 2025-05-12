using iHcm.Models;
using iHcm.Repositories;

namespace iHcm.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly PeopleRepository _peopleRepository;
        public PeopleService(PeopleRepository peopleRepository) 
        {
            _peopleRepository = peopleRepository;
        }
        public async Task<List<People>> GetPeople()
        {
            return await _peopleRepository.GetPeopleRecords();
        }

        public async Task<People> GetPeopleById(Guid id)
        {
            return await _peopleRepository.GetPeopleById(id);
        }
        public async Task<People> AddPeople(PeopleDto people)
        {
            return await _peopleRepository.SavePeopleRecord(people);
        }
    }
}

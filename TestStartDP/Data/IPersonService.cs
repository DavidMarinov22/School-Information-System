namespace TestStartDP.Data
{
    public interface IPersonService
    {
        Task<string> CreatePersonAsync(PersonVM StudentVM);
        Task DeletePersonAsync(long id);
        Task UpdatePersonAsync(long id, PersonVM Student);
        IEnumerable<PersonVM> GetAllPersons();
        Task<PersonVM> GetSinglePersonByIdAsync(long id);
    }
}

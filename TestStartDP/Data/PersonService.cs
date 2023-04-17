using Microsoft.EntityFrameworkCore;

namespace TestStartDP.Data
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationDbContext _context;
        public PersonService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreatePersonAsync(PersonVM PersonVM)
        {
            var testPerson = _context.Persons.FirstOrDefault((c) => (c.Indent == PersonVM.Indent));
            string msg = string.Empty;
            if (testPerson == null)
            {
                var Person = ToPerson(PersonVM);
                _context.Persons.AddAsync(Person);
                await _context.SaveChangesAsync();
                msg = "Успешно е добавен ученик!";
            }
            else
            {
                msg = "ERROR/Вече има въведен ученик с това ЕГН!";
            }
            return msg;
        }
        public async Task DeletePersonAsync(long id)
        {
            var Person = _context.Persons.FirstOrDefault(p => p.IdPerson == id);
            if (Person != null)
            {
                _context.Persons.Remove(Person);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdatePersonAsync(long id, PersonVM Person)
        {
            var data = ToPerson(Person);
            var local = _context.Set<Person>().Local.FirstOrDefault(entry => entry.IdPerson.Equals(data.IdPerson));
            // check if local is not null
            if (local != null)
            {
                // detach
                _context.Entry(local).State = EntityState.Detached;
            }
            _context.Entry(data).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public IEnumerable<PersonVM> GetAllPersons()
        {
            var dataVM = new List<PersonVM>();
            foreach (var Person in _context.Persons)
            {
                dataVM.Add(new PersonVM()
                {
                    IdPerson = Person.IdPerson,
                    FirstName = Person.FirstName,
                    SecondName = Person.SecondName,
                    FamilyName = Person.FamilyName,
                    Indent = Person.Indent,
                    BirthDate = Person.BirthDate,
                    Sex = Person.Sex,
                    Email = Person.Email,
                    IdRole = Person.IdRole,
                    RoleName = Person.IdRole == "1" ? "Администратор" : Person.IdRole == "4" ? "Ученик" : Person.IdRole == "5" ? "Учител" : string.Empty
                });
            }
            return dataVM.ToList();
        }

        public async Task<PersonVM> GetSinglePersonByIdAsync(long id)
        {
            var Person = _context.Persons.FirstOrDefault((c) => (c.IdPerson == id));
            return new PersonVM()
            {
                IdPerson = Person.IdPerson,
                FirstName = Person.FirstName,
                SecondName = Person.SecondName,
                FamilyName = Person.FamilyName,
                Indent = Person.Indent,
                BirthDate = Person.BirthDate,
                Sex = Person.Sex,
                Email = Person.Email,
                IdRole = Person.IdRole
            };
        }

        private Person ToPerson(PersonVM Person)
        {
            return new Person()
            {
                IdPerson = Person.IdPerson,
                FirstName = Person.FirstName,
                SecondName = Person.SecondName,
                FamilyName = Person.FamilyName,
                Indent = Person.Indent,
                BirthDate = Person.BirthDate.Value,
                Sex = Person.Sex,
                Email = Person.Email,
                IdRole = Person.IdRole
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripTrakrData;
using TripTrakrModels;

namespace TripTrakrServices
{
    public class PersonService
    {
        private readonly Guid _userId;

        public PersonService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePerson(PersonCreate model)
        {
            var entity =
                new Person()
                {
                    UserId = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    HowKnown = model.HowKnown,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.People.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PersonListItem> GetPeople()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .People
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new PersonListItem
                                {
                                    PersonId = e.PersonId,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    HowKnown = e.HowKnown,
                                }
                        );
                return query.ToArray();
            }
        }

        public PersonDetail GetPersonById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .People
                        .Single(e => e.PersonId == id && e.UserId == _userId);
                return
                    new PersonDetail
                    {
                        PersonId = entity.PersonId,
                        FirstName = entity.FirstName,
                        LastName =  entity.LastName,
                        HowKnown = entity.HowKnown,
                    };
            }
        }
    }
}

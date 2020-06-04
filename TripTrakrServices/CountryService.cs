using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripTrakrData;
using TripTrakrModels;

namespace TripTrakrServices
{
    public class CountryService
    {
        private readonly Guid _userId;

        public CountryService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCountry(CountryCreate model)
        {
            var entity =
                new Country()
                {
                    UserId = _userId,
                    CountryName = model.CountryName,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Countries.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CountryListItem> GetCountries()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Countries
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new CountryListItem
                                {
                                    CountryId = e.CountryId,
                                    CountryName = e.CountryName,
                                }
                        );

                return query.ToArray();
            }
        }

        public CountryDetail GetCountryById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Countries
                        .Single(e => e.CountryId == id && e.UserId == _userId);
                return
                    new CountryDetail
                    {
                        CountryId = entity.CountryId,
                        CountryName = entity.CountryName,
                    };
            }
        }
    }
}

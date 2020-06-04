﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripTrakrData;
using TripTrakrModels;

namespace TripTrakrServices
{
    public class TripService
    {
        private readonly Guid _userId;

        public TripService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateTrip(TripCreate model)
        {
            var entity =
                new Trip()
                {
                    UserId = _userId,
                    TripStartDate = model.TripStartDate,
                    TripEndDate = model.TripEndDate,
                    CountryId = model.CountryId,
                    PersonId = model.PersonId,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Trips.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TripListItem> GetTrips()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Trips
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new TripListItem
                                {
                                    TripId = e.TripId,
                                    TripStartDate = e.TripStartDate,
                                    CountryName =
e.Country.CountryName,
                                    FirstName = e.Person.FirstName,
                                }
                        ); ;

                return query.ToArray();
            }
        }
    }
}
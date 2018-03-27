using System.Collections.Generic;
using Lab5.Descriptors;
using Lab5.Models;
using Lab5.Repositories;

namespace Lab5
{
    public class DbService
    {
        private readonly IBaseRepository<Cabin> _cabins;
        private readonly IBaseRepository<Passenger> _passengers;

        public DbService(ApplicationContext context)
        {
            _cabins = new EfRepository<Cabin>(context);
            _passengers = new EfRepository<Passenger>(context);
        }

        public List<Cabin> GetCabins()
        {
            return _cabins.GetAll();
        }

        public List<Passenger> GetPassengers()
        {
            return _passengers.GetAll();
        }

        public void AddCabin(Cabin model)
        {
            _cabins.Add(model);
        }

        public void AddPassenger(Passenger model)
        {
            _passengers.Add(model);
        }

        public void UpdateCabin(Cabin model)
        {
            _cabins.Update(model);
        }

        public void UpdatePassenger(Passenger model)
        {
            _passengers.Update(model);
        }

        public void DeleteCabin(Cabin cabin)
        {
            _cabins.Delete(cabin);
        }

        public void DeletePassenger(Passenger passenger)
        {
            _passengers.Delete(passenger);
        }
    }
}

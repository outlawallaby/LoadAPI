using System.Collections.Generic;
using LoadAPI.Models;

namespace LoadAPI.Data
{
    public class MockLoadAPIRepo : ILoadAPIRepo
    {
        public void CreateLoad(Load load)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLoad(Load load)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Load> GetAllLoads()
        {
            var loads = new List<Load>
            {
                new Load{
                    Id=0, LoadNumber="T-114BZN2",Broker="Amazon",
                    PickUpAddress="Chino,CA",DeliveryAddress="Orlando,FL"
                },
                new Load{
                    Id=1, LoadNumber="T-115BZBB",Broker="Amazon",
                    PickUpAddress="Bloomington,CA",DeliveryAddress="Jacksonville,FL"
                },
                new Load{
                    Id=2, LoadNumber="671547",Broker="ITS",
                    PickUpAddress="Spokane,WA",DeliveryAddress="Los Angeles,CA"
                }};
                return loads;
        }
        public Load GetLoadById(int id)
        {
            return new Load{
                Id=0, LoadNumber="T-114BZN2",Broker="Amazon",
                PickUpAddress="Chino,CA",DeliveryAddress="Orlando,FL"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLoad(Load load)
        {
            throw new System.NotImplementedException();
        }
    }
}
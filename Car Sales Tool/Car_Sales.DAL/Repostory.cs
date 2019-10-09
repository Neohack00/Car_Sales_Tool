using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Car_Sales.Businesss;
	

namespace Car_Sales.DAL
{
    public class Repostory
    {
        List<Car> MyCars = new List<Car>();

        public void Save(Car NewCar)
        {

            
            
            MyCars.Add(NewCar);
            // - Sparar den nya bilen till databasen
        }
        public List<Car> GetList()
        {
            return MyCars;
            // -Hämtar allt som är lagrat och lagrar det i en list som returneras. 
        }
        public void Update(int id, string ChangeData)
        {
           // -Uppdaterar en specifik data i databasen med hjälp av Id och en specifik kolumn
        }

    }
}

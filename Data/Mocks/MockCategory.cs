using ShopTest.Data.Interfaces;
using ShopTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTest.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", description = "Современный вид транспорта"},
                    new Category {categoryName = "Классический автомобиль", description = "Машина с двигателем внутреннего сгорания"}
                };
            }
        }
            
    }
}

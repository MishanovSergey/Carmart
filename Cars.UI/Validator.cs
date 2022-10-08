using Cars.Domain.Models;
using System.Collections.Generic;

namespace Cars.UI
{
    internal class Validator
    {
        public static bool CheckBrandName(string brandName, List<Brand> brands)
        {
            foreach (var brand in brands)
            {
                if (brand.Name.ToLower() == brandName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS2.Lib
{
    public class Validation
    {
        public bool IsYearValid(int year)
        {
            try
            {
                return year >= 1500 && year <= DateTime.Now.Year;//
            }
            catch
            {
                throw;
            }
        }

        public bool IsFiltredYearValid(int? yearFrom, int? yearTill)
        {
            try
            {
                if (yearFrom.HasValue && yearTill.HasValue)
                {
                    return IsYearValid(yearFrom.Value) && IsYearValid(yearTill.Value) && yearFrom.Value <= yearTill.Value;
                }
                else if (yearFrom.HasValue)
                {
                    return IsYearValid(yearFrom.Value);
                }
                else if (yearTill.HasValue)
                {
                    return IsYearValid(yearTill.Value);
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}

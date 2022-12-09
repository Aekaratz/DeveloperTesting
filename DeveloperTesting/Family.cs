using DeveloperTesting.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTesting
{

    internal class Family
    {
        private static readonly FamilyLeeDBContext db = new FamilyLeeDBContext();


        public void OlderToYounger(string search)
        {
            var result = db.TablePeple.Select(a => new
            {
                a.PepleName,
                family = db.TablePeple.Where(s => s.BirthDay > a.BirthDay)
                        .OrderBy(o => o.BirthDay)
                        .Select(a => a.PepleName)
                        .ToList()
            })
            .FirstOrDefault(a => a.PepleName.Contains(search.Trim()));

            Console.WriteLine($"Result: {string.Join(",", result.family.ToArray())}");
        }

        public void YoungerToOlder(string search)
        {
            var result = db.TablePeple.Select(a => new
            {
                a.PepleName,
                family = db.TablePeple.Where(s =>s.BirthDay < a.BirthDay)
                        .OrderBy(o => o.BirthDay)
                        .Select(s => s.PepleName)
                        .ToList()
            })
            .FirstOrDefault(a => a.PepleName.Contains(search.Trim()));

            Console.WriteLine($"Result: {string.Join(",", result.family.ToArray())}");
        }

    }
}

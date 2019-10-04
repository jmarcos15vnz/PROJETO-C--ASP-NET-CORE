using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //DB Has Been Seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Joao", "Joao@gmail.com", new DateTime(1996, 9, 28), 1000.0, d1);
            Seller s2 = new Seller(2, "Marcos", "Marcos@gmail.com", new DateTime(1996, 9, 28), 1000.0, d2);
            Seller s3 = new Seller(3, "Almeida", "Almeida@gmail.com", new DateTime(1996, 9, 28), 1000.0, d1);
            Seller s4 = new Seller(4, "Correia", "Correia@gmail.com", new DateTime(1996, 9, 28), 1000.0, d4);
            Seller s5 = new Seller(5, "Pedro", "Pedro@gmail.com", new DateTime(1996, 9, 28), 1000.0, d3);
            Seller s6 = new Seller(6, "Mike", "Mike@gmail.com", new DateTime(1996, 9, 28), 1000.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 08, 25), 8000.0, SaleStatus.Pending, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 07, 25), 1000.0, SaleStatus.Cancelled, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 06, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 05, 25), 9000.0, SaleStatus.Cancelled, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 04, 25), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 03, 25), 2000.0, SaleStatus.Cancelled, s6);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 02, 25), 5000.0, SaleStatus.Pending, s3);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 01, 25), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 12, 25), 34000.0, SaleStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r4, r5, r6, r7, r8, r9, r10);

            _context.SaveChanges();
        }
    }
}

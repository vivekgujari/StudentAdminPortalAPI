using Microsoft.EntityFrameworkCore;
using StudentAdminPortalAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortalAPI.Repositories
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;
        public SQLStudentRepository(StudentAdminContext context)
        {
            this._context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Student.
                Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }


    }
}

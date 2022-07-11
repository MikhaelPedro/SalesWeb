﻿using System.Collections.Generic;
using System.Linq;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> Findall()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

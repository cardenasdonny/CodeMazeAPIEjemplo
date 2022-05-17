using CodeMaze.Contracts;
using CodeMaze.Entities;
using CodeMaze.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMaze.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository 
    { 
        public EmployeeRepository(RepositoryContext repositoryContext) : 
            base(repositoryContext) 
        { 
        } 
    }
}

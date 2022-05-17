﻿using CodeMaze.Contracts;
using CodeMaze.Entities;
using CodeMaze.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMaze.Repository
{
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository 
    { 
        public CompanyRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext) 
        { 
        } 
    }
}
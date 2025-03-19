﻿using DeveloperStore.API.Models;
using System.Collections.Generic;

namespace DeveloperStore.API.Services
{
    public interface IBranchService
    {
        IEnumerable<Branch> GetAllBranches();
        Branch GetBranchById(int id);
        Branch CreateBranch(Branch branch);
        Branch UpdateBranch(Branch branch);
        void DeleteBranch(int id);
    }
}


using DeveloperStore.API.Entities;
using DeveloperStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.API.Repositories.Interfaces
{
    public interface IBranchRepository
    {
        Task<Branch> GetBranchByIdAsync(int branchId);
        Task<IEnumerable<Branch>> GetAllBranchesAsync();
        Task<Branch> AddBranchAsync(Branch branch);
        Task<Branch> UpdateBranchAsync(Branch branch);
        Task<bool> DeleteBranchAsync(int branchId);
    }
}


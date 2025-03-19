using DeveloperStore.API.Models;
using DeveloperStore.API.Repositories;
using System.Collections.Generic;

namespace DeveloperStore.API.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;

        public BranchService(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public IEnumerable<Branch> GetAllBranches()
        {
            return _branchRepository.GetAllBranches();
        }

        public Branch GetBranchById(int id)
        {
            return _branchRepository.GetBranchById(id);
        }

        public Branch CreateBranch(Branch branch)
        {
            return _branchRepository.CreateBranch(branch);
        }

        public Branch UpdateBranch(Branch branch)
        {
            return _branchRepository.UpdateBranch(branch);
        }

        public void DeleteBranch(int id)
        {
            _branchRepository.DeleteBranch(id);
        }
    }
}

using DeveloperStore.API.Models;
using DeveloperStore.API.Repositories;
using DeveloperStore.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperStore.API.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository _branchRepository;

        public BranchService(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        // Get all branches, mapping from entity to DTO
        public IEnumerable<BranchModel> GetAllBranches()
        {
            return _branchRepository.GetAllBranches().Select(b => new BranchModel
            {
                BranchId = b.BranchId,
                Name = b.Name,
                Address = b.Address
            });
        }

        // Get a branch by ID, mapping from entity to DTO
        public BranchModel GetBranchById(int id)
        {
            var branch = _branchRepository.GetBranchById(id);
            if (branch == null) return null;

            return new BranchModel
            {
                BranchId = branch.BranchId,
                Name = branch.Name,
                Address = branch.Address
            };
        }

        // Create a new branch and return the created branch as a DTO
        public BranchModel CreateBranch(BranchModel branchModel)
        {
            var branchEntity = new Branch
            {
                Name = branchModel.Name,
                Address = branchModel.Address
            };

            var createdBranch = _branchRepository.CreateBranch(branchEntity);
            return new BranchModel
            {
                BranchId = createdBranch.BranchId,
                Name = createdBranch.Name,
                Address = createdBranch.Address
            };
        }

        // Update an existing branch and return the updated branch as a DTO
        public BranchModel UpdateBranch(BranchModel branchModel)
        {
            var branchEntity = _branchRepository.GetBranchById(branchModel.BranchId);
            if (branchEntity == null) return null;

            branchEntity.Name = branchModel.Name;
            branchEntity.Address = branchModel.Address;

            var updatedBranch = _branchRepository.UpdateBranch(branchEntity);
            return new BranchModel
            {
                BranchId = updatedBranch.BranchId,
                Name = updatedBranch.Name,
                Address = updatedBranch.Address
            };
        }

        // Delete a branch by its ID
        public void DeleteBranch(int id)
        {
            _branchRepository.DeleteBranch(id);
        }

        IEnumerable<Branch> IBranchService.GetAllBranches()
        {
            throw new NotImplementedException();
        }

        Branch IBranchService.GetBranchById(int id)
        {
            throw new NotImplementedException();
        }

        public Branch CreateBranch(Branch branch)
        {
            throw new NotImplementedException();
        }

        public Branch UpdateBranch(Branch branch)
        {
            throw new NotImplementedException();
        }

        object IBranchService.CreateBranch(Branch branch)
        {
            throw new NotImplementedException();
        }
    }
}

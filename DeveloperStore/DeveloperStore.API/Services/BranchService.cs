using DeveloperStore.API.Models;  // For BranchModel
using DeveloperStore.API.Repositories;
using DeveloperStore.Domain.Entities;  // For Branch entity
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

        // Convert Branch entity to BranchModel
        private BranchModel ConvertToBranchModel(Branch branch)
        {
            return new BranchModel
            {
                BranchId = branch.BranchId,
                Name = branch.Name,
                Address = branch.Address
            };
        }

        // Convert BranchModel to Branch entity
        private Branch ConvertToBranchEntity(BranchModel branchModel)
        {
            return new Branch
            {
                BranchId = branchModel.BranchId,
                Name = branchModel.Name,
                Address = branchModel.Address
            };
        }

        public IEnumerable<BranchModel> GetAllBranches()
        {
            var branches = _branchRepository.GetAllBranches();  // Assuming this returns List<Branch>
            var branchModels = new List<BranchModel>();

            foreach (var branch in branches)
            {
                branchModels.Add(ConvertToBranchModel(branch));  // Convert entity to DTO
            }

            return branchModels;
        }

        public BranchModel GetBranchById(int id)
        {
            var branch = _branchRepository.GetBranchById(id);
            return branch == null ? null : ConvertToBranchModel(branch);  // Convert entity to DTO
        }

        public BranchModel CreateBranch(BranchModel branchModel)
        {
            var branchEntity = ConvertToBranchEntity(branchModel);  // Convert DTO to entity
            var createdBranch = _branchRepository.CreateBranch(branchEntity);
            return ConvertToBranchModel(createdBranch);  // Convert entity to DTO
        }

        public BranchModel UpdateBranch(BranchModel branchModel)
        {
            var branchEntity = ConvertToBranchEntity(branchModel);  // Convert DTO to entity
            var updatedBranch = _branchRepository.UpdateBranch(branchEntity);
            return ConvertToBranchModel(updatedBranch);  // Convert entity to DTO
        }

        public void DeleteBranch(int id)
        {
            _branchRepository.DeleteBranch(id);
        }
    }
}

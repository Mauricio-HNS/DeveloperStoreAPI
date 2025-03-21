using DeveloperStore.Domain.Entities;

public interface IBranchRepository
{
    // Correct return type to match the entity type
    IEnumerable<Branch> GetAllBranches();
    Branch GetBranchById(int id);
    Branch CreateBranch(Branch branch);
    Branch UpdateBranch(Branch branch);
    void DeleteBranch(int id);
}

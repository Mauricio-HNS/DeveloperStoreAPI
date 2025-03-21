using DeveloperStore.API.Models;
using DeveloperStore.Domain.Entities;  // Usando a entidade de domínio
using DeveloperStore.API.Data;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperStore.API.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly DeveloperStoreDbContext _context;

        public BranchRepository(DeveloperStoreDbContext context)
        {
            _context = context;
        }

        // Implementa o método do repositório para retornar todas as filiais como entidades (Branch)
        public IEnumerable<Branch> GetAllBranches()
        {
            return _context.Branches.ToList(); // Retorna as entidades (não convertidas)
        }

        // Implementa o método do repositório para obter uma filial por ID
        public Branch GetBranchById(int id)
        {
            return _context.Branches.FirstOrDefault(b => b.BranchId == id); // Retorna a entidade Branch
        }

        // Método de criação de uma filial
        public Branch CreateBranch(Branch branch)
        {
            _context.Branches.Add(branch);
            _context.SaveChanges();
            return branch;
        }

        // Método de atualização de uma filial
        public Branch UpdateBranch(Branch branch)
        {
            _context.Branches.Update(branch);
            _context.SaveChanges();
            return branch;
        }

        // Método para excluir uma filial
        public void DeleteBranch(int id)
        {
            var branch = _context.Branches.Find(id);
            if (branch != null)
            {
                _context.Branches.Remove(branch);
                _context.SaveChanges();
            }
        }
    }
}

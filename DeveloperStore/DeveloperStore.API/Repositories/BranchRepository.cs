using DeveloperStore.API.Models;
using DeveloperStore.API.Data;
using System.Collections.Generic;
using System.Linq; // LINQ para ToList(), FirstOrDefault(), etc.

namespace DeveloperStore.API.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        private readonly DeveloperStoreDbContext _context;

        public BranchRepository(DeveloperStoreDbContext context)
        {
            _context = context;
        }

        // Método correto para obter todas as filiais
        public IEnumerable<Branch> GetAllBranches()
        {
            // Aqui, _context.Branches deve ser do tipo DbSet<Branch>
            return _context.Branches.ToList();  // ToList() funciona aqui
        }

        // Método correto para obter uma filial pelo ID
        public Branch GetBranchById(int id)
        {
            return _context.Branches.FirstOrDefault(b => b.BranchId == id);  // FirstOrDefault() funciona aqui
        }

        // Método para criar uma filial
        public Branch CreateBranch(Branch branch)
        {
            _context.Branches.Add(branch);  // Add() funciona aqui
            _context.SaveChanges();
            return branch;
        }

        // Método para atualizar uma filial
        public Branch UpdateBranch(Branch branch)
        {
            _context.Branches.Update(branch);
            _context.SaveChanges();
            return branch;
        }

        // Método para deletar uma filial
        public void DeleteBranch(int id)
        {
            var branch = _context.Branches.Find(id);
            if (branch != null)
            {
                _context.Branches.Remove(branch);  // Remove() funciona aqui
                _context.SaveChanges();
            }
        }
    }
}

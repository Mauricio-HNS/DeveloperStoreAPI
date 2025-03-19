using Microsoft.AspNetCore.Mvc;
using DeveloperStore.API.Models;
using DeveloperStore.API.Services;
using System.Collections.Generic;

namespace DeveloperStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Branch>> GetAllBranches()
        {
            return Ok(_branchService.GetAllBranches());
        }

        [HttpGet("{id}")]
        public ActionResult<Branch> GetBranchById(int id)
        {
            var branch = _branchService.GetBranchById(id);
            if (branch == null)
            {
                return NotFound();
            }
            return Ok(branch);
        }

        [HttpPost]
        public ActionResult<Branch> CreateBranch(Branch branch)
        {
            var createdBranch = _branchService.CreateBranch(branch);
            return CreatedAtAction(nameof(GetBranchById), new { id = createdBranch.BranchId }, createdBranch);
        }

        [HttpPut("{id}")]
        public ActionResult<Branch> UpdateBranch(int id, Branch branch)
        {
            if (id != branch.BranchId)
            {
                return BadRequest();
            }

            var updatedBranch = _branchService.UpdateBranch(branch);
            return Ok(updatedBranch);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBranch(int id)
        {
            _branchService.DeleteBranch(id);
            return NoContent();
        }
    }
}

using BlazorCRUDThreeTiered.Business.DTOs;
using BlazorCRUDThreeTiered.Business.Entities;

namespace BlazorCRUDThreeTiered.DataAccess.Repositories
{
    public interface IDepartment
    {
        Task<ServiceResponse> AddAsync(Department department);
        Task<ServiceResponse> UpdateAsync(Department department);
        Task<ServiceResponse> DeleteAsync(int id);
        Task<List<Department>> GetAsync();
        Task<Department?> GetByIdAsync(int id);
    }
}

namespace CreateTest.Api.Repositories;

public interface IRepository<T>
{
    public Task<List<T>> GetAllAsync();
    public Task SaveAllAsync(List<T> items);  
}
using DomainModel;



namespace Repository
{
    public interface IDbRepos 
    {
        IRepository<Order> Orders { get; }
        IRepository<Executor> Executors { get; }
        IRepository<Client> Clients { get; }
        IRepository<Type_of_service> TServices { get; }
        IReportsRepository Reports { get; }
        int Save();
    }
}

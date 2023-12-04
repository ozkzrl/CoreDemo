using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntitiyFramework
{
	public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
	{
	}
}

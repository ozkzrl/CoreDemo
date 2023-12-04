using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntitiyFramework
{
	public class EfAboutRepository : GenericRepository<About>, IAboutDal
	{
	}
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntitiyFramework
{
	public class EfContactRepository : GenericRepository<Contact>, IContactDal
	{
	}
}

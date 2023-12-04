using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
	public interface ICommentService
	{
		void CommentAdd(Comment comment);

		//void CategoryDelete(Category category);

		//void CategoryUpdate(Category category);

		List<Comment> GetList();
		//Category GetById(int id);

	}
}

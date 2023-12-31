﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}


		public List<Blog> GetBlogWithCategory()
		{
			return _blogDal.GetListWithCategory();
		}

		public List<Blog> GetListCategoryByWriterbm(int id)
		{
			return _blogDal.GetListWithCategoryByWriter(id);

		}
		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x => x.BlogID == id);
		}
		public List<Blog>GetLast3Blog()
		{
			return _blogDal.GetListAll().Take(3).ToList();
				
		}


		public Blog TGetById(int id)
		{
			return _blogDal.GetById(id);
		}

		public List<Blog> GetList()
		{
			return _blogDal.GetListAll();
		}

		public List<Blog> GetBlogByWriter(int id)
		{
			return _blogDal.GetListAll(x => x.WriterID == id);
		}

        public void TAdd(Blog t)
        {
			_blogDal.Insert(t);        }

        public void TDelete(Blog t)
        {
			_blogDal.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }

		


    }
}


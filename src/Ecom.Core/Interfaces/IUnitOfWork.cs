﻿using System;
namespace Ecom.Core.Interfaces
{
	public interface IUnitOfWork
	{
        public ICategoryRepository CategoryRepository { get; }
        public IProductRepository ProductRepository   { get; }
	}
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Core.Models;

namespace Data.Core.Repository
{
    public interface IRepository
    {
        Customer GetCustomer(int id);
        List<Package> GetPackages();
        List<Product> GetProducts();
        List<Supplier> GetSuppliers();
    }
}
﻿using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public class IBrandService
    {
        List<Brand> GetAll();
        Brand GetByBrandId(int brandId);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);

    }
}

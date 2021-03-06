﻿using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public class IColorService
    {
        List<Color> GetAll();
        Color GetByColorId(int colorId);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}

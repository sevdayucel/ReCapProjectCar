﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public class IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        List<Color> GetAll();
        Color GetById(int id);
    }
}

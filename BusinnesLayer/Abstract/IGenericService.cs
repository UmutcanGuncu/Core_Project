﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetListAll();
        T TGetById(int id);
    }
}

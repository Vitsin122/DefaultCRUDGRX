using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultCRUDGRX.BL.Interfaces
{
    public interface IMap<T,TDTO>
    {
        TDTO Down(T model);
        T Up(TDTO modelDTO);
    }
}

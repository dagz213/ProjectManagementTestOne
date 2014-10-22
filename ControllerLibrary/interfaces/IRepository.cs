using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.interfaces
{
    public interface IRepository <T, TKey>
    {
        void addItem(T newItem);
    }
}

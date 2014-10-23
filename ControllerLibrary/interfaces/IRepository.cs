using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerLibrary.interfaces
{
    public interface IRepository<T, Tkey>
    {

        List<T> getAllItems();
        void addItem(T newItem);

        //void deleteItem(Tkey key);
        //void updateItem(Tkey key, T updatedItem);
    }
}

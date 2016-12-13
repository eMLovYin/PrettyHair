using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class ItemRepository
    {
        private List<Ware> listOfWares = new List<Ware>();

        public ItemRepository()
        {
            listOfWares.Add(new Ware(0, 3, 10, "somewhere", true));
            listOfWares.Add(new Ware(1, 1, 3, "somewhere", true));
            listOfWares.Add(new Ware(2, 5, 2, "somewhere", true));
            listOfWares.Add(new Ware(3, 0, 0, "somewhere", true));
            listOfWares.Add(new Ware(4, 1, 5, "somewhere", true));
        }

        public void DeleteWareById(int Delete)
        {
            listOfWares.RemoveAt(Delete);
        }

        public void DeleteUnsellableWare()
        {
            listOfWares.RemoveAll(item => item.Unsellable == true);
        }

        public void AddWare()
        {
            listOfWares.Add(new Ware("somewhere", true));
        }

        public List<Ware> GetWare()
        {
            return listOfWares;
        }

        public Ware GetWareById(int id)
        {
            return new Ware();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using librosc.Entities;

namespace Librosc.Repositories
{
    public class InMemItemRepository{
        private
         readonly List<Item> items = new (){
             new Item{ Id =  Guid.NewGuid(),Name = "Primer  Item ",Price =19,
             CreatedDate =System.DateTimeOffset.UtcNow
             },
              new Item{ Id =  Guid.NewGuid(),Name = "segundo Item ",Price =29,
             CreatedDate =System.DateTimeOffset.UtcNow
             },
              new Item{ Id =  Guid.NewGuid(),Name = "Tercer Item ",Price =9,
             CreatedDate =System.DateTimeOffset.UtcNow
             },
            
        };
        public IEnumerable<Item> GetItems()
        {
            return items;

        }

        public Item GetItem(Guid id)
        {
            // si le encuentra lo devuelve y si no le encuentra devuelve nulo 
              return  items.Where(item => item.Id ==id).SingleOrDefault();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Librosc.Repositories;
using System.Collections.Generic;
using librosc.Entities;
using System;

namespace Librosc.Controllers
{

    //Get /item
    [ApiController]
    [Route("items")]
    public class ItemController :ControllerBase
    {
private readonly InMemItemRepository repository;
        public ItemController (){
            repository = new InMemItemRepository();
        }
        // Get / items

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
                var items= repository.GetItems();
                return items;
        }
        [HttpHead("{id}")]


            //Get /items/id
         public ActionResult< Item > GetItem(Guid id)
        {
                var item= repository.GetItem(id);
                if( item is null){
                    return NotFound();
                }
                     return item;
        }

    }

   
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ShoppingListAPI.Services;
using ShoppingListAPI.Models;
using ShoppingListAPI.Controller;

namespace ShoppingListAPI.Controller
{
    [Route("api/grocery")]
    [ApiController]

    
    public class GroceryController : ControllerBase
    {
        //GET - all, one review
        //PUT - update a review
        //POST - create a review
        //DELETE - to delete a review

        private IDataAccessLayer<Item> dal;

        public GroceryController(IDataAccessLayer<Item> dal)
        {
            this.dal = dal;
        }

        [HttpGet]
        public List<Item> GetAll()
        {
            return dal.GetAll();
        }

        [HttpGet("{id}", Name = "GetItem")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = dal.Get(id);
            if (item != null) //if we found it
            {
                return item; //return the review
            }

            //we get this from our parent
            return NotFound();
        }

        [HttpPost]
        public ActionResult Create([FromBody] Item item)
        {
            
            dal.Add(item);

            //using parent's created at route and passing in: 1. The name of the action the client uses to get the resource
            //2. the input parameter needed to get the resource 3. the new object that was created
            //throw new Exception();
            return CreatedAtRoute("GetItem", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, GroceryController item)
        {
            //get the existing review
            var existingItem = dal.Get(id);

            //if it doesn't exist, return 404
            if (existingItem == null)
            {
                return NotFound();
            }

            //change the fields we want to change
            existingItem.name = existingItem.name;
            existingItem.completed = existingItem.completed;
            


            //save it back to the dal
            dal.Update(existingItem);

            //return a 204 on success
            return NoContent();
        }
        [HttpDelete("{item}")]
        public ActionResult Delete(int item)
        {
            var groceryItem = dal.Get(item);
            if (groceryItem == null)
            {
                return NotFound();
            }
            dal.Delete(item);
            return NoContent();
        }



    }
}
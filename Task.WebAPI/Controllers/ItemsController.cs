using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.BLL;

namespace Task.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        Services itemServices = new Services();
        // GET: api/Items
        [HttpGet]
        public IEnumerable<ItemModel> Get()
        {
            try
            {
                return itemServices.GetAllItems();
            }
            catch (Exception ex)
            {     
                throw ex;
            }
            
        }
        

        // POST: api/Items
        [HttpPost]
        public void Post([FromBody] ItemModel model)
        {
            try
            {
                itemServices.AddToDB(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT: api/Items/5
        [HttpPut]
        public void Put([FromBody] ItemModel model)
        {
            try
            {
                itemServices.UpdateItem(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                itemServices.RemoveItem(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

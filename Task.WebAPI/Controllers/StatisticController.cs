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
    public class StatisticController : ControllerBase
    {
        Services itemServices = new Services();

        /// <summary>
        /// return list of statistic objects 
        /// objects contain Type ItemName and Item count
        /// </summary>
        /// <returns></returns>
        /// 
        // GET: api/Statistic
        [HttpGet]
        public IEnumerable<ItemStatistic> GetStatistic()
        {
            try
            {
                return itemServices.GetStatisticItemsType();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}

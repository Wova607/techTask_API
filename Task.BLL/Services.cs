using System;
using System.Collections.Generic;
using System.Linq;
using Task.DAL.Entities;
using Task.DAL.Repository;

namespace Task.BLL
{
    /// <summary>
    ///Service for basic work with items
    /// </summary>
    public class Services
    {
        //object of repository
        private readonly Repository repository = new Repository();
        
        
        /// <summary>
        /// Service method for add new entity to DB
        /// </summary>
        /// <param name="model"></param>
        public bool AddToDB(ItemModel model)
        {
           

            if (model.ItemName.Length == 0 || model.ItemType.Length == 0)
            {
                return false;
            }
            else
            {
                try
                {
                    repository.Add(SimpleMapper.MapToEntity(model));
                    
                }
                catch (Exception ex)
                {
                    throw ex;
                   
                }
                return true;
            }
        }
       /// <summary>
       /// Method for return list of items
       /// </summary>
       /// <returns> List of Items </returns>
        public IEnumerable<ItemModel> GetAllItems()
        {
            List<ItemModel> resalt = new List<ItemModel>();
            try
            {
                IEnumerable<Item> items = repository.GetAll();
                foreach (var item in items)
                {
                    resalt.Add(SimpleMapper.MapToModel(item));
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }           

            return resalt;
        }
        /// <summary>
        /// Method for remove entity from db
        /// </summary>
        /// <param name="model"></param>
        public void RemoveItem(int id)
        {
            
            try
            {
                repository.Remove(id);               
            }
            catch (Exception ex)
            {               
                throw ex;               
            }
            
        }
        /// <summary>
        /// Method for edit item
        /// </summary>
        /// <param name="model"></param>
        public void UpdateItem(ItemModel model)
        {
            try
            {
                repository.Update(SimpleMapper.MapToEntity(model));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public IEnumerable<ItemStatistic> GetStatisticItemsType()
        {
            //get a list of unique Item Types        

            List<string> fulltypeslist = new List<string>();

            IEnumerable<ItemModel> listItems = GetAllItems();
            foreach (var item in listItems)
            {
                fulltypeslist.Add(item.ItemType.ToLower());
            }
            //List of unique Item Types  
            List<string> uniqtypeslist = fulltypeslist.Distinct().ToList();
                       
            //statistic list
            List<ItemStatistic> result = new List<ItemStatistic>();

            int count;
            foreach (var unq in uniqtypeslist)
            {
                count = 0;
                foreach (var tp in fulltypeslist)
                {
                    if (unq==tp)
                    {
                        count++;
                    }
                }
                result.Add(new ItemStatistic() { ItemType = unq, Count = count });

            }

            return result;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Task.DAL.Entities;

namespace Task.BLL
{
    /// <summary>
    /// Static Class fo map entity to model and model to entity
    /// </summary>
   public static  class SimpleMapper
    {
        /// <summary>
        /// static method for mapping model to entity
        /// </summary>
        /// <param name="model">model object for mapping</param>
        /// <returns>return new entity</returns>
        public static Item MapToEntity(ItemModel model)
        {
            return new Item()
            {
                Id = model.Id,
                ItemName = model.ItemName,
                ItemType = model.ItemType
            };
        
        }
        /// <summary>
        /// static method for mapping entity to model
        /// </summary>
        /// <param name="entity">entity for mapping</param>
        /// <returns> return new model object</returns>
        public static ItemModel MapToModel(Item entity)
        {
            return new ItemModel()
            {
                Id = entity.Id,
                ItemName = entity.ItemName,
                ItemType = entity.ItemType
            };

        }

    }
}

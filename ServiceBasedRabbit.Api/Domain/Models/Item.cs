using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceBasedRabbit.Api.Domain.Models
{
    public class Item
    {
        //private int _ItemId;

        //public int ItemId 
        //{
        //    get { return _ItemId; }
        //    set { _ItemId = value; }
        //}

        public int ItemId { get; set; }
        public string Description { get; set; }
        
        //public ICollection<User> Users { get; set; }



    }
}

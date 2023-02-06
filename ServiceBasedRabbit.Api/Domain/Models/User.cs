using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceBasedRabbit.Api.Domain.Models
{
    public class User
    {
        //private int _UserId;

        //public int UserId
        //{
        //    get { return _UserId; }
        //    set { _UserId = value; }
        //}

        public int UserId { get; set; }
        //public Item Item { get; set; }
        public string UserName { get; set; }

        public ICollection<Item> Items { get; set; }




    }
}

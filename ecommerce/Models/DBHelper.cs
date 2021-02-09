using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.Models
{
    public class DBHelper
    {
        public static int GetState(string descripcion, EcommerceContext db)
        {

            var state = db.States.Where(s => s.Description == descripcion).FirstOrDefault();
            if (state == null)
            {
                state = new State { Description = descripcion, };
                db.States.Add(state);
                db.SaveChanges();
            }
            return state.StateId;
        }
    }
}
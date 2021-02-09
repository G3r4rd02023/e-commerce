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

        public static Response SaveChanges(EcommerceContext db)
        {
            try
            {
                db.SaveChanges();
                return new Response { Succedeed = true, };
            }
            catch (Exception ex)
            {
                var response = new Response { Succedeed = false, };
                if (ex.InnerException != null &&
                    ex.InnerException.InnerException != null &&
                    ex.InnerException.InnerException.Message.Contains("_Index"))
                {
                    response.Message = "There is a record with the same value";
                }
                else if (ex.InnerException != null &&
                    ex.InnerException.InnerException != null &&
                    ex.InnerException.InnerException.Message.Contains("REFERENCE"))
                {
                    response.Message = "The record can't be delete because it has related records";
                }
                else
                {
                    response.Message = ex.Message;
                }

                return response;
            }
        }

    }
}
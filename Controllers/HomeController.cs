using SimpleWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleWebAPI.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()//List<Person>
        {
            try
            {
                //Create Error for test api
                int x = 0, y = 1;
                int z = y / x;

                List<Person> list = new List<Person>();
                list.Add(new Person() { Id = 1, FirstName = "Venkat", LastName = "Kurivi", Description = "" });
                list.Add(new Person() { Id = 2, FirstName = "Hanish", LastName = "Maram", Description = "" });
                list.Add(new Person() { Id = 3, FirstName = "Praveen", LastName = "Acha", Description = "" });
                list.Add(new Person() { Id = 4, FirstName = "Kalyan", LastName = "Goru", Description = "" });
                list.Add(new Person() { Id = 5, FirstName = "Azeem", LastName = "Abdul", Description = "" });
                list.Add(new Person() { Id = 6, FirstName = "Manideep", LastName = "Manda", Description = "" });
                return Ok(list);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}

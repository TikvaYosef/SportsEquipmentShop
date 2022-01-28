using SportsEquipmentShop.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SportsEquipmentShop.Controllers.API
{
    public class ManagerShoesController : ApiController
    {
        ShoesDataContext datacontext = new ShoesDataContext();

        // GET: api/ManagerShoes
        public IHttpActionResult Get()
        {
            try
            {
                List<Shoe> ListOfShoes = datacontext.Shoes.ToList();
                return Ok(new { ListOfShoes });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/ManagerShoes/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Shoe Shoe = datacontext.Shoes.First((item) => item.Id == id);
                return Ok(new { Shoe });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/ManagerShoes
        public IHttpActionResult Post([FromBody] Shoe ShoeObj)
        {
            try
            {
                datacontext.Shoes.InsertOnSubmit(ShoeObj);
                datacontext.SubmitChanges();

                return Ok("Successfully Added");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/ManagerShoes/5
        public IHttpActionResult Put(int id, [FromBody] Shoe ShoeObj)
        {
            try
            {
                Shoe Shoe = datacontext.Shoes.First((item) => item.Id == id);
                Shoe.ShoeType = ShoeObj.ShoeType;
                Shoe.Company = ShoeObj.Company;
                Shoe.Model = ShoeObj.Model;
                Shoe.price = ShoeObj.price;
                Shoe.Amount = ShoeObj.Amount;
                Shoe.image = ShoeObj.image;

                datacontext.SubmitChanges();
                return Ok("Successfully Update");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // DELETE: api/ManagerShoes/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Shoe Shoe = datacontext.Shoes.First((item) => item.Id == id);
                datacontext.Shoes.DeleteOnSubmit(Shoe);
                datacontext.SubmitChanges();

                return Ok("Successfully Deleted");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

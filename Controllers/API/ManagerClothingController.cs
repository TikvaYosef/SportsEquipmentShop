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
    public class ManagerClothingController : ApiController
    {
        ShoesDataContext datacontext = new ShoesDataContext();

        // GET: api/ManagerShoes
        public IHttpActionResult Get()
        {
            try
            {
                List<Clothing> ListOfClothing = datacontext.Clothings.ToList();
                return Ok(new { ListOfClothing });
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
                Clothing Clothing = datacontext.Clothings.First((item) => item.Id == id);
                return Ok(new { Clothing });
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
        public IHttpActionResult Post([FromBody] Clothing ClothingObj)
        {
            try
            {
                datacontext.Clothings.InsertOnSubmit(ClothingObj);
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
        public IHttpActionResult Put(int id, [FromBody] Clothing ClothingObj)
        {
            try
            {
                Clothing Clothing = datacontext.Clothings.First((item) => item.Id == id);
                Clothing.TypeOfClothes = ClothingObj.TypeOfClothes;
                Clothing.gender = ClothingObj.gender;
                Clothing.company = ClothingObj.company;
                Clothing.model = ClothingObj.model;
                Clothing.price = ClothingObj.price;
                Clothing.amount = ClothingObj.amount;
                Clothing.t_shirt_ = ClothingObj.t_shirt_;
                Clothing.DryFit_ = ClothingObj.DryFit_;
                Clothing.image = ClothingObj.image;

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
                Clothing Clothing = datacontext.Clothings.First((item) => item.Id == id);
                datacontext.Clothings.DeleteOnSubmit(Clothing);
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

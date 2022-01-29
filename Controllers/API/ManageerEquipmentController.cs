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
    public class SportsEquipmentShop : ApiController
    {

        ShoesDataContext datacontext = new ShoesDataContext();

        // GET: api/ManagerShoes
        public IHttpActionResult Get()
        {
            try
            {
                List<SportsEquipment> ListOSportsEquipmentShop = datacontext.SportsEquipments.ToList();
                return Ok(new { ListOSportsEquipmentShop });
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
                SportsEquipment EquipmentShop = datacontext.SportsEquipments.First((item) => item.Id == id);
                return Ok(new { EquipmentShop });
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
        public IHttpActionResult Post([FromBody] SportsEquipment EquipmentShopObj)
        {
            try
            {
                datacontext.SportsEquipments.InsertOnSubmit(EquipmentShopObj);
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
        public IHttpActionResult Put(int id, [FromBody] SportsEquipment EquipmentShopObj)
        {
            try
            {
                SportsEquipment Equipment = datacontext.SportsEquipments.First((item) => item.Id == id);
                EquipmentShopObj.sport = Equipment.sport;
                EquipmentShopObj.ProductName = Equipment.ProductName;
                EquipmentShopObj.company = Equipment.company;
                EquipmentShopObj.price = Equipment.price;
                EquipmentShopObj.amount = Equipment.amount;
                EquipmentShopObj.TeamId = Equipment.TeamId;
                EquipmentShopObj.image = Equipment.image;

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
                SportsEquipment Equipment = datacontext.SportsEquipments.First((item) => item.Id == id);
                datacontext.SportsEquipments.DeleteOnSubmit(Equipment);
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

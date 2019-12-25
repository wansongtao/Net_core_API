using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using OracleDapperApi.Models;

namespace OracleDapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        #region 读取appsettings中的数据库连接字符串
        private readonly string _connectionString;

        public EmployeeController(IConfiguration configuration)
        {
            _connectionString = configuration.GetSection("ConnectionStrings")["MyConnectionString"];
        }
        #endregion

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string sql = "select * from Employee";

            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                var tableone = conn.Query<Employee>(sql).ToList();

                return Json(tableone);
            }
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            #region dapper查询语句
            string sql = "select ID, EmployeeName, EmployeeSex, DateOfBirth from Employee where ID = :ID";

            using (OracleConnection conn = new OracleConnection(_connectionString))
            {
                var tableone = conn.Query<Employee>(sql, new { ID = id }).ToList();

                return Json(tableone);
            }
            #endregion
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
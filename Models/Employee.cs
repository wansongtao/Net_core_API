using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OracleDapperApi.Models
{
    public class Employee
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string EmployeeSex { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int EmployeeAge { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public int EmployeePhone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string EmployeeAdress { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}

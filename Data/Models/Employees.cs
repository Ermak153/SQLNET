using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLNET.Data.Models
{
    class Employees
    {
        public int Сотрудник_ID { get; set; }
        public int Оценка_ID { get; set; }
        public string ФИО { get; set; }
        public decimal Зарплата { get; set; }
        public float Рейтинг { get; set; }
        public string Email { get; set; }

        // Внешний ключ
        public Rating Оценка { get; set; }
    }
}

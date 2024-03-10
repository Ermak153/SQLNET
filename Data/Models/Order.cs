using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLNET.Data.Models
{
    class Order
    {
        public int Заказ_ID { get; set; }
        public int Клиент_ID { get; set; }
        public int Оценка_ID { get; set; }
        public DateTime Дата_заказа { get; set; }

        // Внешние ключи
        public Clients Клиент { get; set; }
        public Rating Оценка { get; set; }
    }
}

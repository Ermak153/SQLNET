using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLNET.Data.Models
{
    class Elements_order
    {
        public int Элемент_заказа_ID { get; set; }
        public int Заказ_ID { get; set; }
        public int Товар_ID { get; set; }
        public int Количество { get; set; }

        // Внешние ключи
        public Order Заказ { get; set; }
        public Products Товар { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLNET.Data.Models
{
    class Products
    {
        public int Товар_ID { get; set; }
        public int Поставщик_ID { get; set; }
        public int Категория_ID { get; set; }
        public int Количество { get; set; }
        public decimal Цена { get; set; }
        public float Рейтинг { get; set; }

        // Внешние ключи
        public Suppliers Поставщик { get; set; }
        public Categories Категория { get; set; }
    }
}

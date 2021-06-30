using ETicaret.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsContinued { get; set; }
        public int StarPoint { get; set; }
        public int StarGivenMemberCount { get; set; }
        public string ProductImageName { get; set; }
        public int UnitsInStock { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
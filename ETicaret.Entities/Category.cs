using ETicaret.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public int? Parent_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
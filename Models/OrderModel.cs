using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage ="The name can only be 20 characters max")]
        [MinLength(3, ErrorMessage ="The name must be 3 characters minimum")]
        [DisplayName("Order Name")]
        public string OrderName { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;

        [DisplayName("Meal")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a meal from the list")]
        public int FoodId { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "You can select 10 meals maximum")]
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}

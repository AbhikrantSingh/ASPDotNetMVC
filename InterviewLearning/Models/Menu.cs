using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace InterviewLearning.Models
{
    public class Menu
    {
        public Guid Id { get; set; }
        public string DishName { get; set; }
        public double DishPrice { get; set; }
        public bool IsAvailable { get; set; }
        public Restaunt Restaunt { get; set; }
    }
}
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        //private readonly List<CheeseCategory> categories;
        
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public AddCheeseViewModel()
        {
        }

        public AddCheeseViewModel(List<CheeseCategory> categories) {
            //this.Categories = categories;
            //CheeseTypes = new List<SelectListItem>();
            // <option value="0">Hard</option>

            Categories = new List<SelectListItem>();

            foreach (CheeseCategory category in categories)
            {
                Categories.Add(new SelectListItem()
                {
                    Value = category.ID.ToString(),
                    Text = category.Name
                });
            }
         }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.ViewModel.User
{
    public class CreateUserViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Contact")]
        public string Contact { get; set; }
        [Required]
        [Display(Name = "User Type")]
        public string UserType { get; set; }

        public HashSet<SelectListItem> listItems = new HashSet<SelectListItem>()
        {
             new SelectListItem
             {
                  Text="User",
                   Value="User",
                    Selected=true
             },
             new SelectListItem
             {
                  Text="Agent",
                   Value="Agent",
             },
             new SelectListItem
             {
                  Text="Admin",
                   Value="Admin",
             }
             ,
             new SelectListItem
             {
                  Text="Super Admin",
                   Value="Super Admin",
             }
        };


    }
}

using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Client
{
    public class ClientIndexVM
    {
        public string Id { get; set; }
        [Display(Name ="Username")]
            public string UserName { get; set; }
        [Display(Name ="First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public bool isAdmin { get; set; }
    }
}

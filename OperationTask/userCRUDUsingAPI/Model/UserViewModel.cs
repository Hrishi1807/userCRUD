using System.ComponentModel;

namespace userCRUDUsingAPI.Model
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Birth Date")]
        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }
    }
}

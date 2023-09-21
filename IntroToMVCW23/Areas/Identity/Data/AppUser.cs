using Microsoft.AspNetCore.Identity;

namespace IntroToMVCW23.Areas.Identity.Data
{
    public class AppUser: IdentityUser
    {
        public int FavouriteNumber {  get; set; }
    }
}

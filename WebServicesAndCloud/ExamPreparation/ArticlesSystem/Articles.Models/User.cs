using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Articles.Models
{
    public class User : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }
    //public class User
    //{
    //    private ICollection<Article> articles;
    //    private ICollection<Comment> comments;

    //    public User()
    //    {
    //        this.articles = new HashSet<Article>();
    //        this.comments = new HashSet<Comment>();
    //    }
    //    public int Id { get; set; }

    //    public string Email { get; set; }

    //    public virtual ICollection<Article> Articles
    //    {
    //        get { return this.articles; }

    //        set { this.articles = value; }
    //    }

    //    public virtual ICollection<Comment> Comments
    //    {
    //        get { return this.comments; }

    //        set { this.comments = value; }
    //    }
    //}
}

using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace beltReview.Models
{ 

    public class Like 
    {
        [Key]
        public int LikeId {get;set;}

        public int UserId {get;set;}
        public int PostId {get;set;}
        public User User {get;set;}
        public Post Post {get;set;}
    }
}
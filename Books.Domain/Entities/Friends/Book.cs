using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Domain.Entities.Friends;

namespace Books.Domain.Entities.Friends
{
    public class Book : BaseEntity
    {
        public Guid AuthorId { get; set; }
        public Author? Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public string CoverImage { get; set; }
        public int PublicatonYear { get; set; }
        public Boolean IsHardcover { get; set; }
        public double Rating { get; set; }
        public Genre Genre { get; set; }
        public Guid PublisherId { get; set; }
        public Publisher? Publisher { get; set; }
    }
}

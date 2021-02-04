using System;
using System.ComponentModel.DataAnnotations;

namespace moment2.Models
{
    public class PostModel
    {
        // Properties
        [Required(ErrorMessage = "*")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        public string Message { get; set; }

        public PostModel()
        {
        }
    }
}
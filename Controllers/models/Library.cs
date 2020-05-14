using System;
using System.ComponentModel.DataAnnotations;

namespace library
{

  public class Library
  {
    [Required]
    [MinLength(5)]
    public string Title { get; set; }
    [Required]
    [MaxLength(140)]
    public string Description { get; set; }
    [Required]
    [Range(1, 1000)]
    public decimal Price { get; set; }
    public string Id { get; private set; }

    public Library()
    {
      Id = Guid.NewGuid().ToString();
    }

    public Library(string title, string description, decimal price)
    {
      Title = title;
      Description = description;
      Price = price;
      Id = Guid.NewGuid().ToString();
    }
  }
}
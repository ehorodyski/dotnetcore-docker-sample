using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_example.Models
{
  public class Blog
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
  }
}
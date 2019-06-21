using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_example.Models;

namespace dotnet_example.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BlogController : ControllerBase
  {
    private readonly ApiDbContext _context;

    public BlogController(ApiDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public object Get()
    {
      return _context.Blogs
      .Where(b => b.Title.Contains("Title"))
      .Select((c) => new
      {
        Id = c.Id,
        Title = c.Title,
        Description = c.Description
      }).ToList();
    }

    [HttpGet("{title}")]
    public object GetByTitle(string title)
    {
      return _context.Blogs
      .Where(b => b.Title == title)
      .Select((c) => new
      {
        Id = c.Id,
        Title = c.Title,
        Descrtiption = c.Description
      }).ToList();
    }

  }
}
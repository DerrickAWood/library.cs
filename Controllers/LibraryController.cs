using System;
using System.Collections.Generic;
using library.DB;
using Microsoft.AspNetCore.Mvc;

namespace library 
{
  [ApiController]
  [Route("api/[controller]")]
    public class LibraryController : ControllerBase
    {
      [HttpGet]
      public ActionResult<IEnumerable<Library>> GetAll()
      {
        try
        {
            return Ok(FakeDB.Library);
        }
        catch (Exception err)
        {
            return BadRequest(err.Message);
        }
      }
      [HttpGet("{libraryId}")]
      public ActionResult<Library> GetOne(string libraryId)
      {
        try
        {
            Library foundLibrary = FakeDB.Library.Find(library => library.Id == libraryId);
            if(foundLibrary == null)
            {
              throw new Exception("invalid id");
            }
            return Ok(foundLibrary);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
      }

      [HttpPost]
      public ActionResult<Library> Create([FromBody] Library newLibrary)
      {
        try
        {
        FakeDB.Library.Add(newLibrary);
        return Created($"api/api/library/{newLibrary.Id}", newLibrary);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
      }

      [HttpPut("{id")]
      public ActionResult<Library> Edit(string id, [FromBody] Library updateLibrary)
      {
        try
        {
            Library libraryToUpdate = FakeDB.Library.Find(b => b.Id == id);
            if(libraryToUpdate == null)
            {
              throw new Exception("invalid id");
            }
            libraryToUpdate.Title = updatedLibrary.Title == null ? libraryToUpdate.Title : updatedLibrary.title;
            libraryToUpdate.Description = updatedLibrary.Description;
            libraryToUpdate.Price = updatedLibrary.Price;
            return Ok(libraryToUpdate);
        }
        catch (System.Exception err)
        {
            return BadRequest(err.Message);
        }
      }
    }
}
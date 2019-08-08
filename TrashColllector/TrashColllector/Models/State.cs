using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TrashColllector.Models;

public class State
{
    [Required]
    public string Name { get; set; }
    public int Id { get; set; }

    [Required]
   public string AbbreviationShort { get; set; }


    public static State AddState(ApplicationDbContext _context, State state)
    {
        var newState = new State()
        {
            Name = state.Name,
            AbbreviationShort = state.Name
        };

        _context.states.Add(newState);
        _context.SaveChanges();

        return newState;
    }

    public static string GetStateNameById(ApplicationDbContext _conext, int id)
    {
        return _conext.states.Single(s => s.Id == id).Name;
    }

    public static IEnumerable<State> GetStates(ApplicationDbContext _context)
    {
        return _context.states.ToList();
    }

    public static int GetStateId(ApplicationDbContext _context, State state)
    {
        var result = _context.states
            .Where(s => s.Name == state.Name)
            .SingleOrDefault();

        return result == null ? 0 : result.Id;
    }
}



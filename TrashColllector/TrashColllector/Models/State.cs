using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TrashColllector.Models;

public class State
{
    [Required]
    public int Id { get; set; }
    [Required]
    public string AbbreviationShort { get; set; }
    public string Name { get; set; }

    internal static IEnumerable<State> GetStates(ApplicationDbContext context)
    {
        throw new NotImplementedException();
    }
}

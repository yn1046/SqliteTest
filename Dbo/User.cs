using System;

namespace Dbo
{
    public class User
    {
       public Guid Id { get; set; }
       public string Name { get; set; }
       public bool IsAdmin { get; set; }
       public string Bio { get; set; }
    }
}
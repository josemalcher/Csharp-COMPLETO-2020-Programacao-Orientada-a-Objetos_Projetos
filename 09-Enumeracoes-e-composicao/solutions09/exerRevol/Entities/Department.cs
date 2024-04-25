  
using exerRevol.Entities.Enums;
using System.Collections.Generic;

namespace exerRevol.Entities
{
  public class Department
  {
    public string Name { get; set; }

    public Department()
    {
    }

    public Department(string name)
    {
      Name = name;
    }
  }
}
using System;

namespace Starwars.Entities
{
    public class Jedi
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Jedi()
        {

        }

        public Jedi(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

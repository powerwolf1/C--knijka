using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
    {
        // fields
        public string Name = string.Empty;

        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();

        // constants
        public const string Species = "Homo Sapien";

        public readonly string HomePlanet = "Earth";
    }
}


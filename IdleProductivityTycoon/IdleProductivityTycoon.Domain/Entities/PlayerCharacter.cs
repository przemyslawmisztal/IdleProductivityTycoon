using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleProductivityTycoon.Domain.Entities
{
    public class PlayerCharacter
    {
        public string Name { get; set; } = "Player1";
        public List<Skill> Skills { get; set; } = [];
    }
}

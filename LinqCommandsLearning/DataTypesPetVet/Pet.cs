using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCommandsLearning.DataTypesPetVet
{
    public class Pet
    {
        public int Id { get;}
        public string Name { get;}
        public PetType PetType { get;}
        public float Weight { get;  }

        public Pet(int id, string name, PetType petType, float weight)
        {
            this.Id = id;
            Name = name;
            PetType = petType;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n Name::{Name}\n Type: {PetType}\n Weight: {Weight}";
        }

    }
}

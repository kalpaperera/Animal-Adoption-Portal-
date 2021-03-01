using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "OX", Age = 10, Description = "Strong, brave" },
            new Animal { Id = 2, Name = "rabbit", Age = 1, Description = "soft, fluffy" },
            new Animal { Id = 3, Name = "dog", Age = 3, Description = "loyal" },
        };
    }
}

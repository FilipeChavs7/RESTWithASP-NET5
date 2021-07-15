﻿using RESTWithASP_NET5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RESTWithASP_NET5.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i=0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }


        public Person FindById(long Id)
        {
            return new Person {Id= IncrementAndGet(), FirstName = "Filipe", LastName = "Chaves", Address= "Brasil", Gender = "Masc" };
        }

        public Person Update(Person person)
        {
            
            return person;
        }
        private Person MockPerson(int i)
        {
            
            return new Person 
            { 
                Id = IncrementAndGet(),
                FirstName = "Person Name" + i,
                LastName = "Person LastName" + i,
                Address = "Address Loc" + i,
                Gender = "Masc" 
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}

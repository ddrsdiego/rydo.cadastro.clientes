using System;
using System.Collections.Generic;
using System.Reflection;

namespace Rydo.Cadastro.Clientes.Api.Rydo.Cadastro.Clientes.Domain.SeedWorks
{
    public abstract class Enumeration : IComparable
    {
        public int Type { get; }
        public string TypeString { get; }
        public string Description { get; }

        protected Enumeration()
        {
        }

        protected Enumeration(int type, string description)
        {
            Type = type;
            Description = description;
        }

        protected Enumeration(string typeString, string description)
        {
            TypeString = typeString;
            Description = description;
        }

        public override string ToString()
        {
            return Description;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
        {
            var type = typeof(T);
            foreach (var info in type.GetTypeInfo().GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                var instance = new T();
                if (info.GetValue(instance) is T locatedValue)
                {
                    yield return locatedValue;
                }
            }
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;
            if (otherValue == null)
            {
                return false;
            }
            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Type.Equals(otherValue.Type);
            return typeMatches && valueMatches;
        }

        public int CompareTo(object obj) 
            => Type.CompareTo(((Enumeration)obj).Type);

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = (hash * 23) + Type.GetHashCode();
                return (hash * 23) + Description.GetHashCode();
            }
        }
    }
}
using System;

namespace librosc.Entities

{
    public record Item
    {
                // una vez creado no se puede modificar 
            public Guid Id {get;init;}

            public String Name { get; init;}
            public decimal Price {get;init;}
            public DateTimeOffset CreatedDate{ get; init;}
            
    }
}
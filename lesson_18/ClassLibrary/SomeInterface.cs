using System;

// an example of Library usage in c#

namespace ClassLibrary {
    public interface SomeInterface {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        decimal Salary { get; set; }
    }
}

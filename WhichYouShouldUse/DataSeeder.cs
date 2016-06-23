using System;
using System.Collections.Generic;
using WhichShouldYouUse.Models;

namespace WhichShouldYouUse
{
    public class DataSeeder
    {
        public static List<ComplexObject> GetManyComplexObjects()
        {
            return new List<ComplexObject>()
                       {
                           new ComplexObject()
                               {
                                   Date = DateTime.Today,
                                   Name = "Test1",
                                   Value = 1,
                                   Surname = "John"
                               },
                           new ComplexObject()
                               {
                                   Date = DateTime.Today,
                                   Name = "Test2",
                                   Value = 2,
                                   Surname = "John"
                               },
                           new ComplexObject()
                               {
                                   Date = DateTime.Today,
                                   Name = "Test3",
                                   Value = 3,
                                   Surname = "John"
                               },
                           new ComplexObject()
                               {
                                   Date = DateTime.Today,
                                   Name = "Test4",
                                   Value = 4,
                                   Surname = "John"
                               },
                           new ComplexObject()
                               {
                                   Date = DateTime.Today,
                                   Name = "Test5",
                                   Value = 5,
                                   Surname = "John"
                               },
                           new ComplexObject()
                               {
                                   Date = DateTime.Today,
                                   Name = "Test6",
                                   Value = 6,
                                   Surname = "John"
                               },
                       };
        }
    }
}
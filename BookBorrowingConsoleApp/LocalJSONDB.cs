using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrowingConsoleApp.model;

namespace BookBorrowingConsoleApp
{
    class LocalJSONDB
    {
        private static readonly string Data = @"{
            ""users"": [
                {
                    ""Id"": ""a1b2c3d4-e5f6-7g8h-9i0j-k1l2m3n4o5p6"",
                    ""CreatedBy"": null,
                    ""CreatedAt"": ""2025-04-08T12:00:00Z"",
                    ""UpdatedBy"": null,
                    ""UpdatedAt"": null,
                    ""FirstName"": ""John"",
                    ""LastName"": ""Doe"",
                    ""Email"": ""jdoe@test.com"",
                    ""Age"": 30,
                    ""Password"": ""password123"",
                    ""Role"": ""ADMIN""
                },
                {
                    ""Id"": ""b1c2d3e4-f5g6-h7i8-j9k0-l1m2n3o4p5q6"",
                    ""CreatedBy"": ""a1b2c3d4-e5f6-7g8h-9i0j-k1l2m3n4o5p6"",
                    ""CreatedAt"": ""2025-04-08T12:00:00Z"",
                    ""UpdatedBy"": null,
                    ""UpdatedAt"": null,
                    ""FirstName"": ""Jane"",
                    ""LastName"": ""Doe"",
                    ""Email"": ""jndoe@test.com"",
                    ""Age"": 28,
                    ""Password"": ""password123"",
                    ""Role"": ""USER""
                }
            ],
            ""books"": [
                {
                    ""Id"": ""a1b2c3d4-e5f6-7g8h-9i0j-k1l2m3n4o5p6"",
                    ""CreatedBy"": ""a1b2c3d4-e5f6-7g8h-9i0j-k1l2m3n4o5p6"",
                    ""CreatedAt"": ""2025-04-08T12:00:00Z"",
                    ""UpdatedBy"": null,
                    ""UpdatedAt"": null,
                    ""Title"": ""To Kill a Mockingbird"",
                    ""Author"": ""Harper Lee""
                },
                {
                    ""Id"": ""b1c2d3e4-f5g6-h7i8-j9k0-l1m2n3o4p5q6"",
                    ""CreatedBy"": ""a1b2c3d4-e5f6-7g8h-9i0j-k1l2m3n4o5p6"",
                    ""CreatedAt"": ""2025-04-08T12:00:00Z"",
                    ""UpdatedBy"": null,
                    ""UpdatedAt"": null,
                    ""Title"": ""1984"",
                    ""Author"": ""George Orwell""
                },
                {
                    ""Id"": ""c1d2e3f4-g5h6-i7j8-k9l0-m1n2o3p4q5r6"",
                    ""CreatedBy"": ""a1b2c3d4-e5f6-7g8h-9i0j-k1l2m3n4o5p6"",
                    ""CreatedAt"": ""2025-04-08T12:00:00Z"",
                    ""UpdatedBy"": null,
                    ""UpdatedAt"": null,
                    ""Title"": ""Pride and Prejudice"",
                    ""Author"": ""Jane Austen""
                },
                {
                    ""Id"": ""d1e2f3g4-h5i6-j7k8-l9m0-n1o2p3q4r5s6"",
                    ""CreatedBy"": ""a1b2c3d4-e5f6-7g8h-9i0j-k1l2m3n4o5p6"",
                    ""CreatedAt"": ""2025-04-08T12:00:00Z"",
                    ""UpdatedBy"": null,
                    ""UpdatedAt"": null,
                    ""Title"": ""The Great Gatsby"",
                    ""Author"": ""F. Scott Fitzgerald""
                },
                {
                    ""Id"": ""e1f2g3h4-i5j6-k7l8-m9n0-o1p2q3r4s5t6"",
                    ""CreatedBy"": ""a1b2c3d4-e5f6-7g8h-9i0j-k1l2m3n4o5p6"",
                    ""CreatedAt"": ""2025-04-08T12:00:00Z"",
                    ""UpdatedBy"": null,
                    ""UpdatedAt"": null,
                    ""Title"": ""Moby Dick"",
                    ""Author"": ""Herman Melville""
                }
            ],
            ""borrowed_books"": [

            ]
        }";

        public static string LoadJSON(string path)
        {
            // try-with-resource...
            //using(StreamReader reader = new StreamReader(path))
            //{
            //      string json = reader.ReadToEnd();
            //      return json;
            //}
            if (String.IsNullOrEmpty(path))
            {
                return LocalJSONDB.Data;
            }
            else
            {
                StreamReader reader = new StreamReader(path);
                string json = null;
                try
                {
                    json = reader.ReadToEnd();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw e;
                }
                finally
                {
                    reader.Close();
                }

                return json;
            }
            
        }
    }
}

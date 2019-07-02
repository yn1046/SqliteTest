using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Dbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace SqliteTest
{
    public static class Program
    {
        public static void Main()
        {
            using (var db = new MyContext())
            {
                foreach (var post in db.Posts.Include(p => p.Author))
                    Console.WriteLine("\n" + post);
            }
        }
    }
}
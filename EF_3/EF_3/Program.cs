// See https://aka.ms/new-console-template for more information
using EF_3;
using EF_3.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

PubsContext db = new PubsContext();

#region SqlFrom
//db.authors.FromSqlRaw("SELECT * FROM authors").Print();
//db.authors.FromSqlRaw("SELECT * FROM authors where au_id=@id",new SqlParameter("@id", "724-08-9931")).Print();
#endregion


#region Local

//Console.WriteLine(db.authors.Count());
//Console.WriteLine(db.authors.Local.Count());
//db.authors.Print();
//Console.WriteLine(db.authors.Count());
//Console.WriteLine(db.authors.Local.Count());

#region Find

//db.authors.Find("724-08-9931");
//Console.WriteLine(db.authors.Local.Count()); 
//db.authors.Find("724-08-9931");
//Console.WriteLine(db.authors.Local.Count());

#endregion

#region Q vs E
//Q Filter in Database While E Filter in Memory
//db.authors.AsEnumerable().Where(a => a.au_id == "724-08-9931").Print();//get All
//db.authors.AsQueryable().Where(a => a.au_id == "724-08-9931").Print();
//Console.WriteLine(db.authors.Local.Count());//get filtered
#endregion
#endregion


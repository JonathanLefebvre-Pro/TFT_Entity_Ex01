using Ex01.Context;
using Ex01.Entities;
using Microsoft.EntityFrameworkCore;



#region //Invoice/Shop/Client
Client c1 = new Client("Tom");
Client c2 = new Client("Jon");
Shop s1 = new Shop("Library");
Shop s2 = new Shop("Toys Factory");

Invoice invoice1 = new Invoice(s1, c1);
Invoice invoice2 = new Invoice(s2, c1);
Invoice invoice3 = new Invoice(s1, c2);
#endregion

using (ExContext db = new ExContext())
{
    //db.Roles.AddRange(role1,  role2, role3);
    //db.SaveChanges();

    //Role userRole = db.Roles.Where(x => x.Type == RoleType.user).FirstOrDefault()!;
    //User u1 = new User("Jonathan", "Lefebvre", "jl@gmail.com", userRole);
    //User u2 = new User("Thomas", "Roger", "tr@gmail.com", userRole);

    //db.Users.AddRange(u1, u2);
    //db.SaveChanges();

    /*foreach (User user in db.Users.AsNoTracking())
    {
        //user.Name = "Test";
        Console.WriteLine(user.Name);
    }*/

    //db.Invoices.AddRange(invoice1,  invoice2);
    //db.Invoices.Add(invoice3);
    //db.SaveChanges();

    /*IEnumerable<Invoice> invoices = db.Invoices.Include(x => x.Client).Include(x => x.Shop);
    foreach (Invoice invoice in invoices)
    {
        Console.WriteLine($"Invoice : {invoice.Id} | Client : {invoice.Client.Name} | Shop : {invoice.Shop.Name}");
    }*/

    /*foreach (Role role in db.Roles)
    {
        Console.WriteLine(role.TypeName);
    }*/

    foreach (User user in db.Users)
    {
        Console.WriteLine($"{user.Firstname} {user.Lastname} {user.Email} {user.Role.TypeName}");
        //TODO : Comment modifier le role id  des utilisateurs récuprérés ?
        //db.Entry(user).Entity.RoleId = 1;
    }
        //db.SaveChanges();
}
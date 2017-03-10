using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SuperMarketAssignment
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Customer a = new Customer();

            string insertString = @"CREATE TABLE Customer (CustId int not null, name varchar(50), address varchar(50), email varchar(50))";
            a.createCustomerTable(insertString);

            insertString = @"INSERT INTO Customer VALUES (1, 'Mary', 'Ballinasloe, Galway', 'mary@live.ie'), (2, 'Bob', 'Renvyle, Galway', 'bob@live.ie'), (3, 'Jenny', 'Spiddal, Galway', 'jenny@live.ie')";
            a.insertCustomerValues(insertString);

            insertString = @"ALTER TABLE Customer ADD PRIMARY KEY (CustId)";
            a.updateCustomerTable(insertString);

            insertString = @"SELECT * FROM Customer";
            a.readCustomerTable(insertString);

            insertString = @"UPDATE Customer SET email = 'therealbob@live.ie' WHERE CustId = 2";
            a.updateCustomerTable(insertString);

            //alter table here to make email therealbob@live.ie
            insertString = @"DELETE FROM Customer WHERE CustId = 3";
            a.deleteQueryCustomer(insertString);

            insertString = @"SELECT * FROM Customer";
            a.readCustomerTable(insertString);


            Product p = new Product();

            insertString = @"CREATE TABLE Product (ProductId int not null, name varchar(50), price decimal(5,2))";
            p.createProductTable(insertString);

            insertString = @"INSERT INTO Product VALUES (1, 'apple', 0.50), (2, 'orange', 0.60), (3, 'banana', 0.30), (4, 'stale banana', 0.10)";
            p.insertProductValues(insertString);

            insertString = @"ALTER TABLE Product ADD PRIMARY KEY (ProductId)";
            p.updateProductTable(insertString);

            insertString = @"UPDATE Product SET price = 0.40 WHERE ProductId = 3";
            p.updateProductTable(insertString);

            insertString = @"DELETE FROM Product WHERE ProductId = 4";
            p.deleteQueryProduct(insertString);

            insertString = @"SELECT * FROM Product";
            p.readProductTable(insertString);


            Order o = new Order();
            insertString = @"CREATE TABLE CustOrder(OrderID int not null, CustID int, ProductId int)";
            o.createOrdersTable(insertString);

            insertString = @"ALTER TABLE CustOrder ADD PRIMARY KEY (OrderID)";
            o.updateOrderTable(insertString);

            insertString = @"INSERT INTO CustOrder VALUES (1, 1, 2), (2, 1, 3), (3, 2, 1), (4, 2, 3)";
            o.insertOrderValues(insertString);

            insertString = @"SELECT * FROM CustOrder";
            o.readOrderTable(insertString);

            insertString = @"DELETE FROM Order WHERE OrderID = 4";


            Console.ReadKey();
        }
    }
}

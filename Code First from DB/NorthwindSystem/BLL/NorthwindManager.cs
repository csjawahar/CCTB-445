﻿using NorthwindSystem.DAL;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity; // for some of the EF extension methods
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindSystem.BLL
{
    // This is the primary public access into the NorthwindSystem's data
    [DataObject]
    public partial class NorthwindManager
    {
        #region Shippers
        public int AddShipper(Shipper info)
        {
            using (var context = new NWContext())
            {
                context.Shippers.Add(info);
                context.SaveChanges();
                return info.ShipperID;
            }
            throw new NotImplementedException("v.2.0");
        }

        public Shipper GetShipper(int shipperID)
        {
            using (var context = new NWContext())
            {
                return context.Shippers.Find(shipperID) ;
            }
            throw new NotImplementedException();
        }

        public IList<Shipper> ListShippers()
        {
            using (var context = new NWContext())
            {
                return context.Shippers.ToList();
            }
        }

        public void UpdateShipper(Shipper info)
        {
            //throw new NotImplementedException();
            //see qns and comentary on
            //stackoverflow.com/questions/15336248/entity-framework-5-updating-a-record
            using (var context = new NWContext())
            {
                context.Shippers.Attach(info);
                context.Entry(info).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteShipper(Shipper info)
        {
            using (var context = new NWContext())
            {
                var found = context.Shippers.Find(info.ShipperID);
                if (found != null)
                {
                    context.Shippers.Remove(found);
                    context.SaveChanges();
                }
            }
        }
        #endregion


        #region Products

        public int AddProduct(Product info)
        {
            using (var context = new NWContext())
            {
                context.Products.Add(info);
                context.SaveChanges();
                return info.ProductID;
            }
            throw new NotImplementedException("v.2.0");
        }

        public Product GetProduct(int productID)
        {
            using (var context = new NWContext())
            {
                return context.Products.Find(productID);
            }
            throw new NotImplementedException();
        }

        public IList<Product> ListProducts()
        {
            using (var context = new NWContext())
            {
                return context.Products.ToList();
            }
        }

        public void UpdateProduct(Product info)
        {
            //throw new NotImplementedException();
            //see qns and comentary on
            //stackoverflow.com/questions/15336248/entity-framework-5-updating-a-record
            using (var context = new NWContext())
            {
                context.Products.Attach(info);
                context.Entry(info).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteProduct(Product info)
        {
            using (var context = new NWContext())
            {
                var found = context.Products.Find(info.ProductID);
                if (found != null)
                {
                    context.Products.Remove(found);
                    context.SaveChanges();
                }
            }
        }
        #endregion

        #region Legacy Code
        public List<Employee> GetEmployees()
        {
            using (var context = new NWContext())
            {
                var result = context.Employees;
                return result.ToList();
            }
        }

        // TODO: Create a method called GetOrders() that will return a list of Order objects from the database.
        public List<Order> GetOrders()
        {
            using (var context = new NWContext())
            {
                var result = context.Orders;
                return result.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Region> GetRegions()
        {
            using (var context = new NWContext())
            {
                var result = 
                    context.Regions
                           .Include(item => item.Territories)
                           .OrderBy(item => item.RegionDescription);

                return result.ToList();
            }
        }
        #endregion








    }
}

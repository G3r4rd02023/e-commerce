using ecommerce.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ecommerce.Helpers
{
    public class CombosHelper:IDisposable
    {

        private static EcommerceContext db = new EcommerceContext();

        public static List<Department>GetDepartments()
        {
            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name = "[Select a department...]",
            });         

            return departments.OrderBy(d => d.Name).ToList();

        }

        public static List<Product> GetProducts(int companyId)
        {
            var products = db.Products.Where(p => p.CompanyId == companyId).ToList();
            products.Add(new Product
            {
                ProductID = 0,
                Description = "[Select a product...]",
            });

            return products.OrderBy(p => p.Description).ToList();
        }

        public static List<City> GetCities()
        {
            var cities = db.Cities.ToList();
            cities.Add(new City
            {
                CityId = 0,
                Name = "[Select a city...]",
            });

            return cities.OrderBy(c => c.Name).ToList();

        }

        public static List<Company> GetCompanies()
        {
            var companies = db.Companies.ToList();
            companies.Add(new Company
            {
                CompanyId = 0,
                Name = "[Select a company...]",
            });

            return companies.OrderBy(c => c.Name).ToList();

        }

        public static List<Category> GetCategories(int companyId)
        {
            var categories = db.Categories.Where(c => c.CompanyId == companyId).ToList();
            categories.Add(new Category
            {
                CategoryId = 0,
                Description = "[Select a category...]",
            });

            return categories.OrderBy(c => c.Description).ToList();
        }

        public static IEnumerable GetCustomers(int companyId)
        {
            var customers = db.Customers.Where(c => c.CompanyId == companyId).ToList();
            customers.Add(new Customer
            {
                CustomerId = 0,
                FirstName = "[Select a customer...]",
            });

            return customers.OrderBy(c => c.FirstName).ThenBy(c=>c.LastName).ToList();
        }

        public static List<Tax> GetTaxes(int companyId)
        {
            var taxes = db.Taxes.Where(c => c.CompanyId == companyId).ToList();
            taxes.Add(new Tax
            {
                TaxId = 0,
                Description = "[Select a tax...]",
            });

            return taxes.OrderBy(t => t.Description).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        
    }
}
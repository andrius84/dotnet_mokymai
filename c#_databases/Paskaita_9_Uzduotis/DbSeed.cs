using Paskaita_9_Uzduotis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Paskaita_9_Uzduotis
{
    public static class DbSeed
    {
        public static void Seed(AppDbContext context)
        {
            var companies = new List<Company>
        {
            new Company { Name = "Vilniaus Energija", Address = "Gedimino pr. 1, Vilnius" },
            new Company { Name = "Telia Lietuva", Address = "Saltoniškių g. 7, Vilnius" },
            new Company { Name = "Maxima LT", Address = "Savanorių pr. 247, Vilnius" }
        };
            context.Companies.AddRange(companies);
            context.SaveChanges();
        
            var departments = new List<Department>
        {
            new Department { Name = "IT" },
            new Department { Name = "Žmogiškieji ištekliai" },
            new Department { Name = "Finansai" },
            new Department { Name = "Pardavimai" },
            new Department { Name = "Marketingas" },
            new Department { Name = "Tyrimai ir plėtra" }
        };
            context.Departments.AddRange(departments);
            context.SaveChanges();

            var projects = new List<Project>
        {
            new Project { Name = "Skaitmeninė transformacija" },
            new Project { Name = "Nauja rinkodaros kampanija" },
            new Project { Name = "Tiekimo grandinės optimizavimas" },
            new Project { Name = "Klientų aptarnavimo patobulinimai" },
            new Project { Name = "Naujų produktų kūrimas" }
        };
            context.Projects.AddRange(projects);
            context.SaveChanges();

            var employees = new List<Employee>
        {
            new Employee { FirstName = "Marius", LastName = "Pavardenis" },
            new Employee { FirstName = "Lina", LastName = "Žukauskaitė" },
            new Employee { FirstName = "Dainius", LastName = "Petravičius" },
            new Employee { FirstName = "Aistė", LastName = "Grigaitė" },
            new Employee { FirstName = "Gediminas", LastName = "Stankus" },
            new Employee { FirstName = "Vaida", LastName = "Urbonaitė" },
            new Employee { FirstName = "Mindaugas", LastName = "Juozapavičius" },
            new Employee { FirstName = "Eglė", LastName = "Butkienė" },
            new Employee { FirstName = "Rimantas", LastName = "Valaitis" },
            new Employee { FirstName = "Viktorija", LastName = "Paulauskaitė" }
        };
            context.Employees.AddRange(employees);
            context.SaveChanges();

            var managers = new List<Manager>
        {
            new Manager { FirstName = "Jonas", LastName = "Kazlauskas" },
            new Manager { FirstName = "Rasa", LastName = "Petrauskienė" },
            new Manager { FirstName = "Petras", LastName = "Jonaitis" }
        };
            context.Managers.AddRange(managers);
            context.SaveChanges();
        }
    }
}

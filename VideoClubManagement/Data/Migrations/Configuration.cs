namespace VideoClubManagement.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VideoClubManagement.Data.Entities;
    using VideoClubManagement.Data.Enums;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Data\Migrations";
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.LegalPersonTypes.AddOrUpdate(
                lp => lp.Id,
                new LegalPersonType
                {
                    Id = LegalPersonTypeId.Juridic,
                    Name = nameof(LegalPersonTypeId.Juridic),
                    Description = "It is a non-human legal entity that is not a single natural person but an organization recognized by law as a legal person such as a corporation, government agency, or NGO.",
                    IsActive = true
                },
                new LegalPersonType
                {
                    Id = LegalPersonTypeId.Physical,
                    Name = nameof(LegalPersonTypeId.Physical),
                    Description = "It is a person (in legal meaning, i.e., one who has its own legal personality) that is an individual human being.",
                    IsActive = true
                });

            context.UserRoles.AddOrUpdate(
                ur => ur.Id,
                new UserRole
                {
                    Id = UserRoleId.Admin,
                    Name = nameof(UserRoleId.Admin),
                    Description = "It is the user with the highest level of authorization, this user manages the system configuration and also " +
                                  "can do everything that all users do.",
                    IsActive = true
                },
                new UserRole
                {
                    Id = UserRoleId.Employee,
                    Name = nameof(UserRoleId.Employee),
                    Description = "It is the user corresponding to an employee.",
                    IsActive = true
                });

            context.Users.AddOrUpdate(
                u => u.UserName,
                new User
                {
                    UserRoleId = UserRoleId.Admin,
                    UserName = "admin",
                    Email = "admin@unapec.edu.do",
                    Password = "123456",
                    IdentificationNumber = "01234567890",
                    IsActive = true
                });

             context.SaveChanges();
        }
    }
}

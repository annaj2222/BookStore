﻿

namespace Books.Domain.Utilities
{
    public static class Roles
    {
        public enum RoleType
        {
            SuperAdmin,
            Admin,
            Employee,
            Individual,
        }

        public static List<RoleType> GetAllRoles { get; set; } = new List<RoleType>
        {
             RoleType.SuperAdmin,
             RoleType.Admin,
             RoleType.Employee,
             RoleType.Individual,
        };
    }
}

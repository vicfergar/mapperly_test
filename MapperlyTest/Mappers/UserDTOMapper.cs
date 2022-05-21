using MapperlyTest.DTOs;
using MapperlyTest.Entities;
using Riok.Mapperly.Abstractions;

namespace MapperlyTest.Mappers
{
    [Mapper]
    internal static partial class UserDTOMapper
    {
        internal static UserDTO Map(UserEntity userEntity)
        {
            var user = InternalMap(userEntity);
            user.Roles = new[] { RoleDTO.Rep };
            return user;
        }

        internal static UserDTO Map(AdminEntity admin)
        {
            var user = InternalMap(admin);
            user.FirstName = GetFirstName(admin.Name);
            user.LastName = GetLastName(admin.Name);
            return user;
        }

        [MapperIgnore(nameof(UserDTO.Roles))]
        private static partial UserDTO InternalMap(UserEntity user);

        [MapProperty(nameof(AdminEntity.Groups), nameof(UserDTO.Roles))]
        [MapperIgnore(nameof(UserDTO.FirstName))]
        [MapperIgnore(nameof(UserDTO.LastName))]
        private static partial UserDTO InternalMap(AdminEntity admin);

        private static RoleDTO[] Map(string[]? stringRoles)
        {
            if (stringRoles is null)
            {
                return Array.Empty<RoleDTO>();
            }

            return stringRoles.Select(x => Enum.TryParse<RoleDTO>(x, ignoreCase: true, out var adminRole) ? adminRole : (RoleDTO?)null)
                                .Where(x => x != null)
                                .Cast<RoleDTO>()
                                .ToArray();
        }

        private static string? GetFirstName(string? name)
        {
            if (name is null)
            {
                return string.Empty;
            }

            var index = name.IndexOf(' ', StringComparison.Ordinal);
            return index < 0 ? name : name[..index];
        }

        private static string? GetLastName(string? name)
        {
            if (name is null)
            {
                return string.Empty;
            }

            var index = name.IndexOf(' ', StringComparison.Ordinal);
            return index < 0 ? string.Empty : name[(index + 1)..];
        }
    }
}

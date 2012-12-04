//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Auth Service class
    /// </summary>
    public partial class AuthService : Service<Auth, AuthDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthService"/> class
        /// </summary>
        public AuthService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthService"/> class
        /// </summary>
        public AuthService(IRepository<Auth> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override Auth CreateNew()
        {
            return new Auth();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<AuthDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<AuthDto> QueryableDto( IQueryable<Auth> items )
        {
            return items.Select( m => new AuthDto()
                {
                    EntityTypeId = m.EntityTypeId,
                    EntityId = m.EntityId,
                    Order = m.Order,
                    Action = m.Action,
                    AllowOrDeny = m.AllowOrDeny,
                    SpecialRole = m.SpecialRole,
                    PersonId = m.PersonId,
                    GroupId = m.GroupId,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( Auth item, out string errorMessage )
        {
            errorMessage = string.Empty;
            return true;
        }
    }
}

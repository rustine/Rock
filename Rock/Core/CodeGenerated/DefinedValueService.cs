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
    /// DefinedValue Service class
    /// </summary>
    public partial class DefinedValueService : Service<DefinedValue, DefinedValueDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedValueService"/> class
        /// </summary>
        public DefinedValueService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinedValueService"/> class
        /// </summary>
        public DefinedValueService(IRepository<DefinedValue> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override DefinedValue CreateNew()
        {
            return new DefinedValue();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<DefinedValueDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<DefinedValueDto> QueryableDto( IQueryable<DefinedValue> items )
        {
            return items.Select( m => new DefinedValueDto()
                {
                    IsSystem = m.IsSystem,
                    DefinedTypeId = m.DefinedTypeId,
                    Order = m.Order,
                    Name = m.Name,
                    Description = m.Description,
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
        public bool CanDelete( DefinedValue item, out string errorMessage )
        {
            errorMessage = string.Empty;
            RockContext context = new RockContext();
            context.Database.Connection.Open();

            using ( var cmdCheckRef = context.Database.Connection.CreateCommand() )
            {
                cmdCheckRef.CommandText = string.Format( "select count(*) from Fund where FundTypeId = {0} ", item.Id );
                var result = cmdCheckRef.ExecuteScalar();
                int? refCount = result as int?;
                if ( refCount > 0 )
                {
                    Type entityType = RockContext.GetEntityFromTableName( "Fund" );
                    string friendlyName = entityType != null ? entityType.GetFriendlyTypeName() : "Fund";

                    errorMessage = string.Format("This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, friendlyName);
                    return false;
                }
            }

            using ( var cmdCheckRef = context.Database.Connection.CreateCommand() )
            {
                cmdCheckRef.CommandText = string.Format( "select count(*) from GroupLocation where LocationTypeId = {0} ", item.Id );
                var result = cmdCheckRef.ExecuteScalar();
                int? refCount = result as int?;
                if ( refCount > 0 )
                {
                    Type entityType = RockContext.GetEntityFromTableName( "GroupLocation" );
                    string friendlyName = entityType != null ? entityType.GetFriendlyTypeName() : "GroupLocation";

                    errorMessage = string.Format("This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, friendlyName);
                    return false;
                }
            }

            using ( var cmdCheckRef = context.Database.Connection.CreateCommand() )
            {
                cmdCheckRef.CommandText = string.Format( "select count(*) from Metric where CollectionFrequencyId = {0} ", item.Id );
                var result = cmdCheckRef.ExecuteScalar();
                int? refCount = result as int?;
                if ( refCount > 0 )
                {
                    Type entityType = RockContext.GetEntityFromTableName( "Metric" );
                    string friendlyName = entityType != null ? entityType.GetFriendlyTypeName() : "Metric";

                    errorMessage = string.Format("This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, friendlyName);
                    return false;
                }
            }

            using ( var cmdCheckRef = context.Database.Connection.CreateCommand() )
            {
                cmdCheckRef.CommandText = string.Format( "select count(*) from PhoneNumber where NumberTypeId = {0} ", item.Id );
                var result = cmdCheckRef.ExecuteScalar();
                int? refCount = result as int?;
                if ( refCount > 0 )
                {
                    Type entityType = RockContext.GetEntityFromTableName( "PhoneNumber" );
                    string friendlyName = entityType != null ? entityType.GetFriendlyTypeName() : "PhoneNumber";

                    errorMessage = string.Format("This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, friendlyName);
                    return false;
                }
            }

            using ( var cmdCheckRef = context.Database.Connection.CreateCommand() )
            {
                cmdCheckRef.CommandText = string.Format( "select count(*) from Pledge where FrequencyTypeId = {0} ", item.Id );
                var result = cmdCheckRef.ExecuteScalar();
                int? refCount = result as int?;
                if ( refCount > 0 )
                {
                    Type entityType = RockContext.GetEntityFromTableName( "Pledge" );
                    string friendlyName = entityType != null ? entityType.GetFriendlyTypeName() : "Pledge";

                    errorMessage = string.Format("This {0} is assigned to a {1}.", DefinedValue.FriendlyTypeName, friendlyName);
                    return false;
                }
            }

            return true;
        }
    }
}

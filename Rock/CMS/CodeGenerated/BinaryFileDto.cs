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
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Data Transfer Object for BinaryFile object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class BinaryFileDto : IDto, DotLiquid.ILiquidizable
    {
        /// <summary />
        [DataMember]
        public bool IsTemporary { get; set; }

        /// <summary />
        [DataMember]
        public bool IsSystem { get; set; }

        /// <summary />
        [DataMember]
        public Byte[] Data { get; set; }

        /// <summary />
        [DataMember]
        public string Url { get; set; }

        /// <summary />
        [DataMember]
        public string FileName { get; set; }

        /// <summary />
        [DataMember]
        public string MimeType { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary />
        [DataMember]
        public string Description { get; set; }

        /// <summary />
        [DataMember]
        public int Id { get; set; }

        /// <summary />
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public BinaryFileDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="binaryFile"></param>
        public BinaryFileDto ( BinaryFile binaryFile )
        {
            CopyFromModel( binaryFile );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public virtual Dictionary<string, object> ToDictionary()
        {
            var dictionary = new Dictionary<string, object>();
            dictionary.Add( "IsTemporary", this.IsTemporary );
            dictionary.Add( "IsSystem", this.IsSystem );
            dictionary.Add( "Data", this.Data );
            dictionary.Add( "Url", this.Url );
            dictionary.Add( "FileName", this.FileName );
            dictionary.Add( "MimeType", this.MimeType );
            dictionary.Add( "LastModifiedTime", this.LastModifiedTime );
            dictionary.Add( "Description", this.Description );
            dictionary.Add( "Id", this.Id );
            dictionary.Add( "Guid", this.Guid );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public virtual dynamic ToDynamic()
        {
            dynamic expando = new ExpandoObject();
            expando.IsTemporary = this.IsTemporary;
            expando.IsSystem = this.IsSystem;
            expando.Data = this.Data;
            expando.Url = this.Url;
            expando.FileName = this.FileName;
            expando.MimeType = this.MimeType;
            expando.LastModifiedTime = this.LastModifiedTime;
            expando.Description = this.Description;
            expando.Id = this.Id;
            expando.Guid = this.Guid;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyFromModel( IEntity model )
        {
            if ( model is BinaryFile )
            {
                var binaryFile = (BinaryFile)model;
                this.IsTemporary = binaryFile.IsTemporary;
                this.IsSystem = binaryFile.IsSystem;
                this.Data = binaryFile.Data;
                this.Url = binaryFile.Url;
                this.FileName = binaryFile.FileName;
                this.MimeType = binaryFile.MimeType;
                this.LastModifiedTime = binaryFile.LastModifiedTime;
                this.Description = binaryFile.Description;
                this.Id = binaryFile.Id;
                this.Guid = binaryFile.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is BinaryFile )
            {
                var binaryFile = (BinaryFile)model;
                binaryFile.IsTemporary = this.IsTemporary;
                binaryFile.IsSystem = this.IsSystem;
                binaryFile.Data = this.Data;
                binaryFile.Url = this.Url;
                binaryFile.FileName = this.FileName;
                binaryFile.MimeType = this.MimeType;
                binaryFile.LastModifiedTime = this.LastModifiedTime;
                binaryFile.Description = this.Description;
                binaryFile.Id = this.Id;
                binaryFile.Guid = this.Guid;
            }
        }

        /// <summary>
        /// Converts to liquidizable object for dotLiquid templating
        /// </summary>
        /// <returns></returns>
        public object ToLiquid()
        {
            return this.ToDictionary();
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public static class BinaryFileDtoExtension
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static BinaryFile ToModel( this BinaryFileDto value )
        {
            BinaryFile result = new BinaryFile();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<BinaryFile> ToModel( this List<BinaryFileDto> value )
        {
            List<BinaryFile> result = new List<BinaryFile>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<BinaryFileDto> ToDto( this List<BinaryFile> value )
        {
            List<BinaryFileDto> result = new List<BinaryFileDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static BinaryFileDto ToDto( this BinaryFile value )
        {
            return new BinaryFileDto( value );
        }

    }
}
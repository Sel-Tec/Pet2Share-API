//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet2Share_API.DAL
{
    using System;
    
    public partial class GetMyFeed_Result
    {
        public int Id { get; set; }
        public int PostTypeId { get; set; }
        public string Description { get; set; }
        public string PostURL { get; set; }
        public int PostedBy { get; set; }
        public bool IsPostByPet { get; set; }
        public int PostLikeCount { get; set; }
        public string PostLikedBy { get; set; }
        public int PostCommentCount { get; set; }
        public bool IsPublic { get; set; }
        public System.DateTime DateAdded { get; set; }
        public System.DateTime DateModified { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
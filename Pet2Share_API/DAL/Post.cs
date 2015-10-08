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
    using System.Collections.Generic;
    
    public partial class Post
    {
        public Post()
        {
            this.Post_Uploads = new HashSet<Post_Upload>();
            this.PostLikes = new HashSet<PostLike>();
        }
    
        public int ID { get; set; }
        public int PostTypeID { get; set; }
        public string Description { get; set; }
        public int PostedBy { get; set; }
        public bool IsPostByPet { get; set; }
        public int PostLikeCount { get; set; }
        public int PostCommentCount { get; set; }
        public System.DateTime DateAdded { get; set; }
        public System.DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual ICollection<Post_Upload> Post_Uploads { get; set; }
        public virtual PostType PostType { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; }
    }
}